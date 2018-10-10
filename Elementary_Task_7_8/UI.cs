// <copyright file="UI.cs" company="My company">
//     Copyright (c) My company". All rights reserved.
// </copyright>

namespace Elementary_Task_7_8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
     
    /// <summary>
    /// Class for creating UI
    /// </summary>
    public class UI
    {
        /// <summary>
        /// Enum for count of command line args
        /// </summary>
        protected enum Sequnces
        {
            SquereSequences = 2,
            FibonaciSequences = 3
        }

        /// <summary>
        /// Working with one of 2 sequnces
        /// </summary>
        public static void WorkWithSequences()
        {
            Numeric_Sequences n = new Numeric_Sequences();
            string[] args = Environment.GetCommandLineArgs();
            switch (args.Length)
            {
                case (int)Sequnces.SquereSequences:
                    {
                        int numberForCompare;
                        if (int.TryParse(args[1], out numberForCompare))
                        {
                            foreach (int number in n.SquereSequences(numberForCompare))
                            {
                                Console.WriteLine(number);
                            }
                        }
                        else
                        {
                            WrongInstruction();
                        }

                        break;
                    }

                case (int)Sequnces.FibonaciSequences:
                    {
                        int leftBorder;
                        int rightBorder;
                        if ((int.TryParse(args[1], out leftBorder) == true) && (int.TryParse(args[2], out rightBorder) == true))
                        {
                            foreach (int number in n.FibonacciSequences(leftBorder, rightBorder))
                            {
                                Console.WriteLine(number);
                            }  
                        }
                        else
                        {
                            WrongInstruction();
                        }

                        break;
                    }

                default:
                    {
                        Instruction();
                        break;
                    }
            }
        }

        /// <summary>
        /// Instruction for user
        /// </summary>
        private static void Instruction()
        {
            Console.WriteLine("Instructions for working with the program:" + Environment.NewLine +
                "Program has 2 operating mode:" + Environment.NewLine + 
                "Finding series of natural numbers which sqare value is lower than N" + Environment.NewLine +
                "or finding fibonacci numbers at interval." + Environment.NewLine +
                "To choose first mode, enter 1 parameter" + Environment.NewLine +
                "To choose second mode, enter 2 parameter"); 
        }

        /// <summary>
        /// Instuction if sth wrong
        /// </summary>
        private static void WrongInstruction()
        {
            Console.WriteLine("You must input only natural numbers!");
        }
    }
}
