// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.


Console.WriteLine(" Введите количество столбцов - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк -  ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] table = new double[m,n];
for(int columns = 0; columns<m; columns++)
{
    for(int rows = 0; rows<n; rows++)
    {
        table[columns, rows] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write($"{table[columns,rows]} ");
    }
    Console.WriteLine();
}
