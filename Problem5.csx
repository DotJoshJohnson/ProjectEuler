/*
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 *
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 *
 * https://projecteuler.net/problem=4
 */

int minDivisor = 1, maxDivisor = 20;

for (int i = maxDivisor; true; i++)
{
    bool match = true;

    for (int j = minDivisor; j <= maxDivisor; j++)
    {
        if (i % j != 0)
        {
            match = false;

            break;
        }
    }

    if (match)
    {
        Console.WriteLine(i);

        break;
    }
}