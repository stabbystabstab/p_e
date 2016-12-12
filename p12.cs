using System;
/* 
 * Problem Description
 * What is the value of the first triangle number to have over five hundred divisors?
 */
class p12 
{
	static void Main() {
		
        //take the 1st triangle number and calculate number of factors.
        
        //...the largest number of factors that a number 'n' can have is '2 * sqrt(n)'
		//...therefore, a number with 500 factors must be at least 250^2 = 62500
        //...which rounds to the 353 rd triangle number.
        // --> start searching at the 353rd triangle number.
        
        
        int n = 352;        //start point
        int tn;
        bool done = false;
        do {
            n++;
            tn = (int) (n*(n+1)*0.5);
            if(factors(tn) >= 500) {
                done = true;
            }
        } while(!done);
        
		Console.WriteLine(n + " " + tn);
	}
    
    /*
     * Returns the number of factors of a given number.
     */
     public static int factors(int n) {
         int count = 0;
         for(int i = 1; i < Math.Sqrt(n); i++) {
             if(n%i == 0) {
                 count += 2; //factors come in pairs
             }
         }
         return count;
     }
}