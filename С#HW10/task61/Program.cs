using System;
using static System.Console;

Clear();

int GetRows(){
    return new Random().Next(5,11);
}


int [][] PasTriangle(int n){
    int[][] triangle = new int [n][];
    triangle[0] = new int[] {1};
    for (int i = 1; i < n; i++){
        triangle[i] = new int[i+1];
        int leftNum = 0;
        for (int j = 0; j < i; j++){
            triangle [i][j] = triangle[i-1][j] + leftNum;
            leftNum = triangle[i-1][j];
        }
        triangle[i][i] = leftNum;
    }
    return triangle;
}


void ArrayPrinter(int[][] array){
    WriteLine("Получилась вот такая матрица:");
    for (int i = 0; i < array.Length; i++){
        for (int k = array.Length; k >= i; k--) {
            Write("\t");
        }
        for (int j = 0; j < array[i].Length; j++){
            Write($"{array[i][j]}\t\t");
        }
        WriteLine();
    }
    WriteLine();
}

ArrayPrinter(PasTriangle(GetRows()));