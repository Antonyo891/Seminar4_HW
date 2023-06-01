// See https://aka.ms/new-console-template for more information
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
int Number(string n)
{
    Console.WriteLine($"Введите число {n}");
    int number = int.Parse(Console.ReadLine());
    return number;
}
double Pow(int number1, int number2)
{ double result = number1;
for (int i =1; i<number2; i++) result = result*number1;
return result; 
}
Console.Clear();
int A = Number("A");
int B = Number("B");
while (B<=0)
{
    System.Console.WriteLine("Введите натуральное число (>0)");
    B = Number("B");
}
Console.WriteLine($"Число {A} в степени {B} = {Pow(A,B)}");