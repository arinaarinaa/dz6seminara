// Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание, что 
//такого элемента нет.

int [,] CreateRandomArray()
{
    int [,] massive = new int[5,5];
    for(int columns = 0; columns<5;columns++)
    {
        for(int rows = 0; rows<5; rows++)
        {
            massive[columns,rows] = new Random().Next(0,30);
            Console.Write($"{massive[columns,rows]}  ");
        }
    Console.WriteLine();
    }
    return massive;
}
int [,] resultmassive = CreateRandomArray();

void Find(int [,] resultmassive)
{
    Console.WriteLine("Введите номер строки - ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца - ");
    int m = Convert.ToInt32(Console.ReadLine());

    if((n>resultmassive.GetLength(0)) && (m>resultmassive.GetLength(1)))
    {
        Console.WriteLine("Такого элемента нет:(");
    }
    else
    {
        Console.WriteLine($"значение элемента равно {resultmassive[n-1,m-1]}");
    }
    return ;
}
Find(resultmassive);