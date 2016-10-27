using System;
/* 
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */
 
class p4 
{
	static void Main() {
		
		/*
		int test = 5;
		Console.WriteLine(test + " " + isPalindrome(test));
		test = 13;
		Console.WriteLine(test + " " + isPalindrome(test));
		test = 87995;
		Console.WriteLine(test + " " + isPalindrome(test));
		test = 112211;
		Console.WriteLine(test + " " + isPalindrome(test));
		test = 123456;
		Console.WriteLine(test + " " + isPalindrome(test));
		test = 1234321;
		Console.WriteLine(test + " " + isPalindrome(test));
		test = 123321;
		Console.WriteLine(test + " " + isPalindrome(test));
		
		Environment.Exit(0);
		*/
		
		int largest = 0; //store the largest palindrome
		
		for (int i = 999; i >= 100; i--)		//for every 3 digit number
		{
			for (int j = i; j >= 100; j--)		//and for every 3 digit number not larger than i (because they've already been tested)
			{
				if (isPalindrome(i*j))
				{
					if (i*j > largest)
					{
						largest = i*j;
						Console.WriteLine(i + " * " + j + " = " + i*j);
					}
				}
			}
		}
		
		Console.WriteLine(largest);
	}
	
	private static bool isPalindrome(int p)
	{
		int length = (int) Math.Ceiling(Math.Log10(p));
		int[] digits = new int[length];
		for(int i = 0; i < digits.Length; i++)
		{
			digits[i] = p % 10;
			p = p / 10;
		}
		
		for(int i = 0; i < length/2; i++)
		{
			if(digits[i] != digits[length-1-i])
				return false;
		}
		return true;
	}
}