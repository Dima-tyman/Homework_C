Console.Clear();

int length;
Console.Write("Введите длину массива: ");
while (!int.TryParse(Console.ReadLine(), out length)) Console.Write("Ошибка ввода! Введите число: ");

int[] FillArray (int length, int min, int max) {
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
        result[i] = new Random().Next(min, max + 1);
    return result;
}

int[] ShiftArray (int[] arr, int shiftValue) {
    int[] result = new int[arr.Length];

    if (shiftValue > 0) 
        for (int i = 0; i < result.Length; i++) 
            result[i + shiftValue >= result.Length ? i + shiftValue - result.Length : i + shiftValue] = arr[i];
    else
        for (int i = 0; i < result.Length; i++) 
            result[i] = arr[i - shiftValue >= result.Length ? i - shiftValue - result.Length : i - shiftValue];
    return result;
}

int[] array = FillArray(length, 0, 9);
int shiftRigth = 1, shiftLeft = -1; // num < arr.Length
int[] leftShiftArray = ShiftArray(array, shiftRigth), rightShiftArray = ShiftArray(array, shiftLeft);

Console.WriteLine($"Ваш массив: {String.Join(", ",array)}");
Console.WriteLine($"Массив со сдвигом вправо на {shiftRigth} элементов: {String.Join(", ",leftShiftArray)}");
Console.WriteLine($"Массив со сдвигом влево на {-shiftLeft} элементов: {String.Join(", ",rightShiftArray)}");