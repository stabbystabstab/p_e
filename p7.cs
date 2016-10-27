using System;
using System.Collections.Generic;
/* 
 * What is the 10001st prime number?
 */
class p7 
{
	static void Main() {
		
		int n = 10001;	//which prime?
		
		List<int> primes = new List<int>();		//list of prime numbers
		bool done = false;	//loop control
		int number = 3;				//counter
		
		primes.Add(2);	//the first prime.
		
		while(!done)
		{	bool isPrime = true;			//assume prime until demonstrated otherwise
			for(int p = 0; p < primes.Count; p++) 	//for every prime in our list
			{
				if(number % primes[p] == 0) 		//if number is divisible 
				{
					isPrime = false;				//not a prime
					break;							//try the next number
				}
			}
			if(isPrime) 				//if number is a prime, add it to the list
			{
				primes.Add(number);
			}
			
			number += 2;	//next number
			
			if(primes.Count == n)	//if we have enough primes
			{
				done = true;		//then we are done
			}
		}
		
		Console.WriteLine(primes[n-1]);	//print nth prime
	}
}