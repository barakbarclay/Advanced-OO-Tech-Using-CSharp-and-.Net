using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            int[,] boardValues = new int[9, 9];
            int i = 8;
            int j = 8;

            var allTextBoxes = this.GetChildControls<TextBox>();
            foreach (TextBox tb in allTextBoxes)
            {
                if (tb.Name != "debugTextBox")
                {
                    if (!Int32.TryParse(tb.Text, out boardValues[i, j]))
                        boardValues[i, j] = 0;
                    i--;
                    if (i == -1)
                    {
                        i = 8;
                        j--;
                    }
                }
            }

            bool good = Validate(boardValues);
            if (good == true)
                debugTextBox.Lines = new string[] { "Board solved correctly." };
            else
                debugTextBox.Lines = new string[] { "Board not solved correctly." };

        }

        public bool Validate(int[,] grid)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i, j] == 0)
                        return false;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                bool[] row = new bool[10];
                bool[] col = new bool[10];

                for (int j = 0; j < 9; j++)
                {
                    if (row[grid[i, j]] & grid[i, j] > 0)
                    {
                        return false;
                    }
                    row[grid[i, j]] = true;

                    if (col[grid[j, i]] & grid[j, i] > 0)
                    {
                        return false;
                    }
                    col[grid[j, i]] = true;

                    if ((i + 3) % 3 == 0 && (j + 3) % 3 == 0)
                    {
                        bool[] sqr = new bool[10];
                        for (int m = i; m < i + 3; m++)
                        {
                            for (int n = j; n < j + 3; n++)
                            {
                                if (sqr[grid[m, n]] & grid[m, n] > 0)
                                {
                                    return false;
                                }
                                sqr[grid[m, n]] = true;
                            }
                        }
                    }

                }
            }
            return true;
        }


        private void Solve_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[,] boardValues = new int[9, 9];
            int[,] solution = new int[9, 9];
            int i = 8;
            int j = 8;

            var allTextBoxes = this.GetChildControls<TextBox>();
            foreach (TextBox tb in allTextBoxes)
            {
                if (tb.Name != "debugTextBox")
                {
                    if (!Int32.TryParse(tb.Text, out boardValues[i, j]))
                        boardValues[i, j] = 0;
                    i--;
                    if (i == -1)
                    {
                        i = 8;
                        j--;
                    }
                }
            }

            if (true == solve_soduko(boardValues))
            {
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                debugTextBox.Lines = new string[] { "Board solved in " + ts.Seconds.ToString() + " seconds and " + ts.Milliseconds.ToString() + " milliseconds."};

                i = 8;
                j = 8;
                foreach (TextBox tb in allTextBoxes)
                {
                    if (tb.Name != "debugTextBox")
                    {
                        tb.Lines = new string[] { boardValues[i, j].ToString() };
                        i--;
                        if (i < 0)
                        {
                            j--;
                            i = 8;
                        }
                    }
                }
            }
            else
            {
                debugTextBox.Lines = new string[] { "Cannot solve board in this state." };
            }
        }












        // Returns a boolean which indicates whether any assigned entry
        // in the specified row matches the given number. 
        bool used_in_row(int[,] grid, int row, int num)
        {
            for (int col = 0; col < 9; col++)
                if (grid[row, col] == num)
                {
                    return true;
                }
            return false;
        }

        // Returns a boolean which indicates whether any assigned entry
        // in the specified column matches the given number. 
        bool used_in_col(int[,] grid, int col, int num)
        {
            for (int row = 0; row < 9; row++)
                if (grid[row, col] == num)
                {
                    return true;
                }
            return false;
        }

        // Returns a boolean which indicates whether any assigned entry
        // within the specified 3x3 box matches the given number. 
        bool used_in_box(int[,] grid, int box_start_row, int box_start_col, int num)
        {
            for (int row = 0; row < 3; row++)
                for (int col = 0; col < 3; col++)
                    if (grid[row + box_start_row, col + box_start_col] == num)
                    {
                        return true;
                    }
            return false;
        }

        // Returns a boolean which indicates whether it will be legal to assign
        // num to the given row,col location.
        bool is_safe(int[,] grid, int row, int col, int num)
        {
            // Check if 'num' is not already placed in current row,
            // current column and current 3x3 box 
            return !used_in_row(grid, row, num) &&
                !used_in_col(grid, col, num) &&
                !used_in_box(grid, row - row % 3, col - col % 3, num);
        }

        // Searches the grid to find an entry that is still unassigned. If
        // found, the reference parameters row, col will be set the location
        // that is unassigned, and true is returned. If no unassigned entries
        // remain, false is returned. 
        Tuple<int, int> get_unassigned_location(int[,] grid)
        {
            for (int row = 0; row < 9; row++)
                for (int col = 0; col < 9; col++)
                    if (grid[row, col] == 0)
                    {
                        return Tuple.Create(row, col);
                    }
            return Tuple.Create(9, 9);
        }

        // Takes a partially filled-in grid and attempts to assign values to
        // all unassigned locations in such a way to meet the requirements
        // for Sudoku solution (non-duplication across rows, columns, and boxes) 
        bool solve_soduko(int[,] grid)
        {
            // If the Soduko grid has been filled, we are done
            //Tuple<int, int> nineNine = Tuple.Create(9, 9);
            //if (nineNine == get_unassigned_location(grid))
            //{
            //    return true;
            //}

            // Get an unassigned Soduko grid location
            Tuple<int, int> row_and_col = get_unassigned_location(grid);
            int row = row_and_col.Item1;
            int col = row_and_col.Item2;

            if (row == 9 || col == 9)
            {
                return true;
            }

            // Consider digits 1 to 9
            for (int num = 1; num <= 9; num++)
            {
                // If placing the current number in the current
                // unassigned location is valid, go ahead
                if (is_safe(grid, row, col, num))
                {
                    // Make tentative assignment
                    grid[row, col] = num;

                    // Do the same thing again recursively. If we go 
                    // through all of the recursions, and in the end 
                    // return true, then all of our number placements 
                    // on the Soduko grid are valid and we have fully
                    // solved it
                    if (solve_soduko(grid))
                    {
                        return true;
                    }

                    // As we were not able to validly go through all 
                    // of the recursions, we must have an invalid number
                    // placement somewhere. Lets go back and try a 
                    // different number for this particular unassigned location
                    grid[row, col] = 0;
                }
            }

            // If we have gone through all possible numbers for the current unassigned
            // location, then we probably assigned a bad number early. Lets backtrack 
            // and try a different number for the previous unassigned locations.
            return false;
        }










        private void Load_Preloaded_Click(object sender, EventArgs e)
        {
            string examplesPath = AppDomain.CurrentDomain.BaseDirectory;
            examplesPath = examplesPath + @"\examples.txt";
            StreamReader MyStreamReader = new StreamReader(examplesPath);
            var allBoards = File.ReadAllLines(examplesPath);
            var r = new Random();
            var randomLineNumber = r.Next(0, allBoards.Length - 1);
            var allBoardValues = allBoards[randomLineNumber];
            char oneBoardValue;
            int indexOfBoardValue = 80;

            var allTextBoxes = this.GetChildControls<TextBox>();
            foreach (TextBox tb in allTextBoxes)
            {
                if (tb.Name != "debugTextBox")
                {
                    oneBoardValue = allBoardValues[indexOfBoardValue];
                    if (oneBoardValue != '.')
                    {
                        tb.Lines = new string[] { oneBoardValue.ToString() };
                        tb.ReadOnly = true;
                    }
                    else
                    {
                        tb.Lines = new string[] { "" };
                        tb.ReadOnly = false;
                    }
                    indexOfBoardValue--;
                }
            }

            debugTextBox.Lines = new string[] { "Preloaded board line:" + allBoardValues.ToString() };

            MyStreamReader.Close();
            MyStreamReader.Dispose();
        }

        private void Load_Random_Click(object sender, EventArgs e)
        {
            var nums = Enumerable.Range(1, 9).ToArray();
            var rnd = new Random();
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rnd.Next(nums.Length);
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }

            int indexOfBoardValue = 80;
            int j = 0;
            var allTextBoxes = this.GetChildControls<TextBox>();
            foreach (TextBox tb in allTextBoxes)
            {
                if (tb.Name != "debugTextBox")
                {
                    if (j < 9)
                    {
                        tb.Lines = new string[] { nums[j].ToString() };
                        tb.ReadOnly = false;
                        j++;
                    }
                    else
                    {
                        tb.Lines = new string[] { "" };
                        tb.ReadOnly = false;
                    }
                    indexOfBoardValue--;
                }
            }

            Solve_Click(sender, e);

            indexOfBoardValue = 80;
            foreach (TextBox tb in allTextBoxes)
            {
                if (tb.Name != "debugTextBox")
                {
                    if (rnd.Next(2) == 0)
                    {
                        tb.ReadOnly = true;
                    }
                    else
                    {
                        tb.Lines = new string[] { "" };
                        tb.ReadOnly = false;
                    }
                    indexOfBoardValue--;
                }
            }
            debugTextBox.Lines = new string[] { "Random Board Loaded." };
        }
    }
}
