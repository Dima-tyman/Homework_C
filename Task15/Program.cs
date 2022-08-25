Console.Clear();
Console.Write("Введите число: ");
int num = Int32.Parse(Console.ReadLine());

if (num < 1 || num > 7) {
	Console.WriteLine("Введите число от 1 до 7!");
} else if (num == 6 || num == 7) {
	Console.WriteLine("Это выходной день");
} else {
	Console.WriteLine("Это не выходной день");
}