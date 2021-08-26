using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    public class Program
    {
        public bool IsPalidrome(int Number)
        {
            bool Palidromic = true;
            StringBuilder Test = new StringBuilder();
            int TestNumber = 0;
            foreach(var digit in Number.ToString())
            {
                Test.Append(digit);
            }
            while (Test.Length != 0)
            {
                TestNumber = Test.Length;
                TestNumber--;
                            
                if (Test[0] == Test[TestNumber])
                {
                    TestNumber--;
                    Test.Remove(0,1);
                    Test.Remove(TestNumber, 1);
                }
                else
                {
                    return false;
                }
            }
            return Palidromic;
        }
        public bool IsPrime(int number)
        {
            if (number == 1) // 1 - not a prime number
                return false;
            if (number != 2 && number % 2 == 0)
                return true;
            for (int d = 3; d * d <= number; d += 2)
            {
                if (number % d == 0)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int Number = 0;
            int multiple1 = 999;
            int multiple2 = 999;
            Number = multiple1 * multiple2;
            for (var i = 0; i < 1;)
            {
                if (!p.IsPalidrome(Number))
                {
                    Number--;
                }
                else if (Number < 100 * 100)
                {
                    i++;
                }
                else
                {
                    if (!p.IsPrime(Number))
                    {
                        Console.WriteLine(Number);
                        i++;
                    } 
                }
            }
            
            
        }
    }
}
