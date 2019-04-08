using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsAsFun___Arithmetic_Practise_App
{
    class Functions
    {
        public int[][] TimesTableArrayFunction(int timesTable)
        {
            int[][] timesTableArray = new int[timesTable][];

            for (int i = 0; i < timesTableArray.Length; i++)
            {
                for (int j = 0; j < timesTableArray.Length; j++)
                {
                    timesTableArray[i][j] = j + 1;
                }
            }

            return timesTableArray;
        }
    }
}
