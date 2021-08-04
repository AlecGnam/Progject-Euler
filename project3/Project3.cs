using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Eulers
{
    class Project3
    {
        static void Main()
        {
            string readline;
            long BigNumber = 600851475143;
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
