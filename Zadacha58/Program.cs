/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] matrix1 = GetArray(2, 2, 0, 10);
int[,] matrix2 = GetArray(2, 2, 0, 10);
Console.WriteLine("Матрица 1:");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
PrintArray(matrix2);
Console.WriteLine("Результирующая матрица:");
int[,] newmatrix = Multiplication(matrix1,matrix2);
PrintArray(newmatrix);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{

    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }


        Console.WriteLine();
    }
}

int[,] Multiplication(int[,] A, int[,] B)
        {
            
            int[,] C = new int[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    for (int k = 0; k < B.GetLength(0); k++)
                    {
                        C[i,j] += A[i,k] * B[k,j];
                    }
                }
            }
            return C;
        }