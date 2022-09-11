// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int SredneeAr(int [,] resultmassive)
{
    int SrAr = 0;
    for(int columnss = 0; columnss<5; columnss++)
    {
    
        for(int rows2 = 0; rows2<5; rows2++)
        {
        SrAr = SrAr+ resultmassive[columnss,rows2];
        }
        SrAr = SrAr/5;
        Console.Write($"{SrAr}  ");
    }

    return SrAr;
}
Console.WriteLine("-------------");
SredneeAr(resultmassive);
