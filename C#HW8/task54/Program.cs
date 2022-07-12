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
    return new Random().Next(1,11);
}


int GetColumns(){
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


void MaxToMinSorter (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        int tmp;
        for (int k = 0; k < array.GetLength(1); k++){
            for (int j = 0; j < array.GetLength(1)-1; j++){
                if (array[i,j] < array[i,j + 1]){
                    tmp = array[i,j];
                    array[i,j] = array[i,j + 1];
                    array[i,j + 1] = tmp;
                }
            }
        }
    }
}


int [,] array = arrCreator(GetRows(),GetColumns());
ArrayPrinter(array);
MaxToMinSorter(array);
ArrayPrinter(array);