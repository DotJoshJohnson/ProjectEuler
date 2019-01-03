int end = 1000;
int sum = 0;

for (int i = 0; i < end; i++)
{
    if ((i % 3) == 0 || (i % 5) == 0)
    {
        sum += i;
    }
}

Console.WriteLine(sum);