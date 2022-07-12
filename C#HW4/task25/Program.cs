using System;
using static System.Console;

Clear();

// Функция для возведения в квадрат с помощью Math:
// double quad (int[] array) {
//     return Math.Pow(array[0], array[1]);
// }

// Функция для возведения в квадрат с помощью цикла:
int quad (int number, int number1) {
    int quadRes = number;
    for (int i = 1; i < number1; i++) {
        quadRes *= number;
    }
    return quadRes;
}

Write("Введите 1-е число: ");
// Парсим строку:
if(int.TryParse(ReadLine(), out int number)){
} else {
    WriteLine("Введенная строка не являлась числом.");
}
Write("Введите 2-е число: ");
// Парсим строку:
if(int.TryParse(ReadLine(), out int number1)){
} else {
    WriteLine("Введенная строка не являлась числом.");
}
WriteLine($"{number} в {number1}-й степени = {quad(number,number1)}");



// Сделал еще вариант с использованием массива (функции в этом случае должны принимать массив на вход)
// Создаем массив на 2 элемента:
// int[] array = new int [2];
// // Создаем цикл для заполнения массива из консоли:
// for (int i = 0; i < array.Length; i++) {
// // Ввод чисел:
// Write($"Введите {i+1}-е число: ");
// // Парсим строку:
// if(int.TryParse(ReadLine(), out int number)){
// // Заполняем массив 2-мя числами в цикле:
// array[i]=number;
// } else {
//     WriteLine("Введенная строка не являлась числом.");
// }
// }
// // Выводим в консоль  возвращаемое значение фукнции:
// WriteLine($"{array[0]} в {array[1]}-й степени = {quad(array)}");