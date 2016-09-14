using System;

class p1 {
	
	static void Main() {
		//Find the sum of all the multiples of 3 or 5 below 1000.
		
		//multiples of 3 - using triangle numbers
		int n = 1000 / 3; //floor of 1000/3 = 333;
		int sum = 3 * n * ( n + 1 ) / 2;
		
		//multiples of 5
		for(int i = 0; i < 1000; i += 5)
		{
			if(i%3 == 0)
				continue;
			else
				sum += i;
		}
		
		Console.WriteLine("Sum is " + sum);
	}
}