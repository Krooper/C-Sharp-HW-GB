using System;
using static System.Console;

Clear();


int [,] arrCreator (int rows, int columns){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = new Random().Next(-10, 11);
        }
    }
    return array;
}


int GetRows(){
    return new Random().Next(3,7);
}


int GetColumns(){
    return new Random().Next(3,7);
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


minNumRowColumn MinNumFinder (int[,] array){
    int minNum = array[0,0];
    int minRow = 0, minColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (array[i,j] <= minNum){
                minNum = array[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return new minNumRowColumn {minNum = minNum, minRow = minRow, minColumn = minColumn};
}


void NewArrayPrinter (int[,] array, int minRow, int minColumn){
    WriteLine("Новая матрица:");
    for (int i = 0; i < array.GetLength(0); i++){
        if (i != minRow){
            for (int j = 0; j < array.GetLength(1); j++){
                if (j != minColumn){
                    Write("{0}\t",array[i,j]);
                }
            }
            WriteLine();
        }
    }
}


int [,] array = arrCreator(GetRows(),GetColumns());
ArrayPrinter(array);
int minNum = MinNumFinder(array).minNum;
int minRow = MinNumFinder(array).minRow;
int minColumn = MinNumFinder(array).minColumn;
WriteLine($"Минимальное число в матрице: {minNum}");
WriteLine($"Номер ряда с минимальным числом в матрице: {minRow}");
WriteLine($"Номер столбца с минимальным числом в матрице: {minColumn}");
WriteLine();
NewArrayPrinter(array, minRow, minColumn);



class minNumRowColumn{
   public int minNum {get;set;}
   public int minRow {get;set;}
   public int minColumn {get;set;}
}