Console.Clear();

string[] vectorDotName = {"X", "Y", "Z"};
int[] firstVector = new int[vectorDotName.Length];
int[] secondVector = new int[vectorDotName.Length];

int i = 0;
while (i < firstVector.Length) {
    Console.Write($"Введите координаты точки {vectorDotName[i]}1: ");
    while (!Int32.TryParse(Console.ReadLine(), out firstVector[i])) {
        Console.Write("Ошибка ввода! Введите число: ");
    }
    i++;
}
i = 0;
while (i < secondVector.Length) {
    Console.Write($"Введите координаты точки {vectorDotName[i]}2: ");
    while (!Int32.TryParse(Console.ReadLine(), out secondVector[i])) {
        Console.Write("Ошибка ввода! Введите число: ");
    }
    i++;
}
i = 0;

double sum = 0;
while(i < vectorDotName.Length) {
    sum = sum + Math.Pow(secondVector[i] - firstVector[i], 2);
    i++;
}
double vectorLenght = Math.Sqrt(sum);

Console.WriteLine($"Длина вектора = {vectorLenght}");