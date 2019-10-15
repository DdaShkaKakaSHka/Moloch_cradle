using System;

namespace Bit_Mask_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfUnits = 0;

            Console.WriteLine("Please Enter a bit mask value");

            string maskString = Console.ReadLine();
            byte Intmask = Convert.ToByte(maskString, 2);

            Console.WriteLine("-----Testing output ----");
            numberOfUnits = GetNumberOfOnes(Intmask);
            Console.WriteLine("-----End of testing output ----");
            Console.WriteLine(" ");
            Console.WriteLine("-----Results ----");
            Console.WriteLine($"Number of units in your mask is {numberOfUnits}");
            Console.WriteLine($"Number of nulls in your mask is {8 - numberOfUnits}");
            Console.ReadLine();
        }

        private static int GetNumberOfOnes(byte mask)
        {
            int count = 0;
            for (int i = 0; i <= 8; i++)
            {
                int hexMult = 1 << i;
                int result = mask & hexMult;
                if (result == 0)
                {

                }
                else
                {
                    count++;
                }
                Console.WriteLine(result + "  hexMult " + ConvertToBin(hexMult) + "  mask " + ConvertToBin(mask));
            }
            return count;
        }

        public static string ConvertToBin(int x)
        {
            if (x == 1)
                return "1";
            else
                return ConvertToBin(x / 2) + (x % 2);
        }
    }
}