using System;
using static System.Console;

Clear();


//Метод, заполняющий массив числами с консоли
void arrCreator (int[] array){
    for (int i = 0; i < array.Length; i++){
        Write($"Введите {i+1}-е число: ");
        if(int.TryParse(ReadLine(), out int number)){
            array[i] = number;
        } else {
            WriteLine("Введенная строка не являлась числом.");
            i-=1;
        }
        
    }
}

int largerZero (int[] array){
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
    if (array[i] > 0) {
        counter++;
    }
    }
    return counter;
}


Write("Кол-во чисел: ");
// Парсим строку:
if(int.TryParse(ReadLine(), out int number)){
    // Создаем массив введенной длины:
    int [] numArr = new int [number];
    // Вызываем функцию и выводим её результат:
    arrCreator(numArr);
    WriteLine($"Получился вот такой массив: [{string.Join(", ", numArr)}]");
    WriteLine($"Кол-во чисел больше 0: {largerZero(numArr)}");
} else {
    WriteLine("Введенная строка не являлась числом.");
}