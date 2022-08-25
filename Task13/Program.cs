Console.Clear();

Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
int i = 1;

if (number < 100 & number > -100) {
    Console.WriteLine("У числа нет третьей цифры");
} else {
    while (number % (i * 1000) != number) {
    i = i * 10;
    }
    if (number < 0) {
        Console.WriteLine((number / i % 10) * -1);
        } else {
        Console.WriteLine(number / i % 10);
        }
}