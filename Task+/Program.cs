Console.Clear();
Console.Write("Введите первое трёхзначное число: ");
int number1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе трёхзначное число: ");
int number2 = Int32.Parse(Console.ReadLine());
Console.Write("Введите третье трёхзначное число: ");
int number3 = Int32.Parse(Console.ReadLine());

if (number1 / 1000 != 0 || number1 / 100 == 0 || number2 / 1000 != 0 || number2 / 100 == 0 || number3 / 1000 != 0 || number3 / 100 == 0) {
    Console.WriteLine("Одна из введёных числе не является трёхзначным!");
} else {
    int aver = (number1 + number2 + number3) / 3 % 10;
    int min;

    if (number1 < number2) {
        min = number1;
    } else {
        min = number2;
    }
    if (number3 < min) {
        min = number3;
    }

    if (aver % 10 > min / 100) {
        Console.WriteLine("Последняя цифра среднего БОЛЬШЕ первой цифры минимума");
    } else if (aver % 10 < min / 100) {
        Console.WriteLine("Последняя цифра среднего МЕНЬШЕ первой цифры минимума");
    } else {
        Console.WriteLine("Последняя цифра среднего РАВНА первой цифре минимума");
    }
}