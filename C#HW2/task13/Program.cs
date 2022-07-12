using System;
using static System.Console;

Clear();

Write("Введите число: ");

if(int.TryParse(ReadLine(), out int number)){
     if ((number>=100)||(number<=-100)) {
        if (number>0){
            WriteLine($"Третья цифра числа: {((number/100)%10)}");
        } else {
            WriteLine($"Третья цифра числа: {((number/100)%10)*(-1)}");
        }
    } else {
        WriteLine("Третьей цифры нет!");
    }
} else {
    Console.WriteLine("Введенная строка не являлась числом.");
}
    