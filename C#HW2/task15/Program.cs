using System;
using static System.Console;

Clear();

Write("Введите число в диапазоне от 1 до 7: ");

if(int.TryParse(ReadLine(), out int number)){
     if ((number>=1)&&(number<=7)) {
        if (number>5){
            WriteLine("День выходной");
        } else {
            WriteLine("День не выходной");
        }
    } else {
        WriteLine("Число не в диапазоне!");
    }
} else {
    Console.WriteLine("Введенная строка не являлась числом.");
}