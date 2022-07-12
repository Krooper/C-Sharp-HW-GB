using System;
using static System.Console;

Clear();

//Решил сделать общий случай для числа с любым количеством знаков
//И еще решил себя поразвлекать созданием методов

//Создаем метод:
bool palindrom (int number) {

//Выясняем кол-во знаков числа:
int [] numbers = new int [(int)Math.Log10(number)+1];

//Заполняем массив:
for (int i=0; i< numbers.Length; i++) {
numbers[i]=number%10;
number/=10;
}

//Обходим массив и сравниваем зеркальные по отношению к центру элементы.
//Если они равны, возращаем true, если нет - false:
for (int i=0; i!=(numbers.Length-1)/2; i++) {
 if (numbers[i]!=numbers[numbers.Length-1-i]) {
    return false;
 }
}
return true;
}

//Основная часть программы:
Write("Введите пятизначное число: ");

//Парсим строку:
if(int.TryParse(ReadLine(), out int number)){

//Если метод возвращает true, пишем "Да", если false, то "Нет":
if (palindrom(number)) {
        WriteLine("Да");
    } else {
        WriteLine("Нет");
    }
} else {
    WriteLine("Введенная строка не являлась числом.");
}

