using System;
using static System.Console;

Clear();

int NumberReader(){
    while (true){
        if(int.TryParse(ReadLine(), out int number)){
            return number;
        } else {
            WriteLine("Введенная строка не являлась числом.");
        }
    }  
}


int NaturalChecker(int number){
    while (number < 0) {
        Write("Число не натуральное! Введите его еще раз: ");
        number = NumberReader();
    }
    return number;
}


int NumbersChecker(int number1, int number2){
    while (number2 <= number1) {
        Write("Второе число меньше или равно первого! Введите второе число еще раз: ");
        number2 = NaturalChecker(NumberReader());
    }
    return number2;
}

int Product(int number1, int number2){
    int result = number1;
    while (result < number2){
        result *= Product(number1+1, number2);
    }
    return result;
}


Write("Введите число: ");
int m = NaturalChecker(NumberReader());

Write("Введите число больше предыдущего: ");
int n = NumbersChecker(m, NaturalChecker(NumberReader()));

WriteLine($"Числа: {m}, {n}.");
WriteLine($"Произведение в промежутке: {Product(m,n)}.");
