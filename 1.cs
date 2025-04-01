char[,] a = new char[2, 2];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
        a[i, j] = '*';
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
        Console.Write("{0}  ", a[i, j]);
    Console.WriteLine();
}