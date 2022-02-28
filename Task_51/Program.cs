// Задать двумерный массив следующим правилом: Aₘₙ = m+n.

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

        array[i, j] = (i+1)+(j+1);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}