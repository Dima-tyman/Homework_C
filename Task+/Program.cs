Console.Clear();
int lengthArray = 10;
Console.Write("Введите длину массива: ");
while (!int.TryParse(Console.ReadLine(), out lengthArray)) {
    Console.Write("Ошибка! Введите число: ");
}

void FillArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(-10, 11);
    }
}

int Max(int[] arr) {
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++) {
        max = arr[i] > max ? arr[i] : max;
    }
    return max;
}

void WriteArray(int[] arr) {
    Console.Write($"Массив: ");
     for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] array = new int[lengthArray > 0 ? lengthArray : -lengthArray];

FillArray(array);
WriteArray(array);
Console.WriteLine($"Максимально число из массива: {Max(array)}");