// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
///summary
/// Заполнили двухмерный массив рандомными числами от а до б
///summary
int[,] NumberRandom(int a, int b)
{
    int[,] Array = new int[a, b];
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Array[i, j] = random.Next(10);
        }
    }
    return Array;
}
///summary
///Упорядочивание элементов в строках по убыванию в двухмерном массиве
///summary
int[,] DescendiNumber(int[,] Array)
{

    int col = Array.GetLength(1);
    int row = Array.GetLength(0);

    //перебор строк
    for (int i = 0; i < row; i++)
    {
        for (int r = 0; r < col - 1; r++)
        {
            //перебор столбцов (эле-ментов сторки)
            for (int j = 0; j < col - 1; j++)
            {
                if (Array[i, j] < Array[i, j + 1])
                {
                    int number;
                    number = Array[i, j];
                    Array[i, j] = Array[i, j + 1];
                    Array[i, j + 1] = number;
                }
            }
        }
    }
    return Array;
}
///symmary
///Печать двухмерного массива
///summary
void PrintArray(int[,] Array)
{
    int col = Array.GetLength(1);
    int row = Array.GetLength(0);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
        //return 0;
    }
}
//NumberRandom(5, 10);
//Console.WriteLine();
//Console.WriteLine();
int[,] A = NumberRandom(5, 10);
PrintArray(A);

Console.WriteLine();

int[,] D = DescendiNumber(A);
PrintArray(D);
// Console.WriteLine(NumberRandom(1,4));
//void Descendingnumber (char [,] Array= new char [1,5])
