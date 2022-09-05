Console.Clear();
int lengthArray;
Console.Write("Введите длину массива: ");
while (!int.TryParse(Console.ReadLine(), out lengthArray)) {
Console.Write("Ошибка! Введите число: ");
}

int[] array = new int[lengthArray > 0 ? lengthArray : -lengthArray];
int[] arrayEvenInt = new int[array.Length];
int[] arrayNotEvenInt = new int[array.Length];

void FillArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(1, 10);
    }
}

void WriteArray(int[] arr) {
    Console.Write($"Массив: ");
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == 0) {break;} else {
            Console.Write($"{arr[i]} ");
        }
    }
}

void SplitArrayByEvenInt(int[] arr, int[] arrEven, int[] arrNoEven) {
    int iEven = 0, iNoEven = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] % 2 == 0) {
            arrEven[iEven] = arr[i]; //???чтобы избавиться от нулей пытался создавать безразмерный массив через arrEven.Add, но неполучилось.
            iEven++;                 //Из-за этого массив можно заполнить только положительными числами
        } else {
            arrNoEven[iNoEven] = arr[i];
            iNoEven++;
        }
    }
}

double AverArr (int[] arr) {
    int sum = 0, count = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == 0) break;
        sum += arr[i];
        count++;
    }
    double aver = count == 0 ? 0 : sum / count; //???независимо от типа данных переменной, выполняется целочисленное деление. Но зато более вероятно равенство средних значений
    return aver;
}

FillArray(array);
WriteArray(array);
Console.WriteLine("- входной");
SplitArrayByEvenInt(array, arrayEvenInt, arrayNotEvenInt);

WriteArray(arrayEvenInt);
Console.WriteLine("- чётные");
WriteArray(arrayNotEvenInt);
Console.WriteLine("- нечётные");

Console.WriteLine(AverArr(arrayEvenInt) == AverArr(arrayNotEvenInt) ? $"Средние значение массивов равны ({AverArr(arrayEvenInt)})" :
AverArr(arrayEvenInt) > AverArr(arrayNotEvenInt) ? $"Среднее значение чётного массива больше ({AverArr(arrayEvenInt)} > {AverArr(arrayNotEvenInt)})"
: $"Среднее значение нечётного массива больше ({AverArr(arrayNotEvenInt)} > {AverArr(arrayEvenInt)})");