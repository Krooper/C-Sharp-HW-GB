using System;
using static System.Console;

Clear();


double [,] arrCreator (int rows, int columns){
    double [,] array = new double[rows, columns];
    Random rnd = new Random();;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = Convert.ToDouble(rnd.Next(-100, 101)/10.0);
        }
    }
    return array;
}


int GetRows() {
    int rows = 0;
    Write($"Введите кол-во строк массива: ");
    if(int.TryParse(ReadLine(), out int number)){
        rows = number;
    } else {
        WriteLine("Введенная строка не являлась числом.");
    }
    return rows;
}


int GetColumns() {
    int columns = 0;
    Write($"Введите кол-во столбцов массива: ");
    if(int.TryParse(ReadLine(), out int number)){
        columns = number;
    } else {
        WriteLine("Введенная строка не являлась числом.");
    }
    return columns;
}


int rows = GetRows();
int columns = GetColumns();
double [,] array = arrCreator(rows,columns);
 Console.WriteLine("Получилась вот такая матрица:");
for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        Console.Write("{0}\t",array[i,j]);
    }
    Console.WriteLine();
}
