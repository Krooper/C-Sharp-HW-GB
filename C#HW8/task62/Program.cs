using System;
using static System.Console;

// Clear();


int [,] SpiralArrCreator (int rows, int columns){
    int [,] array = new int[rows, columns];
    int i = 0, j = 0, angle = 0, circle = 0;
    int counter = 1, turnsCounter = 1;
    rows--;
    columns--;
    int x = array.GetLength(0), y = array.GetLength(1);
    while (counter <= x * y) {
        if (angle % (x / 2) == 0) {
            for (j = turnsCounter / x - angle / (x / 2); j < columns + angle / (x / 2) + turnsCounter / x - circle * (x / 2); j++){
                array[i,j + circle] = counter++;
            }
            turnsCounter++;
            for (i = turnsCounter / y; i < rows - turnsCounter/y + angle/(y / 2); i++){
                array[i,j] = counter++;
            }
            turnsCounter++;
            angle++;
            rows--;
            columns--;
        } else {
            for (j = columns + angle - turnsCounter / x; j > turnsCounter / x + angle / (x / 2); j--){
                array[i,j] = counter++;
            }
            turnsCounter++;
            for (i = rows + angle / (y / 2) + turnsCounter / y; i > turnsCounter / y; i--){
                array[i-angle/(y / 2),j] = counter++;
            }
            turnsCounter++;
            angle++;
            rows--;
            columns--;
        }
        circle = turnsCounter / 6;
    }
    return array;
}


int GetRows(){
    return 6;
}


int GetColumns(){
    return 6;
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


int [,] array = SpiralArrCreator(GetRows(),GetColumns());

ArrayPrinter(array);

