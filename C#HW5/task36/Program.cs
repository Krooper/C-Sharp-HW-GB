using System;
using static System.Console;

Clear();

//Метод, заполняющий массив случайными числами до 100
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
    //Если индекс эелемента нечетный, добавляем элемент с этим индексом к сумме:
    int oddSum = 0;
    for (int i = 0; i < numArr.Length; i++) {
        if (i % 2 != 0) {
            oddSum+=numArr[i];
        }
    }
    WriteLine($"Сумма элементов на нечетных позициях в массиве: {oddSum}");
} else {
    WriteLine("Введенная строка не являлась числом.");
}