Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Int32.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Int32.Parse(Console.ReadLine());

if (number1 > number2) {
	if (number1 > number3) {
		Console.WriteLine($"Наибольшее число: {number1}");
	}
	else {
		Console.WriteLine($"Наибольшее число: {number3}");
	}
}
else {
	if (number2 > number3) {
		Console.WriteLine($"Наибольшее число: {number2}");
	}
	else {
		Console.WriteLine($"Наибольшее число: {number3}");
	}
}