Console.Clear();

int x1, y1, z1, x2, y2, z2;
Console.Write("Введите x1 число: ");
while (!Int32.TryParse(Console.ReadLine(), out x1)) {
    Console.Write("Ошибка ввода! Введите число: ");
};
Console.Write("Введите y1 число: ");
while (!Int32.TryParse(Console.ReadLine(), out y1)) {
    Console.Write("Ошибка ввода! Введите число: ");
};
Console.Write("Введите z1 число: ");
while (!Int32.TryParse(Console.ReadLine(), out z1)) {
    Console.Write("Ошибка ввода! Введите число: ");
};
Console.Write("Введите x2 число: ");
while (!Int32.TryParse(Console.ReadLine(), out x2)) {
    Console.Write("Ошибка ввода! Введите число: ");
};
Console.Write("Введите y2 число: ");
while (!Int32.TryParse(Console.ReadLine(), out y2)) {
    Console.Write("Ошибка ввода! Введите число: ");
};
Console.Write("Введите z2 число: ");
while (!Int32.TryParse(Console.ReadLine(), out z2)) {
    Console.Write("Ошибка ввода! Введите число: ");
};

double vectorLenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(vectorLenght);