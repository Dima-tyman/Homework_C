Console.Clear();

int num1, num2;
Console.Write("Введите певое число: ");
while (!int.TryParse(Console.ReadLine(), out num1) || num1 <= 0) Console.Write("Ошибка ввода! Введите число больше нуля: ");
Console.Write("Введите второе число: ");
while (!int.TryParse(Console.ReadLine(), out num2) || num2 <= 0) Console.Write("Ошибка ввода! Введите число больше нуля: ");

int GreatestCommonDivisor (int m, int n, int maxDivisior = 0) {
    if (maxDivisior == 0) maxDivisior = Math.Min(m, n);
    if (m % maxDivisior == 0 && n % maxDivisior == 0) return maxDivisior;
    else return GreatestCommonDivisor (m, n, maxDivisior - 1);
}

if (GreatestCommonDivisor(num1, num2) != 1)
    Console.WriteLine($"Наибольший общий делитель чисел {num1} и {num2}: {GreatestCommonDivisor(num1, num2)}");
else Console.WriteLine($"У чисел {num1} и {num2} нет общего делителя кроме 1");