Console.Clear();
int num;
Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out num)) {
    Console.Write("Ошибка! Введите число: ");
}

int sumNum = num % 10;

for (int i = 10; num / i != 0; i*= 10) {
    sumNum += num / i % 10;
}

Console.Write($"Сумма всех цифр числа {num}: ");
Console.WriteLine(sumNum > 0 ? sumNum : -sumNum);