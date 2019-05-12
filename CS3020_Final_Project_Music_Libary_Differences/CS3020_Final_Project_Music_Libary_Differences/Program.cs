using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CS3020_Final_Project_Music_Libary_Differences
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// INPUT FILES MUST HAVE EACH SONG ON A SEPERATE LINE WITH THE ARTIST NAME BEFORE THE SONG NAME ON THE LINE.
            /// TO MAKE IT EASY TO LOOK AT & GET RID OF MORE SONGS BEFORE USER INPUT:
            ///     PUT INPUT IN ALL CAPS
            ///     SEPERATE ARTIST NAME AND SONG NAME WITH |
            ///     CHANGE SQUARE BRACKESTS TO PARENTHESIS
            ///     USE NOTEPAD++ CODE ALIGNMENT WITH |
            ///     USE FIND AND REPLACE TO ADD EXTRA TABS AND SPACES IN THE NEEEDED FILE 
            /// </summary>

            /// <summary>
            /// GETS RID OF EXACT MATCHES IGNORING JUNK FROM STRINGS
            /// </summary>
            //string line;
            //StreamReader file = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Itunes_Songs_Caps.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    string tempFile = Path.GetTempFileName();
            //    IEnumerable<string> linesToKeep = File.ReadLines(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt").Where(l => RemoveJunk(l) != RemoveJunk(line));
            //    //var linesToKeep = File.ReadLines(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt").Where(l => string.Equals(l, line, StringComparison.CurrentCultureIgnoreCase) == false);

            //    File.WriteAllLines(tempFile, linesToKeep);

            //    File.Delete(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //    File.Move(tempFile, @AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //}
            //file.Close();



            /// <summary>
            /// GETS RID OF STRINGS WITH DISTANCE OF 3 OR LESS IGNORING JUNK
            /// </summary>
            //string line;
            //StreamReader file = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Itunes_Songs_Caps.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    string tempFile = Path.GetTempFileName();
            //    IEnumerable<string> linesToKeep = File.ReadLines(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt").Where(l => LevenshteinDistance.Compute(RemoveJunk(l), RemoveJunk(line)) > 3);

            //    File.WriteAllLines(tempFile, linesToKeep);

            //    File.Delete(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //    File.Move(tempFile, @AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            //}
            //file.Close();



            /// <summary>
            /// CODE BELOW IN MAIN IS TO ALLOW USER TO CHOOSE WHAT TO DO WITH REMAINDING SONGS
            /// </summary>
            List<string> linesToDownload = new List<string>();
            List<string> linesToManuallyCheck = new List<string>();
            List<string> linesToKeep = new List<string>();

            string lineFromInitializeLinesToKeep;
            StreamReader initializeLinesToKeep = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            while ((lineFromInitializeLinesToKeep = initializeLinesToKeep.ReadLine()) != null)//CHANGE TO NULL TO RUN THROUGH WHOLE THING
            {
                linesToKeep.Add(lineFromInitializeLinesToKeep);
            }
            initializeLinesToKeep.Close();

            char keepMoveDeleteSong = 'a';
            string lineFromCheckFile;
            string lineFromItunesFile;
            StreamReader songsToCheckFile = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Check.txt");
            while ((lineFromCheckFile = songsToCheckFile.ReadLine()) != null)
            {

                List<Data> list = new List<Data>();
                StreamReader itunesSongsFile = new StreamReader(@AppDomain.CurrentDomain.BaseDirectory + "\\Itunes_Songs_Caps.txt");
                while ((lineFromItunesFile = itunesSongsFile.ReadLine()) != null)
                {
                    list.Add(new Data(LevenshteinDistance.Compute(RemoveJunk(lineFromItunesFile), RemoveJunk(lineFromCheckFile)), lineFromItunesFile));
                }
                itunesSongsFile.Close();

                Console.WriteLine("\n\t" + lineFromCheckFile + "\n");
                list.Sort((i1, i2) => i1.IntegerData.CompareTo(i2.IntegerData));
                for (int index = 0; index < 40; index++)
                    Console.WriteLine(list[index].IntegerData + ":\t" + list[index].StringData);

                Console.WriteLine("\na = already have\nw = we need to manually check this song\nd = download list");
                keepMoveDeleteSong = Console.ReadKey().KeyChar;
                switch (keepMoveDeleteSong)
                {
                    case 'a':
                        linesToKeep.Remove(lineFromCheckFile);
                        File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_Left_To_Check.txt", linesToKeep);
                        break;
                    case 'w':
                        linesToKeep.Remove(lineFromCheckFile);
                        File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_Left_To_Check.txt", linesToKeep);
                        File.AppendAllText(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Manually_Check.txt", "\n" + lineFromCheckFile);
                        break;
                    case 'd':
                        linesToKeep.Remove(lineFromCheckFile);
                        File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_Left_To_Check.txt", linesToKeep);
                        File.AppendAllText(@AppDomain.CurrentDomain.BaseDirectory + "\\Songs_To_Download.txt", "\n" + lineFromCheckFile);
                        break;
                    // Does nothing if you accidently hit something else
                    default:
                        break;
                }
                Console.Clear();
            }
            songsToCheckFile.Close();

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public struct Data
        {
            public Data(int intValue, string strValue)
            {
                IntegerData = intValue;
                StringData = strValue;
            }
            public int IntegerData { get; set; }
            public string StringData { get; set; }
        }

        public static string RemoveJunk(string str)
        {
            return RemoveSpecialCharacters(str.GetUntilOrEmpty().GetUntilOrEmpty().GetUntilOrEmpty());
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
        }
    }

    static class LevenshteinDistance
    {
        /// <summary>
        /// Compute the distance between two strings.
        /// </summary>
        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
                return m;
            if (m == 0)
                return n;
            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++) { }
            for (int j = 0; j <= m; d[0, j] = j++) { }
            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }

    static class Helper
    {
        public static string GetUntilOrEmpty(this string text, string stopAt = "(", string startAgainAt = ")")
        {
            if (!String.IsNullOrWhiteSpace(text))
            {
                int charLocation = text.IndexOf(stopAt, StringComparison.Ordinal);
                int secondCharLocation = text.IndexOf(startAgainAt, StringComparison.Ordinal);

                if (charLocation >= 0)
                {
                    return text.Substring(0, charLocation) + text.Substring(secondCharLocation + 1, text.Length - (secondCharLocation + 1));
                }
            }
            return text;
        }
    }
}
