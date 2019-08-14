using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGUI
{
    class IntroPlot : Form1
    {

     

            private static string gameName = "Unknown Quest";
            // Create a method for the very first part

            public static void TheWakeUp()
            {
                Part1_1();

            }

            public static void Part1_1()
            {
                Part1_Script.FirstPart();
                //Part1_Script.SecondPart();
                //Part2_Script.Tavern();
                //Part3_Script.Battle();
                //Part4_Script.WrapUp();
            }


        }
    }
