using System;

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a%2==0) {
    System.Console.WriteLine("a = "+a+"-> да");
} else {
    System.Console.WriteLine("a = "+a+"-> нет");
}