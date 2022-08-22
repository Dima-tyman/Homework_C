Console.Clear();
Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
int i = 2;

if (number > 1) {
	Console.Write($"Чётные числа от 1 до {number}: ");
	while (i <= number) {
		//c проверкой каждого числа на чётность (но тут не придумал как выводить последнее число без запятой)
		/*if (i % 2 == 0) {
			Console.Write($"{i}, ");
		} else {}
		i++;*/
		
		Console.Write(i);
		if (i + 2 > number) {
			Console.Write(".");
		} else {
			Console.Write(", ");
		}
		i = i + 2;
	}
}
else {
	Console.WriteLine("Введите целое положительное число больше 1!");
}