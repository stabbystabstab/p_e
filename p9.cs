using System;
/* 
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000, where a < b < c
 * Find the product of a, b and c
 * 
 */
class p9 
{
	static void Main() {
		
		for(int a = 1; a < 293; a++)                    //a is between 1 and 1000/(2+sqrt(2)) = 293. from geometry of right angled triangles
        {
            for(int b = 500-a; b < 500; b++)            //b is between (500-a) and 500, since a+b>500 and b<500 from geometry
            {
                int c = (int) Math.Sqrt(a*a+b*b);       //evaluate c and truncate any fractional part
                if(a*a + b*b == c*c && a+b+c == 1000)   //returns true if Math.Sqrt(a*a+b*b) was an integer and if a, b and c add to 1000
                {
                    Console.WriteLine(a + " + " + b + " + " + c + " = " + (a+b+c));     //print result
                    Console.WriteLine("a * b * c = " + (a*b*c));
                }
            }
        }
		Console.WriteLine();
	}
}