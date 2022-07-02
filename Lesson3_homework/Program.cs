/*  Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

string number = "46553";
Zadacha19(number);
string number2 = "42342";
Zadacha19(number2);
string number3 = "12321";
Zadacha19(number3);
Console.WriteLine();
Console.WriteLine();
void Zadacha19(string currentNumber)
{
    Console.WriteLine("___________");
    Console.WriteLine("Задача 19");
    if (currentNumber[0] == currentNumber[4] && currentNumber[1] == currentNumber[3])
    {
        Console.WriteLine($"Число {currentNumber} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {currentNumber} не является палиндромом");
    }
}


/* Задача 21.  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Random rand = new Random();
int x1 = rand.Next(0, 10);
int y1 = rand.Next(0, 10);
int z1 = rand.Next(0, 10);

int x2 = rand.Next(0, 10);
int y2 = rand.Next(0, 10);
int z2 = rand.Next(0, 10);

Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
*/

/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("___________");
Console.WriteLine("Задача 23");
Random rand = new Random();
int N = rand.Next(1, 10);
int counter = 1;
while (counter <= N)
{
    Console.WriteLine($"{counter} -> {Math.Pow(counter, 3)}");
    counter++;
}
*/