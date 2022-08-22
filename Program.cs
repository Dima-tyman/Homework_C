Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Int32.Parse(Console.ReadLine());

if (number1 == number2) {
	Console.WriteLine("Числа равны, введите два разных числа!");
}
else {
	if (number1 > number2) {
		Console.WriteLine($"Наибольшее число: {number1}");
		Console.WriteLine($"Наименьшее число: {number2}");
	}
	else {
		Console.WriteLine($"Наибольшее число: {number2}");
		Console.WriteLine($"Наименьшее число: {number1}");
	}
}