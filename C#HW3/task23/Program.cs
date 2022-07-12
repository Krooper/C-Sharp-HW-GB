using System;
using static System.Console;

Clear();

//Создаем метод для возведения в куб чисел:
int[] cubinator (int number){

    //Создаем массив кубов чисел:
    int[] qubes = new int [Math.Abs(number)];

    //Пробегаемся по нему для заполнения (учитываем случай, когда число отрицательное):
    for (int i=1;i<=qubes.Length;i++) {
        if (number>0){
            qubes[i-1]=(int)Math.Pow(i,3); //Возводим в куб каждое число и кладем его в массив
        } else {
            qubes[i-1]=(int)Math.Pow(-i,3); //Возводим в куб каждое число и кладем его в массив
        } 
    }
    return qubes; //Возвращаем массив кубов
}

//Основная часть программы:
Write("Введите число: ");

//Парсим строку:
if(int.TryParse(ReadLine(), out int number)){
    
    // Вызываем метод и выводим кубы (последний элемент без запятой):
    for (int i=0; i<cubinator(number).Length-1; i++){
        Write($"{cubinator(number)[i]}, ");
    }
    Write($"{cubinator(number)[cubinator(number).Length-1]}");
} else {
    WriteLine("Введенная строка не являлась числом.");
}
