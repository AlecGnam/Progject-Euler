using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Eulers
{
    class Project_2
    {
        static void Main()
        {
            int Number1 = 1;
            int Number2 = 2;
            int A = 0;
            int answer = 0;
            List<int> CorrectNumbers = new List<int>();
            CorrectNumbers.Add(Number1);
            CorrectNumbers.Add(Number2);

            while (A < 30)
            {
                if (Number1 > Number2)
                {
                    Number2 += Number1;
                    CorrectNumbers.Add(Number2);
                }
                else
                {
                    Number1 += Number2;
                    CorrectNumbers.Add(Number1);
                }
                A++;

            }
            foreach (var number in CorrectNumbers)
            {
               if(number % 2 == 0)
                {
                    answer += number;
                }
            }
            Console.WriteLine(answer);
            
        }
    }
}
