/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
 */

long input = 600851475143;

long quotient = input;
long counter = 2;
long largestFactor = 0;

while (counter * counter <= quotient)
{
    if (quotient % counter == 0)
    {
        quotient = quotient / counter;
        largestFactor = counter;
    }

    else
    {
        counter++;
    }
}

if (quotient > largestFactor)
{
    largestFactor = quotient;
}

Console.WriteLine(largestFactor);