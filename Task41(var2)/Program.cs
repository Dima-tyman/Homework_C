//решение без массива с бесконечным вводом, который останавливается пользователем

Console.Clear();

int countPositive = 0;
string inputValue = "", inputNumbers = "";

while (inputValue != "q") {
    Console.Write("(q - выход). Введите число: ");
    inputValue = Console.ReadLine();
    if (!int.TryParse(inputValue, out int num)) continue;

    Console.Write($"Число {num} добавлено! ");
    countPositive += num > 0 ? 1 : 0;
    inputNumbers += num + " ";
}

Console.WriteLine($"Введённые вами числа: {inputNumbers}");
Console.WriteLine($"Кол-во положительных чисел: {countPositive}");