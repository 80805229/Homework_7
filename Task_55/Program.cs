// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.WriteLine("Введите размер массива m×n ");
Console.Write("m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("n: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");

    }
    Console.WriteLine();
}

for (int j = 0; j < n; j++)
{
    double sum = 0;

    for (int i = 0; i < m; i++)
    {

        sum = (sum + array[i, j]);

    }
    double sum1 = sum / m;
    Console.WriteLine("Среднее арифметическое " + (j + 1) + " столбца равно " + sum1);
}