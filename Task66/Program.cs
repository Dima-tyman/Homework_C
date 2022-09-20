Console.Clear();

int first, last;
Console.Write("Введите певое число: ");
while (!int.TryParse(Console.ReadLine(), out first)) Console.Write("Ошибка ввода! Введите число: ");
Console.Write("Введите второе число: ");
while (!int.TryParse(Console.ReadLine(), out last) || last <= first) Console.Write($"Ошибка ввода! Введите число больше {first}: ");

int SumEvenNum (int m, int n, int sum = 0) {
    sum += m;
    if (m < n) return SumEvenNum (m + 1, n, sum);
    else return sum;
}

Console.Write($"Сумма чисел от {first} до {last}: {SumEvenNum(first, last)}");