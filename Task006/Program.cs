Console.Write("Введите любое число в диапазоне от 10 до 99 включительно: ");
int number = int.Parse(Console.ReadLine());
if (number<10 | number>99)
{
    Console.Write("Введите число в диапазоне!");
}
else {
        if (number/10 > number%10) Console.Write("Первая цифра больше!");
  
        if (number/10 < number%10) Console.Write("Вторая цифра больше!");
  
        if (number/10 == number%10) Console.Write("Цифры равны!");
}


