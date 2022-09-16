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

void SortTable (int[,] tab) {
    int temp;
    for (int i = 0; i < tab.GetLength(0); i++)
        for (int j = 0; j < tab.GetLength(1); j++)
            for (int k = j; k < tab.GetLength(1); k++)
                if (tab[i, k] > tab[i, j]) {
                    temp = tab[i, k];
                    tab[i, k] = tab[i, j];
                    tab[i, j] = temp;
                }
}

int[,] table = FillTable(4, 5, 0, 10);
Console.WriteLine("Начальный массив:");
PrintTable(table);
SortTable(table);
Console.WriteLine("Отсортированный массив по строкам:");
PrintTable(table);