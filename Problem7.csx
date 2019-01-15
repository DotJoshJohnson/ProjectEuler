/*
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 *
 * What is the 10 001st prime number?
 *
 * https://projecteuler.net/problem=7
 */

int primeToFind = 10001;

bool IsPrime(int candidate)
{
    if (candidate < 2)
    {
        return false;
    }

    if ((candidate & 1) == 0)
    {
        return (candidate == 2);
    }

    for (int i = 3; (i * i) <= candidate; i += 2)
    {
        if (candidate % i == 0)
        {
            return false;
        }
    }

    return true;
}

for (int i = 2, j = 0; true; i++)
{
    if (IsPrime(i))
    {
        j++;
    }

    if (j == primeToFind)
    {
        Console.WriteLine(i);

        break;
    }
}