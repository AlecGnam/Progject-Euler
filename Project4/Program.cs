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
        static void Main(string[] args)
        {
            Program p = new Program();
            int Number = 0;
            int a = 0;
            int multiple1 = 999;
            int multiple2 = 999;
            for (var i = 0; a < 2 || i < 1; i++)
            {
                Number = multiple1 * multiple2;

                if (p.IsPalidrome(Number))
                {
                    if(multiple1 == 0 || multiple2 == 0)
                    {
                        multiple1 = 999;
                        multiple2 = 999;
                        a++;
                    }
                    if (a == 0)
                    {
                        multiple1--;
                    }
                    else if(a == 1)
                    {
                        multiple2--;
                    }
                    else
                    {
                        multiple2--;
                        multiple1--;
                    }
                    
                }
            }
            Console.WriteLine(Number);
            
        }
    }
}
