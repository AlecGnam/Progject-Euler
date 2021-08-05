using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Eulers
{
    public class Project3
    {
        public bool IsPrime(int number)
        {
            if(number == 1) // 1 - not a prime number
                return false;
            for (int d = 2; d * d <= number; d++)
            {
                if (number % d == 0)
            return false;
            }
            return true;
        }

        public List<int> factors(int number)
        {
            List<int> primes = new List<int>();
            if(number % 2 == 0)
                primes.Add(2);
            //We know 1, and 2 aren't prime so let's start at 3.
            //We know that even numbers aren't prime, so let's skip those.
            for(int i = 3; i < number; i += 2)
            {
                if(IsPrime(i) && number % i == 0)
                {
                    primes.Add(i);
                }

            }
            return primes;
        }

        static void Main()
        {
            string readline;
            long BigNumber = 15;
            long answer = 0;
            int loopbreaker = 1;

            
            
            while(loopbreaker > 0)
            {
                if(BigNumber % 2 != 0)
                {
                    if (BigNumber % 3 != 0)
                    {
                        if (BigNumber % 5 != 0)
                        {
                            if (BigNumber % 7 != 0)
                            {
                                if (BigNumber % 11 != 0)
                                {
                                    answer = BigNumber;
                                    loopbreaker = 0;
                                }
                            }
                        }
                    }
                }
                BigNumber--;

            }
            Console.WriteLine(answer.ToString());

        }
        
    
    }
}
