// В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

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

Console.WriteLine("Введите число, которое требуется найти ");
int s = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i, j] == s)
        {
            Console.WriteLine("Позиции числа в массиве (" + (i + 1) + "," + (j + 1) + ")");
        }

    }
}

int count = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i, j] != s)
        {
            count++;
            if (count == m * n)
            {
                Console.WriteLine("Такого числа нет в массиве");
            }

        }

    }
}
