using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Eulers
{
    public class Project3
    {
        HashSet<long> PrimesSoFar = new HashSet<long>();
        public bool IsPrime(long number)
        {
            if(number == 1) // 1 - not a prime number
                return false;
            if (number != 2 && number % 2 == 0)
                return false;
            for (long d = 3; d * d <= number; d += 2)
            {
                if (number % d == 0)
            return false;
            }
            return true;
        }
        //public List<long>Primes(long limit)
        //{

        //}

        public List<long> factors(long number)
        {
            List<long> primes = new List<long>();
            if(number % 2 == 0)
                primes.Add(2);
            //We know 1, and 2 aren't prime so let's start at 3.
            //We know that even numbers aren't prime, so let's skip those.
            for(long i = 3; i < Math.Sqrt(number); i += 2)
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
            Project_Eulers.Project3 uut = new Project_Eulers.Project3();
            var factors = uut.factors(600851475143);
            Console.WriteLine(factors[factors.Count - 1]);
        }
    }
}
