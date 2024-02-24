using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace посл
{
    internal class Program
    {
        static void Main(string[] args)
        { // for т.к. задать параметры работы цикла

            int minValue = 5, maxValue = 103, numberStep = 7;

            for (int i = minValue; i <= maxValue; i+=numberStep)
            {
                Console.WriteLine(i);
            }
        }
    }
}
