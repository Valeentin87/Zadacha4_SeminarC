// Задача 4: Напишите программу, которая на вход принимает три числа и выдает максимальное из этих трёх чисел
Console.WriteLine ("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число C");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;
if (B>A & B>C){
    max = B;
    Console.Write("максимальное число");
    Console.WriteLine(B);
}
if (C>A & C>B){
    max = C;
    Console.Write("максимальное число");
    Console.WriteLine(C);
}
if (A>B & A>C){
    max = A;
    Console.Write("максимальное число");
    Console.WriteLine(A);
}