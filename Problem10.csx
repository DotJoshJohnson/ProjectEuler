/*
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 *
 * Find the sum of all the primes below two million.
 */

int limit = 2000000;

bool IsPrime(long candidate)
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

List<long> primes = new List<long>(new long[] { 2 });

for (long i = 3; i < limit; i += 2) {
    if (IsPrime(i))
    {
        primes.Add(i);
    }
}

Console.WriteLine(primes.Sum());