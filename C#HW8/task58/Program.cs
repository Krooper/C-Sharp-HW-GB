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
    return 3;
}


int GetColumns(){
    return 3;
}


void ArrayPrinter(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Write("{0}\t",array[i,j]);
        }
        WriteLine();
    }
    WriteLine();
}


void MatrixMultiplicator(int[,] array1, int[,] array2){
    if (array1.GetLength(1) == array2.GetLength(0)){
        int[,] multArray = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); ++i){
            for (int j = 0; j < array2.GetLength(0); ++j){
                for (int k = 0; k < array2.GetLength(1); ++k){
                    multArray[i, k] += array1[i, j] * array2[j, k];
                }
            }
        }         
        ArrayPrinter(multArray);
    } else {
        WriteLine("Матрицы нельзя перемножить!");
    }
}


int [,] array1 = arrCreator(GetRows(),GetColumns());
int [,] array2 = arrCreator(GetRows(),GetColumns());
WriteLine("Первая матрица:");
ArrayPrinter(array1);
WriteLine("Вторая матрица:");
ArrayPrinter(array2);
WriteLine("Результат перемножения матриц:");
MatrixMultiplicator(array1,array2);
