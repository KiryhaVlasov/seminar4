//Задача 27: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (a>0)
    {
    result = a % 10 + result;
    a=a / 10;
    
    
}
Console.WriteLine(result);