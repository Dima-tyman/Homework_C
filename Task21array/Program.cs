string[] vectorDotName = {"X", "Y", "Z"};

void InputArray (int[] array, int count) {
    int i = 0;
    while (i < array.Length) {
        Console.Write($"Введите координаты точки {vectorDotName[i]}{count}: ");
        while (!Int32.TryParse(Console.ReadLine(), out array[i])) {
            Console.Write("Ошибка ввода! Введите число: ");
        }
        i++;
    }
}

Console.Clear();

int[] firstVector = new int[vectorDotName.Length];
int[] secondVector = new int[vectorDotName.Length];

InputArray(firstVector, 1);
InputArray(secondVector, 2);

int i = 0;
double sum = 0;
while(i < vectorDotName.Length) {
    sum = sum + Math.Pow(secondVector[i] - firstVector[i], 2);
    i++;
}
double vectorLenght = Math.Sqrt(sum);

Console.WriteLine($"Длина вектора = {vectorLenght}");