using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eargkyseurghtr
{
    internal class Min_Max
    {
        public int MinNumber(List<int> numbers)
        {
            int min = numbers[0];

            for(int i = 0; i< numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public int MaxNumber(List<int> numbers)
        {
            int max = numbers[0];

            for(int i=0; i<numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max= numbers[i];
                }
            }

            return max;
        }
    }
}
