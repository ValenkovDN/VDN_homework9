// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] table = new int[5, 5];
FillMassiv();
PritMassiv();
MinSumString();





void FillMassiv() // Функция заполнения массива случайныи числами.
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(0, 10);
        }
    }
}

void PritMassiv() // Функця вывода массива на экран
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void MinSumString() // Функия вывода строки с наименьшей суммой
{
    int sumfiretline = 0;
    int minindex = 0;
    Console.Write($"Сумма каждой строки: ");
    for (int z = 0; z < table.GetLength(1); z++)
    {
        sumfiretline += table[0, z];
    }

    for (int i = 0; i < table.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum += table[i, j];
        }
        if (sumfiretline > sum)
        {
            sumfiretline = sum;
            minindex = i + 1;
        }
        Console.Write($"{sum} ");
    }
    Console.WriteLine($" ");
    Console.WriteLine($"Минмальная сумма в строке: {sumfiretline}.");
    Console.WriteLine($"Номер строки с наименьшей суммой: {minindex}.");
}