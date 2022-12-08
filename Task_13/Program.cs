// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if  (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
int digit = number.ToString()[2] - '0';
Console.WriteLine(digit);
}