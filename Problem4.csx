/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 *
 * Find the largest palindrome made from the product of two 3-digit numbers.
 *
 * https://projecteuler.net/problem=4
 */

int a = 999, b = 999;
int minFactor = 100;

int maxPalindrome = 0;

bool IsPalindromic(int n)
{
    char[] chars = n.ToString().ToCharArray();

    for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
    {
        if (chars[i] != chars[j])
        {
            return false;
        }
    }

    return true;
}

while (b >= minFactor)
{
    int product = (a * b);

    if (IsPalindromic(product) && product > maxPalindrome)
    {
        maxPalindrome = product;
    }

    if (a == minFactor)
    {
        b--;

        a = b;
    }

    else
    {
        a--;
    }
}

Console.WriteLine(maxPalindrome);