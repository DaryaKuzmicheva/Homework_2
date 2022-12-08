/* Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли 
этот день выходным. */
int weekday;
Console.WriteLine("Введите день недели");
weekday = Convert.ToInt32(Console.ReadLine());
if (weekday > 7 || weekday == 0)    
      Console.WriteLine("Нет такого дня недели");
else
{
  if (weekday < 6)
    {
        Console.WriteLine("Рабочий");
    }
    else
    {
        Console.WriteLine("Выходной");
    }
}    

