using System;
using static System.Console;

Clear();


int [,] arrCreator (int rows, int columns){
    int [,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = new Random().Next(11);
        }
    }
    return array;
}


int GetRows() {
    return new Random().Next(1,11);
}


int GetColumns() {
    return new Random().Next(1,11);
}


int rows = GetRows();
int columns = GetColumns();
int [,] array = arrCreator(rows,columns);
WriteLine("Получилась вот такая матрица:");
for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        Write("{0}\t",array[i,j]);
    }
    WriteLine();
}
WriteLine();

WriteLine("Введите номера строки и столбца элемента:");
if(int.TryParse(ReadLine(), out int number1) && (int.TryParse(ReadLine(), out int number2))){
    if ((number1 <= array.GetLength(0)) && (number2 <= array.GetLength(1))){
        WriteLine($"Элемент массива в {number1}-й строке и {number2}-ом столбце = {array[number1-1,number2-1]}");
    } else {
        WriteLine("Такого числа в массиве нет.");
    }
} else {
    WriteLine("Введенная строка не являлась числом.");
}