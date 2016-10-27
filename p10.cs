using System;
using System.Collections.Generic;
/* 
 * Find the sum of all the primes below two million.
 * 
 */
class p10
{
    private static List<int> primes;
    
	static void Main() {
		
        int upper = 2000000;        //upper limmit of primes
		primes = new List<int>();	//list of prime numbers
		bool done = false;	        //loop control
		int k = 1;                  //primes are all of the form 6k+/-1
        int n1, n2;
		primes.Add(2);	            //the first prime
        primes.Add(3);              //the second prime
		
		while(!done)
		{
            n1 = 6*k-1;             //prime candidates (pun)
            n2 = 6*k+1;
            
			if(isNextPrime(n1)) 		//if number is a prime, add it to the list
			{
				primes.Add(n1);
                //Console.WriteLine(n1);
			}
            
            if(isNextPrime(n2)) 		//if number is a prime, add it to the list
			{
				primes.Add(n2);
                //Console.WriteLine(n2);
			}
			
			k += 1;	                //increment k
			
			if(n2 >= upper)	//if we have enough primes
			{
				done = true;		//then we are done
			}
		}
		
		long sum = 0;
        for(int i = 0; i < primes.Count; i++)   //sum all the primes
        {
            if(primes[i] < upper)
            {
                sum += primes[i];
            }
        }
		
		Console.WriteLine(sum);
	}
    
    private static bool isNextPrime(int n)
    {
        for(int p = 1; p < primes.Count; p++) 	//for every prime in our list
        {
            if(n % primes[p] == 0) 		//if number is divisible 
            {
                return false;				//not a prime
            }
            
            if(primes[p] > Math.Sqrt(n)) //only try primes less than the square root of n
            {
                break;
            }
        }
        
        return true;                    //if it gets to here, it's the next prime
        
    }
}