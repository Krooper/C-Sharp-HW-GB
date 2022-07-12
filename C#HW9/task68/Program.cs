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


int Akk(int number1, int number2){
     if (number1 == 0){
        return (number2+1);
     }else if (number1 > 0 && number2 == 0){
            return Akk(number1-1,1);
        }
    return Akk(number1-1,Akk(number1,number2-1));
}


Write("Введите число: ");
int m = NaturalChecker(NumberReader());

Write("Введите второе предыдущему: ");
int n = NaturalChecker(NumberReader());

WriteLine($"Числа: {m}, {n}.");
WriteLine($"Функция Аккермана: {Akk(m,n)}.");