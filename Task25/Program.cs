Console.Clear();
int A, B;
Console.Write("Введите число A: ");
while (!int.TryParse(Console.ReadLine(), out A)) {
    Console.Write("Ошибка! Введите число: ");
}
Console.Write("Введите число B: ");
while (!int.TryParse(Console.ReadLine(), out B)) {
    Console.Write("Ошибка! Введите число: ");
}

double Pow = 1;
if (B == 0) Pow = 1;
for (int i = 1; i <= B; i++) {
    Pow *= A;
}
for (int i = 1; i <= -B; i++) {
    Pow /= A;
}

Console.WriteLine($"Число {A} в степени {B} = {Pow}");