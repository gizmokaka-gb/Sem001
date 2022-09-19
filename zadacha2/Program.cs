Console.WriteLine("Введите первое число: ");
int num1 = int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse (Console.ReadLine());
 
if(num1 > num2)
{
Console.WriteLine($"Первое число ({num1}) является большим, а второе ({num2}) - меньшим.");
}
else if (num1 < num2)
{
Console.WriteLine($"Второе число ({num2}) является большим, а первое ({num1}) - меньшим.");
}
else
{
Console.WriteLine("Оба числа равны.");
}
