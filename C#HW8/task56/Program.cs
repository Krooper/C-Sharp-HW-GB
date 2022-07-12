using System;
using static System.Console;

Clear();


int [,] arrCreator (int rows, int columns){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = new Random().Next(11);
        }
    }
    return array;
}


int GetRows(){
    return new Random().Next(1,7);
}


int GetColumns(){
    return new Random().Next(1,7);
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


void MinSumFinder (int[,] array){
    int [] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){  
        for (int j = 0; j < array.GetLength(1); j++){
            sumArray[i] += array[i,j];
        }
    }

    int rowNum = 0;
    int min = sumArray[0];
    for (int i = 1; i < sumArray.Length; i++){
        if (min > sumArray[i]){
            rowNum = i;
        }
    }
    WriteLine($"{rowNum+1}-я строка");
}


int [,] array = arrCreator(GetRows(),GetColumns());
ArrayPrinter(array);
MinSumFinder(array);