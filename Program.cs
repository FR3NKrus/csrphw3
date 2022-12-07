// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Poly (int x){
    int cr1 = x / 10000; //первое число
    int cr2 = x / 1000 % 10; //второе число
    int cr4 = x % 100 / 10; //четвертое число
    int cr5 = x % 10; //пятое число
    if (cr1 == cr5 && cr2 == cr4) 
        Console.Write($"Число {x} являеться палиндромом!)");
    else
        Console.Write($"Число {x} НЕ являеться палиндромом!)"); 
}
Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x / 10000 < 10 && x / 10000 >= 1) 
    Poly (x); 
else Console.Write("Error! Программа работает только с 5 значными числами");

// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Dot3d(int x1, int y1, int z1, int x2, int y2, int z2){
    double dst = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
    Console.WriteLine(Math.Round(dst, 2));
}
Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Dot3d(x1, y1, z1, x2, y2, z2);

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int a){
    for (int i = 1; i <= a; i++){
        int print = Convert.ToInt32(Math.Pow(i, 3));
        Console.Write(" " + print);
    }
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Cube(a);

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125