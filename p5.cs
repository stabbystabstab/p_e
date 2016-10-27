using System;
using System.Collections.Generic;
/* 
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 * 
 */
class p5 
{
	static void Main() {
		
		//for each number, evenly divide it by as many factors as possible, if there is a number greater than 1 left at the end, then add it to the list of factors.
		
		List<int> factors = new List<int>();
		factors.Add(1);
		
		for(int i = 2; i <= 20; i ++) 				//for every number below and including 20
		{										
			int n = i;									//don't change 'i'
			for(int f = 0; f < factors.Count; f++)		//for every factor
			{
				if(n % factors[f] == 0)						//if divisible by the factor
				{
					n /= factors[f];							//then divide by the factor
				}
			}
			if( n > 1)									//if anything is left over
				factors.Add(n);								//then it is a factor
		}
		long total = 1;
		for(int f = 0; f < factors.Count; f++)		//find the product of all the factors
		{
			total *= factors[f];
		}
		Console.WriteLine(total);					//print result
		
	}
}