int maxSequenceMember = 4000000;
int lastSequenceMember = 0;
int[] arr = new int[3];
int sum = 0;

arr[0] = 1;
arr[1] = 1;

for (int i = 2; lastSequenceMember <= maxSequenceMember; i++)
{
    arr[i % 3] = arr[(i - 2) % 3] + arr[(i - 1) % 3];

    lastSequenceMember = arr[i % 3];

    if ((lastSequenceMember % 2) == 0)
    {
        sum += lastSequenceMember;
    }
}

Console.WriteLine(sum);