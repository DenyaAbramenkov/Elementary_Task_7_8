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
     
    public class UI_Console
    {
        public static void WorkWithSequences()
        {
            const int SquereSequences = 2;
            const int FibonaciSequences = 3;
            string[] args = Environment.GetCommandLineArgs();
            switch (args.Length)
            {
                case SquereSequences:
                    {
                        try
                        {
                            int numberForCompare = int.Parse(args[1]);
                            LessThenNSquereSequences lessThenNSquere = LessThenNSquereSequences.NSquereInitialize(numberForCompare);
                            foreach (int number in lessThenNSquere.GetSequence())
                            {
                                Console.WriteLine(number);
                            }
                        }
                        catch(Exception)
                        {
                            WrongInstructionForNSequence();
                        }
                        break;
                    }
                case FibonaciSequences:
                    {

                        try
                        {
                            int leftBorder = int.Parse(args[1]);
                            int rightBorder = int.Parse(args[2]);
                            FibonachiSequence fibonachiSequence = FibonachiSequence.FibonachiInitialize(leftBorder, rightBorder);
                            foreach (int number in fibonachiSequence.GetSequence())
                            {
                                Console.WriteLine(number);
                            }
                        }
                        catch (Exception)
                        {
                            WrongInstructionForFibSequence();
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
        private static void Instruction()
        {
            Console.WriteLine("Instructions for working with the program:" + Environment.NewLine +
                "Program has 2 operating mode:" + Environment.NewLine + 
                "Finding series of natural numbers which sqare value is lower than N" + Environment.NewLine +
                "or finding fibonacci numbers at interval." + Environment.NewLine +
                "To choose first mode, enter 1 parameter" + Environment.NewLine +
                "To choose second mode, enter 2 parameter"); 
        }
        private static void WrongInstructionForNSequence()
        {
            Console.WriteLine("You must input only natural numbers!");
        }
        private static void WrongInstructionForFibSequence()
        {
            Console.WriteLine("You must input only natural numbers AND" + Environment.NewLine +
                "LeftBorder should be less or equal to RightBorder");
        }
    }
}
