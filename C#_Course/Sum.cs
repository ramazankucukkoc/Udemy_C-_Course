using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Course
{
    public class Sum
    {

        //params bir defa verebilirsiniz iki defa veremeyiz
        public int Calc(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
    }
}
