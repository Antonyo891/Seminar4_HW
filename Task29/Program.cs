// See https://aka.ms/new-console-template for more information
/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int[] Array_Random(int amount)
{
    int[] array = new int[amount];
    for (int i = 0; i < amount; i++) array[i] = new Random().Next(100);
    return array;
}
int Number(string n)
{
    Console.WriteLine($"Введите {n}");
    int number = int.Parse(Console.ReadLine());
    return number;
}
void print_array(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++) Console.Write($" {array[i]}");
    System.Console.WriteLine(" ]");
}
Console.Clear();
int amount = Number("количество элементов массива");
print_array(Array_Random(amount));
//System.Console.WriteLine($"[ {String.Join("  ",Array_Random(amount))} ]");
Console.WriteLine();
