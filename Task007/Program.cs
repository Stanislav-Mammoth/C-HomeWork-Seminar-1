Console.Write("Введите любое трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number<100 | number>999)
{
    Console.Write("Вы ввели не трехзначное число!");
}
else
{
    number = ((number/100)*10+(number%10));
    Console.Write("Первая и третья цифра введенного числа: ");
    Console.Write((number));
}
