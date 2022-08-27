Console.Clear();

int num;
Console.Write("Введите пятизначное число: ");
while (!Int32.TryParse(Console.ReadLine(), out num) || num > 99999 || num < 10000) {
    Console.Write("Ошибка ввода! Введите пятизначное число: ");
};

int num3 = num % 10000 / 10;

if (num / 10000 == num % 10 & num3 / 100 == num3 % 10) {
    Console.Write($"Число {num} является палиндромом.");
} else {
    Console.Write($"Число {num} НЕ является палиндромом.");
}