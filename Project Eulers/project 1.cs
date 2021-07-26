using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Eulers
{
    class project1
    {
        static void Main()
        {
            int BigNumber = 0;
            int SecondNumber = 0;
            int FirstNumber = 0;
            decimal DividedNumber = 0;
            var a = 0;
            int RealAnswer = 0;
            List<int> Answer = new List<int>();
            Console.WriteLine("Please input the number you would like to test in");
            BigNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the Lowest number you would like to test");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the first number you would like to divid by");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the second number you would like to divid by");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            a--;
            while(a < BigNumber)
            {
               
                if (BigNumber % FirstNumber == 0)
                {
                    Answer.Add(BigNumber);
                }
                else
                {
                   
                    if (BigNumber % SecondNumber == 0)
                    {
                        Answer.Add(BigNumber);
                    }
                }
                BigNumber--;
            }
            foreach(var number in Answer)
            {
                RealAnswer += number;
            }
            Console.WriteLine(RealAnswer);



        }
        
      
        
       


    }
}
