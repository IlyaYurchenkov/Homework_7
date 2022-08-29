// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);

int sumCol = 0;
int result = 0;

for (int i = 0; i < numbers.GetLength(1); i++)
{
for (int j = 0; j < numbers.GetLength(0); j++)
{
sumCol += numbers[j, i];
}
double arifmeticMiddle = sumCol / numbers.GetLength(0);
Console.Write(
$"Среднее арифметическое столбца c индексом {i}: {Math.Round(arifmeticMiddle, 1)}\n"
);
sumCol = 0;
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
