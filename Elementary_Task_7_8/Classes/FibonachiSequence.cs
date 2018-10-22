using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Task_7_8
{
    public class FibonachiSequence:Numeric_Sequences
    {
        private FibonachiSequence(int leftBorder, int rightBorder):base(leftBorder, rightBorder)
        {
            LeftBorder = leftBorder;
            RightBorder = rightBorder;
        }
        public static FibonachiSequence FibonachiInitialize(int leftBorder, int rightBorder)
        {

            if (leftBorder > 0 && rightBorder > 0)
            {
                if (leftBorder <= rightBorder)
                {
                    return new FibonachiSequence(leftBorder, rightBorder);
                }
                else
                {
                    throw new ArgumentException("LeftBorder should be less or equal to RightBorder");
                }
            }
            else throw new ArgumentException("The range should be in natural numbers");
        }

        public override IEnumerable<int> GetSequence()
        {
            int x;
            int y = 1;
            for (int i = 0; i <= RightBorder; i = x)
            {
                x = y;
                y += i;
                if (i >= LeftBorder)
                {
                    yield return i;
                }
            }

        }
    }
}
