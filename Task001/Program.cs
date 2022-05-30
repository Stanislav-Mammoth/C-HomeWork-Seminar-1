Console.Write("Введите номер дня недели: ");
int number_day = int.Parse(Console.ReadLine());
string day = ("Понедельник");
if (number_day == 1) day = ("Понедельник");
if (number_day == 2) day = ("Вторник");
if (number_day == 3) day = ("Среда");
if (number_day == 4) day = ("Четверг");
if (number_day == 5) day = ("Пятница");
if (number_day == 6) day = ("Суббота");
if (number_day == 7) day = ("Воскресенье");
if (number_day == 0 | number_day > 7) day = ("Введите число от 1 до 7");
    
    Console.WriteLine(day);
    
 

    
