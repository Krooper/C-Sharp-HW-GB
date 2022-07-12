using System;
using static System.Console;

Clear();

//Метод, заполняющий массив случайными числами от 100 до 999 включительно:
void randArr (int[] array){
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rnd.Next(100, 1000);
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
    //Если элемент массива делится на 2 нацело, то прибавляем 1 к счетчику четных чисел:
    int evenCount = 0;
    for (int i = 0; i < numArr.Length; i++) {
        if (numArr[i] % 2 == 0) {
            evenCount++;
        }
    }
    WriteLine($"Кол-во четных чисел в массиве: {evenCount}");
} else {
    WriteLine("Введенная строка не являлась числом.");
}