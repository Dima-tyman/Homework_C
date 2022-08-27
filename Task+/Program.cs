Console.Clear();

int R;
Console.Write("Введите число: ");
while (!Int32.TryParse(Console.ReadLine(), out R) || R < 1) {
    Console.Write("Ошибка ввода! Введите положительное число: ");
};

int SqrtCirc = Convert.ToInt32(Math.Round(Math.Pow(R, 2) * Math.PI, 0));

int maxNum = SqrtCirc % 10;
int i = SqrtCirc / 10;

while (i != 0) {
    if (i % 10 > maxNum)
        maxNum = i % 10;
    i = i / 10;
}

Console.WriteLine($"Максимальная цифра округленной площади круга (равной = {SqrtCirc}) с радиусом {R}: {maxNum}");