string aString;
string bString;
int b = 0;
int a = 0;
Console.Write("Введите первое число");
aString = Console.ReadLine();
a = Convert.ToInt32(aString);
Console.Write("Введите второе число");
bString = Console.ReadLine();
b = Convert.ToInt32(bString);
if (a>b)
{
    Console.Write($"Наибольшее число {a}, Меньшее число {b}");
}
else if (b>a)
{
    Console.Write($"Наибольшее число {b}, Меньшее число {a}");
}	
