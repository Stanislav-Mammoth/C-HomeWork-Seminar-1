Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine());

int max = number_1;

if (number_2 > number_1) max = number_2;
if (number_3 > number_2) max = number_3;

Console.Write("Максимальное число: ");
Console.Write(max);