using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 799999
            string input = "11000011010011111111";

            Console.WriteLine(GetNumberOfOperationsByCountingBits(input));
            Console.WriteLine(GetNumberOfOperations(799999));
            Console.ReadLine();
        }

        public static int GetNumberOfOperationsByCountingBits(string number)
        {
            int result = 0;

            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1')
                    result = result + 2;
                else
                    result = result + 1;
            }

            return result - 1;
        }

        public static int GetNumberOfOperations(int number)
        {
            int result = 0;

            while (number > 0)
            {
                result++;

                if(number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = number - 1;
                }
            }

            return result;
        }

        public static int ConvertBinaryToInt(string binaryNumber)
        {
            char[] binaryNumbers = binaryNumber.ToCharArray();
            Array.Reverse(binaryNumbers);

            int sum = 0;
            
            for(int i = 0; i < binaryNumbers.Length; i++)
            {
                if (binaryNumbers[i] == '1')
                {
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }
            }

            return sum;
        }
    }
}