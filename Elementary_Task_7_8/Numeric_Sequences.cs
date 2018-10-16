// <copyright file="Numeric_Sequences.cs" company="My company">
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
    /// Class with Numeric Sequnces
    /// </summary>
    public class Numeric_Sequences
    {
        /// <summary>
        /// Method for first task
        /// </summary>
        /// <param name="n">Number to compare with</param>
        /// <returns></returns>
        public IEnumerable<int> SquereSequences(int n)
        {
            int natural_namber = 1;
            while (Math.Pow(natural_namber, 2) < n)
            {
                yield return natural_namber;
                natural_namber++;
            }
        }

        /// <summary>
        /// Method for second task
        /// </summary>
        /// <param name="leftBorder">Left border of interval</param>
        /// <param name="rightBorder">Right border of interval</param>
        /// <returns>Enumerator</returns>
        public IEnumerable<int> FibonacciSequences(int leftBorder, int rightBorder)
        {
            int n1 = 1;
            int n2 = 1;
            if (leftBorder < rightBorder)
            {
                while (n1 <= rightBorder && leftBorder < rightBorder)
                {
                    if (n1 >= leftBorder)
                    {
                        yield return n1;
                        n1 += n2;
                        n2 += n1;
                    }
                }
            }
          
        }
    }
}
