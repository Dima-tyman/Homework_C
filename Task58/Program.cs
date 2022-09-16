Console.Clear();

int[,] FillMatrix (int rows, int columns, int min, int max) {
	int[,] result = new int[rows, columns];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < columns; j++)
			result[i, j] = new Random().Next(min, max);
	return result;
}

void PrintMatrix (int[,] table) {
	int rows = table.GetLength(0);
	int columns = table.GetLength(1);
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++)
			Console.Write($"{table[i, j]}  ");
		Console.WriteLine();
		}
}

int[,] MultiplyMatrix (int[,] A, int[,] B) {
    int [,] C = new int[A.GetLength(0),B.GetLength(1)];
    for (int i = 0; i < C.GetLength(0); i++)
        for (int j = 0; j < C.GetLength(1); j++)
            for (int k = 0; k < A.GetLength(1); k++)
                C[i, j] += A[i, k] * B[k, j];
    return C;
}

int[,] A = FillMatrix(6, 4, 1, 8), B = FillMatrix(4, 3, 1, 8);
Console.WriteLine("Матрица A:");
PrintMatrix(A);
Console.WriteLine("Матрица B:");
PrintMatrix(B);
if (A.GetLength(1) != B.GetLength(0)) Console.WriteLine("Перемножение невозможно");
else {
    Console.WriteLine("Матрица C = A * B:");
    PrintMatrix(MultiplyMatrix(A, B));
}