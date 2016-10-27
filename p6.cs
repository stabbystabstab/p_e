using System;
/* 
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 * 
 */
class p6 
{
	static void Main() {
		
		int n = 100;
		
		int sum = (n*(n+1))/2;
		
		int sum_squared = sum*sum;
		
		int difference = sum_squared;
		for(int i = 1; i <= n; i++)
		{
			difference -= i*i;
		}
		
		Console.WriteLine(difference);
	}
}