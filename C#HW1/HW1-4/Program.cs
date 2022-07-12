using System;

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
System.Console.Write("n = "+n+"-> ");
for (int i=1; i<=n; i++) {
    if (i%2==0) {
    System.Console.Write(i);
    if ((i==n)||(i==(n-1))) {
        continue;
    } else {
        System.Console.Write(", ");
    }
} else {
    continue;
}
}