/*
 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
 *
 * a^2 + b^2 = c^2
 * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
 *
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc.
 */

List<int[]> GetFactors(int product)
{
    List<int[]> allFactors = new List<int[]>();

    for (int i = 1; i < product; i++)
    {
        if (product % i == 0)
        {
            int[] factors = new int[2];

            factors[0] = i;
            factors[1] = (product / i);

            allFactors.Add(factors);
        }
    }

    return allFactors;
}

for (int r = 2; true; r += 2)
{
    int product = (int)(Math.Pow(r, 2) / 2);

    List<int[]> allFactors = GetFactors(product);

    foreach (int[] factors in allFactors)
    {
        int s = factors[0];
        int t = factors[1];

        int a = (r + s);
        int b = (r + t);
        int c = (r + s + t);

        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && (a + b + c) == 1000)
        {
            Console.WriteLine(a * b * c);

            break;
        }
    }
}