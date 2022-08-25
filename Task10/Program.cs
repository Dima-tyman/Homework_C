Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = Int32.Parse(Console.ReadLine());

Console.WriteLine(number % 100 / 10);