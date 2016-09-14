using System;

class p2 
{
	/* 
	 * By considering the terms in the Fibonacci sequence 
	 * whose values do not exceed four million, 
	 * find the sum of the even-valued terms.
	 */
	static void Main() {
		int previous_1 = 0;
		int previous_2 = 1;
		int new_number;
		int sum = 0;
		 
		while(previous_1 + previous_2 < 4e6) //while we still have fibonnaci numbers below 4 million.
		{
			new_number = previous_1 + previous_2; //find next fibonnaci number;
			if(new_number % 2 == 0)
				sum += new_number; //if the fibonnaci number is even, add it to the sum.
			previous_1 = previous_2; //get ready to find the next fibonnaci number
			previous_2 = new_number;
		}
		Console.WriteLine("Sum: " + sum);
	}
}