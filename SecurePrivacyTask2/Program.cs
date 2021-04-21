using System;

namespace SecurePrivacyTask2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string inputBinaryNumber = Console.ReadLine();
            CheckBinaryNumber(inputBinaryNumber);
        }

        public static bool CheckBinaryNumber(string binaryNumber)
        {
            string NewBinaryNumber = string.Empty;
            int Zeros = 0;
            int Ones = 0;
            foreach (char c in binaryNumber)
            {
                //Checking the digit is 0 or 1
                if (c != '0' && c != '1')
                {
                    Console.WriteLine("Not a Binary Number");
                    return false;
                }
                NewBinaryNumber += c;
                Zeros = GetNumberCount(NewBinaryNumber, '0');
                Ones = GetNumberCount(NewBinaryNumber, '1');
                if (Ones < Zeros)
                {
                    Console.WriteLine("Not a good binary string. For every prefix of the binary string, the number of 1's is not greater than number of 0's");
                    return false;
                }
            }
            if (Ones != Zeros)
            {
                Console.WriteLine("Not a good binary string. Number of O's not equal to number of 1's");
                return false;
            }
            Console.WriteLine("Its a good binary string");
            return true;
        }


        public static int GetNumberCount(string binaryNumber, char number)
        {
            int numberCount = 0;
            foreach (char c in binaryNumber)
            {
                if (c == number)
                {
                    numberCount += 1;
                }
            }
            return numberCount;
        }
    }
}
