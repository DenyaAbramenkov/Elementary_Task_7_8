using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Task_7_8
{
    public class LessThenNSquereSequences:Numeric_Sequences
    {
        private LessThenNSquereSequences(int leftBorder, int rightBorder) : base(leftBorder, rightBorder)
        {
        }
        public static LessThenNSquereSequences NSquereInitialize(int rightBorder)
        {

            if (rightBorder > 1)
            {        
                    return new LessThenNSquereSequences(1, rightBorder);
            }
            else throw new ArgumentException("N shold be > 1");
        }

        public override IEnumerable<int> GetSequence()
        {
            int natural_namber = 1;
            while (Math.Pow(natural_namber, 2) < RightBorder)
            {
                yield return natural_namber;
                natural_namber++;
            }
        }

    
    }
}
