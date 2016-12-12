using System;
/* 
 * Problem Description
 * Starting in the top left corner and only being able to move to the right and down,
 * how many such routes are there through a 20×20 grid?
 */
class p15
{
    static void Main()
    {
        //it's just pascals' triangle
        int size = 20;
        long[,] steps = new long[size + 1, size + 1];

        steps[0, 0] = 0;
        for (int i = 1; i <= size; i++)
        {
            steps[0, i] = 1;
            steps[i, 0] = 1;
        }

        for (int i = 1; i <= size; i++)
        {
            for (int j = i; j <= size; j++)
            {
                steps[i, j] = steps[i - 1, j] + steps[i, j - 1];
                steps[j, i] = steps[i, j];
            }
        }

        Console.WriteLine(steps[size, size]);
    }
}