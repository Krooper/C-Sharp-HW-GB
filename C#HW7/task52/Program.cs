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


void ArrayPrinter(int[,] array){
    WriteLine("Получилась вот такая матрица:");
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Write("{0}\t",array[i,j]);
        }
        WriteLine();
    }
    WriteLine();
}


void Average (int [,] array){
    double avrg = 0.0;
    for (int column = 0; column < array.GetLength(1); column++){
        int sum = 0;
        for (int row = 0; row < array.GetLength(0); row++){
            sum += array[row,column];
        }
        avrg = Convert.ToDouble(sum)/(array.GetLength(0));
        WriteLine($"Среднее арифметическое {column+1}-го столбца = {Math.Round(avrg, 1)}.");
    }
}


int [,] array = arrCreator(GetRows(),GetColumns());
ArrayPrinter(array);
Average(array);