﻿Console.Clear();
int lengthArray;
Console.Write("Введите длину массива: ");
while (!int.TryParse(Console.ReadLine(), out lengthArray)) {
Console.Write("Ошибка! Введите число: ");
}

int[] array = new int[lengthArray > 0 ? lengthArray : -lengthArray];

void FillArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(0, 100);
    }
}

void WriteArray(int[] arr) {
    Console.Write($"Массив: ");
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
}

FillArray(array);
WriteArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным ({array.Max()}) и минимальным ({array.Min()}) значением в массиве равна: {array.Max() - array.Min()}");