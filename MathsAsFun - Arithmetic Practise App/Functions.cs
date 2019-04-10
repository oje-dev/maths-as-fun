using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsAsFun___Arithmetic_Practise_App
{
    class Functions
    {
        public enum Operation { Addition, Subtraction, Multiplication, Division };

        public enum Magnitude { Ten, Hundred, Thousand };

        public enum PostiveOrNegative { Positive, Negative };

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
                }
            }
            return timesTableArray;
        }

        public int[] GetTwoNumbers(Operation operation, Magnitude magnitude, PostiveOrNegative positiveOrNegative)
        {
            Random random = new Random();
            int[] twoNumbers = new int[2];
            int randomPositiveOrNegative = random.Next(2);
            if (randomPositiveOrNegative == 0)
            {
                positiveOrNegative = PostiveOrNegative.Positive;
            }
            if (operation == Operation.Subtraction)
            {
                positiveOrNegative = PostiveOrNegative.Negative;
            }
            if (positiveOrNegative == PostiveOrNegative.Positive)
            {
                if (magnitude == Magnitude.Ten)
                {
                    if (operation != Operation.Division)
                    {
                        for (int i = 0; i < twoNumbers.Length; i++)
                        {
                            twoNumbers[i] = random.Next(11);
                        }
                    }
                    else
                    {
                        do
                        {
                            do
                            {
                                for (int i = 0; i < twoNumbers.Length; i++)
                                {
                                    twoNumbers[i] = random.Next(11);
                                }
                            } while (twoNumbers[twoNumbers.Length - 2] == 0 || twoNumbers[twoNumbers.Length - 1] == 0);
                        } while (twoNumbers[twoNumbers.Length - 2] % twoNumbers[twoNumbers.Length - 1] != 0);
                    }
                }
                else if (magnitude == Magnitude.Hundred)
                {
                    if (operation != Operation.Division)
                    {
                        for (int i = 0; i < twoNumbers.Length; i++)
                        {
                            twoNumbers[i] = random.Next(101);
                        }
                    }
                    else
                        do
                        {
                            do
                            {
                                for (int i = 0; i < twoNumbers.Length; i++)
                                {
                                    twoNumbers[i] = random.Next(101);
                                }
                            } while (twoNumbers[twoNumbers.Length - 2] == 0 || twoNumbers[twoNumbers.Length - 1] == 0);
                        } while (twoNumbers[twoNumbers.Length - 2] % twoNumbers[twoNumbers.Length - 1] != 0);
                }
                else
                {
                    if (operation != Operation.Division)
                    {
                        for (int i = 0; i < twoNumbers.Length; i++)
                        {
                            twoNumbers[i] = random.Next(1001);
                        }
                    }
                    else
                        do
                        {
                            do
                            {
                                for (int i = 0; i < twoNumbers.Length; i++)
                                {
                                    twoNumbers[i] = random.Next(1001);
                                }
                            } while (twoNumbers[twoNumbers.Length - 2] == 0 || twoNumbers[twoNumbers.Length - 1] == 0);
                        } while (twoNumbers[twoNumbers.Length - 2] % twoNumbers[twoNumbers.Length - 1] != 0);
                }
            }
            else
            {
                if (magnitude == Magnitude.Ten)
                {
                    if (operation != Operation.Division)
                    {
                        for (int i = 0; i < twoNumbers.Length; i++)
                        {
                            twoNumbers[i] = random.Next(-10, 11);
                        }
                    }
                    else
                        do
                        {
                            do
                            {
                                for (int i = 0; i < twoNumbers.Length; i++)
                                {
                                    twoNumbers[i] = random.Next(-10, 11);
                                }
                            } while (twoNumbers[twoNumbers.Length - 2] == 0 || twoNumbers[twoNumbers.Length - 1] == 0);
                        } while (twoNumbers[twoNumbers.Length - 2] % twoNumbers[twoNumbers.Length - 1] != 0);
                }
                else if (magnitude == Magnitude.Hundred)
                {
                    if (operation != Operation.Division)
                    {
                        for (int i = 0; i < twoNumbers.Length; i++)
                        {
                            twoNumbers[i] = random.Next(-100, 101);
                        }
                    }
                    else
                        do
                        {
                            do
                            {
                                for (int i = 0; i < twoNumbers.Length; i++)
                                {
                                    twoNumbers[i] = random.Next(-100, 101);
                                }
                            } while (twoNumbers[twoNumbers.Length - 2] == 0 || twoNumbers[twoNumbers.Length - 1] == 0);
                        } while (twoNumbers[twoNumbers.Length - 2] % twoNumbers[twoNumbers.Length - 1] != 0);
                }
                else
                {
                    if (operation != Operation.Division)
                    {
                        for (int i = 0; i < twoNumbers.Length; i++)
                        {
                            twoNumbers[i] = random.Next(-1000, 1001);
                        }
                    }
                    else
                        do
                        {
                            do
                            {
                                for (int i = 0; i < twoNumbers.Length; i++)
                                {
                                    twoNumbers[i] = random.Next(-1000, 1001);
                                }
                            } while (twoNumbers[twoNumbers.Length - 2] == 0 || twoNumbers[twoNumbers.Length - 1] == 0);
                        } while (twoNumbers[twoNumbers.Length - 2] % twoNumbers[twoNumbers.Length - 1] != 0);
                }
            }
            return twoNumbers;
        }
    }
}
