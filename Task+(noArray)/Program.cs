//решение без разбиения на массивы
Console.Clear();
int lengthArray;
Console.Write("Введите длину массива: ");
while (!int.TryParse(Console.ReadLine(), out lengthArray)) {
Console.Write("Ошибка! Введите число: ");
}

int[] array = new int[lengthArray > 0 ? lengthArray : -lengthArray];

void FillArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(0, 10);
    }
}

void WriteArray(int[] arr) {
    Console.Write($"Массив: ");
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
}

void CheckAver(int[] arr) { 
    int iEven = 0, iNoEven = 0, sumEven = 0, sumNoEven = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] % 2 == 0) {
            sumEven += arr[i];
            iEven++;
        } else {
            sumNoEven += arr[i];
            iNoEven++;
        }
    }
    double averEven = iEven == 0 ? 0 : sumEven / iEven; //???независимо от типа данных переменной, выполняется целочисленное деление. Но зато более вероятно равенство средних значений
    double averNoEven = iNoEven == 0 ? 0 : sumNoEven / iNoEven;
    Console.WriteLine(averEven == averNoEven ? $"Средние значение массивов равны ({averEven})" :
    averEven > averNoEven ? $"Среднее значение чётного массива больше ({averEven} > {averNoEven})"
    : $"Среднее значение нечётного массива больше ({averNoEven} > {averEven})");
}

FillArray(array);
WriteArray(array);
Console.WriteLine("- входной");
CheckAver(array);