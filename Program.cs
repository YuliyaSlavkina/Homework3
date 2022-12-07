// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Distance(int X1, int Y1, int Z1, int X2, int Y2, int Z2 ) {
//     double number = Math.Sqrt ((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
//     Console.WriteLine("Расстояние = " + number);
// }

// Console.WriteLine("Введите координату X1: ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y1: ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z1: ");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату X2: ");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y2: ");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z2: ");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// Distance(X1, Y1, Z1, X2, Y2, Z2);

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Tabel (int number){
    for (int i = 1; i <= number; i++){
        int num = i * i * i;
        Console.Write(num + " ");
    }
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Tabel(number);