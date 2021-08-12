using System;
using System.Collections.Generic;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ForwardNumber = new List<int>();
            Stack<int> ReverseNumber = new Stack<int>();
            int Number = 0;
            int a = 0;
            int multiple1 = 999;
            int multiple2 = 999;
            for (var i = 0; a < 2 || i < 1; i++)
            {
                Number = multiple1 * multiple2;
                foreach(var digit in Number.ToString())
                {
                    ReverseNumber.Push(digit);
                    ForwardNumber.Add(digit);
                }
                if (ForwardNumber.ToString() == ReverseNumber.ToString())
                {
                    i = 1;
                }
                else
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
                    ForwardNumber.Clear();
                    ReverseNumber.Clear();
                }
            }
            Console.WriteLine(Number);
            
        }
    }
}
