//решение через создание массива с преждевременным введением его длины, а далее заполнения

Console.Clear();

int[] InputArray () {
    Console.Write("Введите кол-во чисел, которое хотите ввести: ");
    int lenght;
    while (!int.TryParse(Console.ReadLine(), out lenght))
        Console.Write("Ошибка ввода! Введите число: ");
    lenght = lenght < 0 ? -lenght : lenght;
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++) {
        Console.Write($"Введите число {i + 1}: ");
        while (!int.TryParse(Console.ReadLine(), out result[i])) Console.Write("Ошибка ввода! Введите число: ");
    }
    return result;
}

int[] array = InputArray();

Console.WriteLine($"Ваш массив: {String.Join(", ",array)}");

int CountPositive (int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        count += arr[i] > 0 ? 1 : 0;
    return count;
}

Console.WriteLine($"Кол-во положительных элементов в вашем массиве: {CountPositive(array)}");