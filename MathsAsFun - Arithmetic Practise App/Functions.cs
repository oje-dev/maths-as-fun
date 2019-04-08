using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsAsFun___Arithmetic_Practise_App
{
    class Functions
    {
        public int[,] TimesTableArrayFunction(int timesTable)
        {
            int[,] timesTableArray = new int[timesTable, timesTable];
            for (int i = 0; i < timesTable; i++)
            {
                timesTableArray[i, 0] = i + 1;
                timesTableArray[0, i] = i + 1;
            }
            for (int i = 0; i < timesTable; i++)
            {
                for (int j = 0; j < timesTable; j++)
                {
                    timesTableArray[i, j] = timesTableArray[i, 0] * timesTableArray[j, 0];
                    Console.Write(timesTableArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            return timesTableArray;
        }
    }
}
