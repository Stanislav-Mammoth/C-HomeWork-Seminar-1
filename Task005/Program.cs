Console.Write("Введите любое трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number<100 | number>999)
{
    Console.Write("Вы ввели не трехзначное число!");
}
else
{
    Console.Write("Предпоследняя цифра введенного числа: ");
    Console.Write((number/10)%10);
}