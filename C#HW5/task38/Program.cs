using System;
using static System.Console;

Clear();

//Метод, заполняющий массив случайными числами до 100 (чтобы не усложнять, числа будут целыми)
void randArr (int[] array){
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rnd.Next(100);
    }
}

int maxMinDiff(int[] array) {
    int minVal = array[0];
    int maxVal = array[0];
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > maxVal) {
            maxVal = array[i];
        }
        if (array[i] < minVal) {
            minVal = array[i];
        }
    }
    return maxVal-minVal;
}

Write("Введите длину массива: ");
// Парсим строку:
if(int.TryParse(ReadLine(), out int number)){
    // Создаем массив введенной длины:
    int [] numArr = new int [number];
    // Вызываем функцию и выводим её результат:
    randArr(numArr);
    WriteLine($"Получился вот такой массив: [{string.Join(", ", numArr)}]");
    WriteLine($"Разница между макс. и мин. элементами массива: {maxMinDiff(numArr)}");
} else {
    WriteLine("Введенная строка не являлась числом.");
}