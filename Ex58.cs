// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Метод с расширением стр
// Метод для расшиерения количества строк матрицы
int RowsCount(int[,] matrix)
{
    return matrix.GetUpperBound(0) + 1;
}
// Метод для расшиерения количества столбцов матрицы
int ColumnsCount(int[,] matrix)
{
    return matrix.GetUpperBound(0) + 1;
}


//Метод получения матрица с заданными из консоли паараметрами
static int[,] GetMatrixFromConsole(string name)
{
    Console.WriteLine("Введите количество строк матрицы: ", name);
    var row = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов матрицы: ", name);
    var col = int.Parse(Console.ReadLine());
    var matrix = new int[row, col];
    Random random = new Random();
    for (var i = 0; i < row; i++)
    {
        for (var j = 0; j < col; j++)
        {
            matrix[i, j] = random.Next(10);
        }
    }
    return matrix;
}
//Метод печати матрицы
void PrintMatrix(int[,] matrix)
{
    int col = matrix.GetLength(1);
    int row = matrix.GetLength(0);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
        //return 0;
    }
}
//
int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int col = matrixA.GetLength(1);
    int row = matrixB.GetLength(0);
    var matrixC = new int[col, row];
    for (var i = 0; i < row; i++)
    {
        for (var j = 0; j < col; j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < col; k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}
var A = GetMatrixFromConsole("A");
var B = GetMatrixFromConsole("B");
Console.WriteLine("Матрица A:");
PrintMatrix(A);
Console.WriteLine("Матрица B:");
PrintMatrix(B);
Console.WriteLine();
var result = MatrixProduct(A, B);
PrintMatrix(result);


