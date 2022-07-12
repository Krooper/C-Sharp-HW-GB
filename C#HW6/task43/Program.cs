using System;
using static System.Console;

Clear();

double [] inters (line one, line two){
	double x = - (one.b - two.b)/(one.k-two.k);
	double y = 5 * x + 2;
    double [] point = new double [2];
    point[0] = x;
    point[1] = y;
	return point;
}
 
WriteLine("Введите коэффициенты первой прямой");
double [] koeffoneArr = new double [2];
for (int i = 0; i < 2; i++){
    Write($"Введите {i+1}-й коэффициент первой прямой: ");
    if(double.TryParse(ReadLine(), out double koeff)){
        koeffoneArr[i] = koeff;
    } else {
        WriteLine("Введенная строка не являлась числом.");
        i--;
    }
    
}
WriteLine();
WriteLine($"Коэффициенты первой прямой: [{string.Join(", ", koeffoneArr)}]");
WriteLine();


WriteLine("Введите коэффициенты второй прямой");
double [] koefftwoArr = new double [2];
for (int i = 0; i < 2; i++){
    Write($"Введите {i+1}-й коэффициент второй прямой: ");
    if(double.TryParse(ReadLine(), out double koeff)){
        koefftwoArr[i] = koeff;
    } else {
        WriteLine("Введенная строка не являлась числом.");
        i--;
    }
}

WriteLine();
WriteLine($"Коэффициенты первой прямой: [{string.Join(", ", koefftwoArr)}]");
WriteLine();

line one = new line(koeffoneArr[0], koeffoneArr[1]);
line two = new line(koefftwoArr[0], koefftwoArr[1]);
WriteLine($"Точка пересечения прямых имеет координаты: ({inters (one, two)[0]}, {inters (one, two)[1]})");
    

struct line {
	public double k, b;
        public line (double k =1 , double b = 1)
    {
        this.k = k;
        this.b = b;
    }
};


 


 
