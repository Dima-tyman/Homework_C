Console.Clear();

int[,] FillTable (int rows, int columns, int min, int max) {
	int[,] result = new int[rows, columns];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < columns; j++)
			result[i, j] = new Random().Next(min, max);
	return result;
}

void PrintTable (int[,] table) {
	int rows = table.GetLength(0);
	int columns = table.GetLength(1);
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++)
			Console.Write($"{table[i, j]}  ");
		Console.WriteLine();
		}
}

int[,] table = FillTable(4, 5, 0, 10);
Console.WriteLine("Начальный массив:");
PrintTable(table);

int[] minValue = new int[table.GetLength(0)];
for (int i = 0; i < minValue.Length; i++)
    for (int j = 0; j < table.GetLength(1); j++)
        minValue[i] += table[i, j];

Console.WriteLine($"Строка с наименьшей суммой элементов: {Array.IndexOf(minValue, minValue.Min()) + 1}");