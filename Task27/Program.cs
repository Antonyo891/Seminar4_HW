// See https://aka.ms/new-console-template for more information
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int Number()
{
    Console.WriteLine($"Введите число");
    int number = int.Parse(Console.ReadLine());
    return number;
    }
int Pow(int number1, int number2)
{ int result = 1;
for (int i =0; i<number2; i++) result = result*number1;
return result; 
}
int sum(int Number)
    {
        int count = 1, div = 10, sum=0;
        while (Number/div>0||Number/div<0) 
        {count = count + 1;
        div=div*10;
        }
        for (int i = 1; i<=count; i++){
             sum = sum + Number%Pow(10,i)/Pow(10,i-1);
             //System.Console.WriteLine(Number%Pow(10,i)/Pow(10,i-1));
             }
             if (sum<0) sum = -sum;
        return sum;
    }
Console.Clear();
int number = Number();
Console.WriteLine($"Сумма цифр в числе {number} = {sum(number)}");
