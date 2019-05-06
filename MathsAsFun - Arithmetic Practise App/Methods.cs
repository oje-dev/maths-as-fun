using System;

namespace MathsAsFun___Arithmetic_Practise_App
{
    class Methods
    {
        /*Enumeration is used in order to make the code more readable, each enum corresponds to a setting when generating questions. 
        The alternative would be to use integer values which would become hard to follow.*/
        public enum Operation { Addition, Subtraction, Multiplication, Division };

        public enum Magnitude { Ten, Hundred, Thousand };

        public enum PostiveOrNegative { Positive, Negative };

        public int[,] TimesTableArrayMethod(int timesTable) //This method returns a two-dimensional array of numbers which are used to create the multiplication grid.
        {
            int[,] timesTableArray = new int[timesTable, timesTable];
            for (int i = 0; i < timesTable; i++) //The first loop generates the first row and first column of numbers.
            {
                timesTableArray[i, 0] = i + 1;
                timesTableArray[0, i] = i + 1;
            }
            for (int i = 0; i < timesTable; i++) //This loop iterates through each row of the grid.
            {
                for (int j = 0; j < timesTable; j++) //This nested loop then iterates through each columm.
                {
                    timesTableArray[i, j] = timesTableArray[i, 0] * timesTableArray[j, 0]; //This line calculates the correct number to fill in each element of the array by multiplying the two corresponding numbers in the first column and row of the grid.
                }
            }
            return timesTableArray;
        }

        public int[] GetTwoNumbers(Operation operation, Magnitude magnitude, PostiveOrNegative positiveOrNegative) //This method returns a two number array which satisfy the settings set by the user.
        {
            Random random = new Random();
            int[] twoNumbers = new int[2];
            int randomPositiveOrNegative = random.Next(2); //When the user selects to include negative numbers positiveOrNegative is set to negative. A random integer is chosen between 0 and 1.
            if (randomPositiveOrNegative == 0) //If the random number is 0 then positiveOrNegative is set to positive, otherwise it stays negative, ensuring a negative number is generated only 50% of the time.
            {
                positiveOrNegative = PostiveOrNegative.Positive;
            }
            //The following statements will generate numbers based on the overall settings given by the user.
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
                            } while (twoNumbers[twoNumbers.Length - 2] == 0 || twoNumbers[twoNumbers.Length - 1] == 0); //This loop here avoids any 0s being generated with division questions as this would cause an error.
                        } while (twoNumbers[twoNumbers.Length - 2] % twoNumbers[twoNumbers.Length - 1] != 0); //This line ensures that the division question generated will produce a whole number answer. These lines are repeated whenever a division question is being generated.
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
