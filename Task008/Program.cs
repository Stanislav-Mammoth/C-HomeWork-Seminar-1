Console.Write("Программа для проверки кратности чисел. Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Кратность какому числу нужно проверить: ");
int n = int.Parse(Console.ReadLine());

int remainder = (number%n);

if (remainder == 0)
{
    Console.Write("Это число кратно ");
    Console.Write((n));
}
else
{
    Console.Write("Это число не кратно ");
    Console.WriteLine((n));
    Console.Write("Остаток от деления: ");
    Console.Write((remainder));

}