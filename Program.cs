//задача 10 - необходимо написать программу 
 //которая принимает трехзначное число и на выходе показывает 2 цифру этого числа
/*
int FindnewDigit (int number) 
 {
    int dec= number / 10;
    int newDigit = (dec % 10 );    
    return newDigit;
 }
Console.Write("введите число A");
int n1 = Convert.ToInt32(Console.ReadLine());
 int newDigit =  FindnewDigit (n1);
 Console.WriteLine ($"вторая цифра числа {n1} - {newDigit}"); */
//задача 13 - необходимо написать программу 
//которая выводит третью цифру заданного числа или сообщает что этой цифры нет
/*void Find3rdDigit (int number) 
 {
    int index = 1;
    while(number % 10 ==0) Console.Write (number % 10);
        if (index>number % 10)
        Console.Write ("Третьей цифры нет");
 }
Console.Write("введите число A");
int n3 = Convert.ToInt32(Console.ReadLine());
Find3rdDigit (n3);*/
 //задача 15 - необходимо написать программу 
//которая принимает на вход цифру, обозначающую день недели , и проверяет - является ли этот день выходным.
/*void dayoftheweek(int number) 
 {
    int d1 = number;
    if  (d1<5)
{
   Console.WriteLine ("будний");
}  
else
{
   Console.Write ("выходной");
}  
 }
Console.Write("введите число дня недели (от 1 до 7)");
int nA = Convert.ToInt32(Console.ReadLine());
dayoftheweek(nA);*/




