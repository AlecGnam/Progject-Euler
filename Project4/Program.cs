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
                if(Test.Length == 1)
                {
                    return Palidromic;
                }
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
            int answer = 0;
            
            
            for (var Multiply1 = 999; Multiply1 >= 100; Multiply1--)
            {
               for(var Multiply2 = Multiply1; Multiply2 >= 100; Multiply2--)
                {
                  Number = Multiply1 * Multiply2;
                    if (p.IsPalidrome(Number))
                    {
                        if(Number > answer)
                        {
                            answer = Number;
                        }
                       
                    }
                }
            }
            Console.WriteLine(answer);
            
            
        }
    }
}
