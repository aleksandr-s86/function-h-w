﻿ //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);
int Sumnum(int num)
{
    int res =0;
    while(num>0)
    {
        res+=num%10;
        num =num/10;
    }
    return res;
}
Console.WriteLine($"Сумма цифр в числе равна: {Sumnum(num)}");

