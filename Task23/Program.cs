Console.Clear();

int N;
Console.Write("Введите число: ");
while (!Int32.TryParse(Console.ReadLine(), out N)) {
    Console.Write("Ошибка ввода! Введите число: ");
};

int i = 1;

Console.Write($"Кубы чисел от 1 до {N}: ");

if (N > 0) {
    while (i <= N) {
        Console.Write(Math.Pow(i, 3));
        if (i + 1 > N) {
                Console.Write(".");
            } else {
                Console.Write(", ");
            }
        i++;
    }
} else {
    while (i >= N) {
        Console.Write(Math.Pow(i, 3));
        if (i - 1 < N) {
                Console.Write(".");
            } else {
                Console.Write(", ");
            }
        i--;
    }
}