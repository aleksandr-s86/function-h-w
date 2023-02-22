//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
Console.WriteLine("Введите ваше число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень: ");
int stepen = int.Parse(Console.ReadLine()!);

int Result(int num,int stepen)
{
   int Result =1;
   for(int i = 0;i<stepen;i++)
   {
      Result *= num;
   }
return Result;
}   
Console.WriteLine($"Результат: {Result(num,stepen)}");
