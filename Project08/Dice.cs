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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project08
{
    class Dice
    {
        
        const int MIN = 1;
        const int MAX = 6;
        Random rand = new Random();
        public Dice() {
            
        }

        // The NewDice Method
        // Purpose: This method rolls and assigns the new values for two dice.
        // Parameters: dice1 and dice2 by reference
        // Returns: values by reference
        public void NewDice(ref int dice1, ref int dice2)
        {
            dice1 = rand.Next(1, (6 + 1));
            dice2 = rand.Next(1, (6 + 1));
        }


        // The Special Method
        // Purpose: Check for snake eyes and box cars
        // Parameters: dice1 and dice2
        // Returns: string option
        public string Special (int dice1, int dice2)
        {
            string option = "";
            if (dice1 == dice2)
            {
                if (dice1 == MAX)
                {
                    option =  "Box Cars!";
                }
                else if (dice1 == MIN)
                {
                    option = "Snake Eyes!";
                }
            }
            return option;
            
        }
        
        // The Output Method
        // Purpose: returns string to display dice according to dice value
        // Parameters: int value
        // Returns: string of display characters
        public string Output(int value)
        {
            
            switch (value)
            {
                case 1:
                    return "\t\t\t    l";
                case 2:
                    return "\t   l\t\t   l";
                case 3:
                    return "\t   l\t  l\t  l";
                case 4:
                    return "\t  l  l\t\t  l  l";
                case 5:
                    return "        l  l    l     l  l";
                case 6:
                    return "\t  l  l   l  l   l  l";
                default:
                    return "";

            }
            
                             
        }
         


    }
}
