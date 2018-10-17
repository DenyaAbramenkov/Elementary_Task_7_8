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
    public abstract class Numeric_Sequences
    {
        public int LeftBorder { get; set; }
        public int RightBorder { get; set; }
        
        public Numeric_Sequences(int leftBorder, int rightBorder)
        {
            LeftBorder = leftBorder;
            RightBorder = rightBorder;
        }

        public abstract IEnumerable<int> GetSequence();

        
    }
}
