using System;
using System.Collections.Generic;
/* 
 * What is the largest prime factor of the number 600851475143 ?
 */
class p3
{
	static void Main() 
	{
		long n = 600851475143; 						//number to find largest prime factor of. Too large for a 32-bit integer
		
		for(long i = 2; i < Math.Sqrt((double) n); i++) //find next factor
		{
			while(n%i == 0)  //while 'i' is a factor
			{
				n /= i; //keep dividing by the factor until it can't be divided anymore
			}
		}
		Console.WriteLine(n); ///whatever is left over is the largest prime factor
	}
}