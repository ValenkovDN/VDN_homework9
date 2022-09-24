//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.



double[,] table = new double[5,5];
FillMassiv();
Console.WriteLine("Исходный массив: ");
PritMassiv();
Console.WriteLine();
Console.WriteLine("Отсортированный построчно массив: ");
SortingMassiv();
PritMassiv();



void FillMassiv() // Функция заполнения массива случайныи числами.
{
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        table[i,j] = new Random().Next(-20, 20);
    }
}
}

void PritMassiv() // Функця вывода массива на экран
{
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write($"{table[i,j]}   ");
    }
    Console.WriteLine();
}
}

void SortingMassiv() // Функция построчной сортировки массива.
{
for (int i = 0; i < table.GetLength(0); i++)
   {
      for (int j = 0; j < table.GetLength(1)-1; j++)
      {
         for (int z = 0; z < table.GetLength(1)-1; z++)
         {
            if(table[i,z] < table[i,z+1])
            {
                double temp = table[i,z];
                table[i,z] = table[i,z+1];
                table[i,z+1] = temp;
            }
         }
      }
   }
}