﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3020_Enigma_Machine_HW
{
    public partial class Form1 : Form
    {
        Rotor[] rotors = new Rotor[4];
        Reflector reflector;
        Machine machine;

        public Form1()
        {
            InitializeComponent();
            //Change rotor offsets (addition paths) here
            //Note: Paths list must be given by how much the digit increases.
            //      If the digit decreases in path, create list with other value in this pair list:
            //      (0,0), (1,9), (2,8), (3,7), (4,6), (5,5)
            rotors[0] = new Rotor(new List<int>() { 1, 2, 4, 7, 1, 9, 2, 0, 1, 3 }, 0);
            rotors[1] = new Rotor(new List<int>() { 0, 2, 3, 9, 2, 4, 5, 7, 0, 8 }, 0);
            rotors[2] = new Rotor(new List<int>() { 5, 8, 9, 4, 9, 3, 4, 5, 6, 7 }, 0);
            rotors[3] = new Rotor(new List<int>() { 1, 5, 3, 9, 5, 5, 1, 7, 5, 9 }, 0);
            reflector = new Reflector(new List<int>() { 3, 6, 8, 0, 5, 4, 1, 9, 2, 7 });
        }

        private void TextBox_Input_TextChanged(object sender, EventArgs e)
        {
            //Creates machine object
            Rotor left = new Rotor(CheckBox_Left1.Checked ? rotors[0] : CheckBox_Left2.Checked ? rotors[1] : CheckBox_Left3.Checked ? rotors[2] : rotors[3]);
            Rotor middle = new Rotor(CheckBox_Middle1.Checked ? rotors[0] : CheckBox_Middle2.Checked ? rotors[1] : CheckBox_Middle3.Checked ? rotors[2] : rotors[3]);
            Rotor right = new Rotor(CheckBox_Right1.Checked ? rotors[0] : CheckBox_Right2.Checked ? rotors[1] : CheckBox_Right3.Checked ? rotors[2] : rotors[3]);
            Reflector reflector = new Reflector(new List<int>() { 3, 6, 8, 0, 5, 4, 1, 9, 2, 7 });
            machine = new Machine(left, int.Parse(TextBox_Left_Starting_Position.Text), middle, int.Parse(TextBox_Middle_Starting_Position.Text), right, int.Parse(TextBox_Right_Starting_Position.Text), reflector);

            //Clears and fills output textbox
            TextBox_Output.Text = "";
            foreach (char c in TextBox_Input.Text)
            {
                TextBox_Output.Text += machine.InputDigitToOutput(int.Parse(c.ToString()));
            }
        }
    }
}