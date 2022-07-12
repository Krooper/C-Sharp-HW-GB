using System;
using static System.Console;

Clear();

//Создаем метод для вычисления расстояния:
double distance (int[] coordA, int[] coordB) {
    double quadSum = 0;
    for (int i=0; i<coordA.Length; i++) {
        quadSum+=Math.Pow((coordB[i]-coordA[i]),2); //Возводим в квадрат разницу координат, прибавляем к сумме квадратом
    }
    return(Math.Sqrt(quadSum)); //Выясняем расстояние (берем корень из суммы квадратов разностей)
}

//Основная часть программы:

//Создаем 2 массива с координатами точек:
int [] coordA = new int [3];
int [] coordB = new int [3];

WriteLine("Введите координаты X, Y и Z точки A (после каждой координаты нажмите Enter): ");

//Парсим строки для точки A, заполняем массив с координатами точки A:
for (int i=0; i<coordA.Length;i++) {
if(int.TryParse(ReadLine(), out int num)){
    coordA[i]=num;
} else {
    WriteLine("Введенная строка не являлась числом.");
}
}

WriteLine("Введите координаты X, Y и Z точки B (после каждой координаты нажмите Enter): ");

//Парсим строки для точки B, заполняем массив с координатами точки B:
for (int i=0; i<coordA.Length;i++) {
if(int.TryParse(ReadLine(), out int num)){
    coordB[i]=num;
} else {
    WriteLine("Введенная строка не являлась числом.");
}
}

//Вызываем метод и выводим его результат, округленный до 2-го знака:
Write(Math.Round(distance(coordA,coordB),2));