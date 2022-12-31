// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
bool userMode = false;

int Input(string label, int defaultvalue)
{
    if (userMode)
    {
        Console.WriteLine(label);
        return int.Parse(Console.ReadLine());
    }
    else
    {
        return defaultvalue;
    }
}

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
//Поиск минимально суммы строкиб REF ссылка на текущий индекс строки
int MinSumRow(int[,] Array, ref int indexRow)
{
    int col = Array.GetLength(1);
    int row = Array.GetLength(0);
    int SumRow = 100;
    //int indexRow = -1;
    //перебор строк

    for (int i = 0; i < row; i++)
    {
        int TecString = 0;
        //перебор столбцов (эле-ментов сторки)
        for (int j = 0; j < col; j++)
        {
            TecString += Array[i, j];

        }
        if (TecString < SumRow)
        {
            SumRow = TecString;
            indexRow = i;

        }
    }

    return SumRow;
}

int a = Input("Напишите количество строк", 5);
int b = Input("Напишите количество столбцов. Столбцов должно быть больше чем строк", 2);

int[,] A = NumberRandom(a, b);
PrintArray(A);
Console.WriteLine();

int indexRowforMaxSum = -1;
int MaxSum = MinSumRow(A, ref indexRowforMaxSum);
Console.Write($"Номер строки с минемальной суммой элементов: {indexRowforMaxSum+1} ({MaxSum})");
Console.ReadLine();