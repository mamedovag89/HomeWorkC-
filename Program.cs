// Task 1: Напишите программу , которая принимает на вход 3х значное число и на выходе показывает вторую цифру этого числа.
/*
int FindSecondDigit(int num)
{
   return (num % 100 / 10);
    
   
}

Console.WriteLine("Input трехзначное digit: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра трехзначного числа " + FindSecondDigit(num));


// Task 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Number(int num)
{
    if(num < 99) return -1;
    else return 0;
}

int ThirdDigit(int num)
{
    while(num > 999)
    {
        if (num >999) num = num / 10;
    }
    int result = num % 10;
     return result;
}   

int num = new Random().Next(1,100000);
int result1 = Number(num);
int result2 = ThirdDigit(num);
Console.WriteLine("Сгенерированное число " + num);

if(result1 == -1) 
Console.Write("Третьей цифры нет");
else 
Console.Write(result2);

*/

// Task 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOftheWeek(int num)
{   if ( num > 0 && num < 8)
        {
            if(num == 6 || num == 7) 
            Console.WriteLine ("Этот день недели является выходным ");
            else
            Console.WriteLine("Это будни "); 

        }
    else 
    Console.Write("Такого дня не существует ");
}
Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

DayOftheWeek(day);

