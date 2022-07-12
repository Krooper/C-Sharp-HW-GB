using System;
using static System.Console;

Clear();

Write("Введите трехзначное число: ");

if(int.TryParse(ReadLine(), out int number)){
     if (((number>=100) && (number<1000))||((number<=-100) && (number>-1000))) {
        WriteLine($"Вторая цифра числа: {((number%100)/10)}");
    } else {
        WriteLine("Число не трехначное!");
    }
} else {
    Console.WriteLine("Введенная строка не являлась числом.");
}
    