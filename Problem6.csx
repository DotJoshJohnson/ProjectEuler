/*
 * The sum of the squares of the first ten natural numbers is,
 *
 * 1^2 + 2^2 + ... + 10^2 = 385
 * The square of the sum of the first ten natural numbers is,
 *
 * (1 + 2 + ... + 10)^2 = 55^2 = 3025
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
 *
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 *
 * https://projecteuler.net/problem=6
 */

int min = 1, max = 100;

int sumOfSquares = 0;
int sumOfBases = 0;

for (int i = min; i <= max; i++)
{
    sumOfSquares += (int)Math.Pow(i, 2);
    sumOfBases += i;
}

int squareOfSumOfBases = (int)Math.Pow(sumOfBases, 2);
int difference = (squareOfSumOfBases - sumOfSquares);

Console.WriteLine(difference);