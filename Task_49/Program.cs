// Показать двумерный массив размером m×n, заполненный вещественными числами.


Console.WriteLine("Введите размер массива m×n ");
Console.Write("m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("n: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m,n];

for (int i = 0; i<m;i++)
{
    for (int j=0; j<n; j++)
    {
        array[i,j]= new Random().Next(0, 10) + new Random().NextDouble();
        Console.Write(array[i,j] +" ");
    }
    Console.WriteLine();
}