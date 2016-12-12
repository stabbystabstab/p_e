using System;
using System.Collections;
using System.Threading;
/* 
 * Problem Description
 * Which starting number, under one million, produces the longest Collatz chain?
 */
class p14
{
	static void Main() {

        int[] collatz = new int[1000001];

        collatz[1] = 1;
        collatz[2] = 2;

        //create a stack
        //push the starting value onto the stack
        //push the next collatz number onto the stack
        //keep doing this until you find a number which has a 'collatz' value not equal to zero.
        //begin with the number that was found and one-by-one pop items from the top of the stack
        //and record their 'collatz numbers' in the 'collatz' array
        //once all the numbers have been populated, check which is the largest and print. 

        Stack stack = new Stack();

        for (long i = 1000000; i >= 1; i--)
        {
            if(i % 1000 == 0) Console.WriteLine(i); //sticks at 999167

            long n = (long) i;
            stack.Clear();

            //create the collatz chain
            bool done = false;
            while (!done)
            {
                //Console.Write(" " + n);
                if (n <= 1000000)
                {

                    if (collatz[n] == 0)
                    {
                        stack.Push(n);
                        n = nextCollatz(n);
                    }
                    else
                    {
                        done = true;
                        break;
                    }
                }
                else
                {
                    stack.Push(n);
                    n = nextCollatz(n);
                }
            }

            //record collatz chain into the correct positions of the collatz array
            int count = collatz[n];
            long pos;
            while (stack.Count > 0)
            {
                count++;
                pos = (long) stack.Pop();
                try
                {
                    collatz[(int) pos] = count;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            
        }

        int winner = 0;
        int max = 0;
        for ( int i = 1; i < collatz.Length; i++ )
        {
            //Console.WriteLine(collatz[i]);
            if (collatz[i] > max)
            {
                winner = i;
                max = collatz[i];
                //Console.WriteLine(max);
            }
        }
        Console.WriteLine("Winner: " + winner + " with " + max + " steps");
    }

    static long nextCollatz(long n)
    {
        
        if (n % 2 == 0)
            return (long) (n * 0.5);
        else
            return n * 3 + 1;
    }
}

