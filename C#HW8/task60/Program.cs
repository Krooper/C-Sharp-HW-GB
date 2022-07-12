using System;
using static System.Console;

Clear();


int [,,] arrCreator (int x, int y, int z){
    int [,,] array = new int[x, y, z];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                array[i,j,k] = new Random().Next(11);
            }
        }
    }
    return array;
}


int GetX(){
    return 2;
}


int GetY(){
    return 2;
}


int GetZ(){
    return 2;
}


void ArrayPrinter(int[,,] array){
    WriteLine("Получилась вот такая матрица:");
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                Write($"{array[i,j,k]} ({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
    WriteLine();
}



int [,,] array = arrCreator(GetX(),GetY(),GetZ());
ArrayPrinter(array);
