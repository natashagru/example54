//Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
	int[,] result = new int[m, n];
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
		{
		result[i, j] = new Random() .Next(minValue, maxValue+1);
		}
	return result;
}

void PrintArray(int[,] inArray)
{
	for (int i = 0; i < inArray.GetLength(0); i++)
	{
		for (int j = 0; j < inArray.GetLength(1); j++)
		{
			Console.Write($"{inArray[i, j]}\t ");
		}
		Console.WriteLine();
	}
}
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1]) 
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
