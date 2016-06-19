// File Prologue
// Name: Kyle Gray
// Project: Project 08
// Date: 6/18/2016

// I declare that the following source code was written by me, or provided
// by the instructor for this project.  I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in vaolation of 
// this policy.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project08
{
    public partial class Form1 : Form
    {
        Dice newDice;
        int dice1;
        int dice2;
        public Form1()
        {
            InitializeComponent();
        }




        // The exitToolSTripMenuItem1_Click Method
        // Pupose: exit application
        // Paramerters: none
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // The aboutToolSTripMenuItem_Click
        // Purpose: Display information about assignment
        // Parameters: none
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kyle Gray\nCS 1400\nProject #8");
        }


        // The btnRoll_Click Method
        // Purpose:  Roll new dice on click, compare them to identify snake eyes and boxcars.
        // Parameters: none
        // Returns: none
        private void btnRoll_Click(object sender, EventArgs e)
        {
            newDice = new Dice();
            newDice.NewDice(ref dice1, ref dice2);
            label1.Text = $"{newDice.Special(dice1, dice2)}";
            textBox1.Text = $"{newDice.Output(dice1)}";
            textBox2.Text = $"{newDice.Output(dice2)}";
        }
    }
}
