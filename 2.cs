int[,] a = new int[2, 2];
for (int i = 0; i < 2; i++){
    for (int j = 0; j < 2; j++)
        a[i, j] = Convert.ToInt32(Console.ReadLine());
}
double s = 0; double k = 0;
for (int i = 0; i < 2; i++){
    for (int j = 0; j < 2; j++)
        if (a[i, j] > 0) { s = s + a[i, j]; k++; }
}
s = s / k;
Console.WriteLine("s ="+s);
