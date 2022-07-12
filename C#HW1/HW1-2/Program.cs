using System;

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = 0;

// Здесь тоже добавил такой случай (когда хотя бы 2 числа равны), 
//чтобы не оставалось пустого вывода

Console.Write("a = "+a+"; "+"b = "+b+"; "+"c = "+c+" -> ");
if ((a>b)&&(a>c)) {
    max=a;
    Console.Write("max = "+max);
} else if ((b>a)&&(b>c)) {
    max=b;
    Console.Write("max = "+max);
} else if ((c>a)&&(c>b)) {
    max=c;
    Console.Write("max = "+max);
} else {
    Console.WriteLine("2 или более чисел равны, максимального нет!");
}