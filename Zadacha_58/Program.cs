//Задача 58: Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.

Console.Write("Введите колчество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колчество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[m, n];
int[,] secondArray = new int[m, n];
int[,] resultArray = new int[m, n];

FillArrayRandom(table);
PrintArray(table);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray(secondArray);

Console.WriteLine();

if (table.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Массивы нельзя перемножить ");
    return;
}
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < table.GetLength(1); k++)
        {
            resultArray[i, j] += table[i, k] * secondArray[k, j];
        }
    }
}

PrintArray(resultArray);



void FillArrayRandom(int[,] array) // Функция заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] array) // Функция вывода  массива на экран
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