using System;
using static System.Console;

Clear();

// Функция по суммированию цифр числа:
int numSum (int number){
    int result = 0;
    // Выясняем кол-во цифр числа:
    int numLength = number.ToString().Length;
    // Создаем цикл для суммрования:
    for (int i = 0; i < numLength; i++) {
        result += number%10;
        number = number/10;
    }
    return result;
}

Write("Введите число: ");
// Парсим строку:
if(int.TryParse(ReadLine(), out int number)){
    // Вызываем функцию и выводим её результат:
    WriteLine($"Сумма цифр числа {number} = {numSum(number)}");
} else {
    WriteLine("Введенная строка не являлась числом.");
}