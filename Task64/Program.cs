Console.Clear();

int first, last;
Console.Write("Введите певое число: ");
while (!int.TryParse(Console.ReadLine(), out first)) Console.Write("Ошибка ввода! Введите число: ");
Console.Write("Введите второе число: ");
while (!int.TryParse(Console.ReadLine(), out last) || last <= first) Console.Write($"Ошибка ввода! Введите число больше {first}: ");

void PrintEvenNum (int m, int n) {
    if (m % 2 == 0) Console.Write($"{m} ");
    if (m <= n) PrintEvenNum(m + 1, n); 
}

Console.Write($"Чётные числа от {first} до {last}: ");
PrintEvenNum(first, last);