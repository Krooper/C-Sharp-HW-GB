using System;
using static System.Console;

Clear();

// Здесь сделал заполнение массива случайными числами от 1 до 100,
// но можно и по циклу заполнять с консоли, например, вот так:
// void randArr (int[] array){
//    for (int i = 0; i < array.Length; i++){
//      Write($"Введите {i}-й элемент массива: ");
//      if(int.TryParse(ReadLine(), out int number)){
//          array[i]=number;            
//        } else {
//          WriteLine("Введенная строка не являлась числом.");
//         }
//     }
// }
void randArr (int[] array){
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rnd.Next(100);
    }
}

Write("Введите длину массива: ");
// Парсим строку:
if(int.TryParse(ReadLine(), out int number)){
    // Создаем массив введенной длины:
    int [] numArr = new int [number];
    // Вызываем функцию и выводим её результат:
    randArr(numArr);
    WriteLine($"Получился вот такой массив: [{string.Join(", ", numArr)}]");
} else {
    WriteLine("Введенная строка не являлась числом.");
}