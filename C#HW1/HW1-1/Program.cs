using System;

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

// Сделал так, тчобы обрабатывать случай, когда числа равны
// без него могло бы выглядеть лаконичнее, например, вот так:
//  Console.Write("a = "+a+"; "+"b = "+b+" -> "+"max = ");
//  if (a>b) {
//      Console.Write(a);
//  } else if (b>a) {
//      Console.Write(b);
//  }


if (a>b) {
    Console.WriteLine("a = "+a+"; "+"b = "+b+" -> "+"max = "+a);
} else if (b>a) {
    Console.WriteLine("a = "+a+"; "+"b = "+b+" -> "+"max = "+b);
} else {
    Console.WriteLine("a = "+a+"; "+"b = "+b+" -> "+"Числа равны!");
};