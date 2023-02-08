// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Вариант 1 (только с пятизначным числом)

/*
void Palindrom(int num) // метод, проверяющий число на палиндромность
{
    int ed = num % 10; // нахождение единиц числа
    int dec = (num % 100) / 10; // нахождение десятков числа
    int ed_t = (num / 1000) % 10; // нахождение единиц тысяч
    int dec_t = num / 10000; // нахождение десятков тысяч
   
    if (ed == dec_t && dec == ed_t) // условие равенства первой и последней цифры числа, и второй и предпоследней цифры числа
    {
        Console.Write($"The number {num} is palindromic");
    }
    else Console.Write($"The number {num} is not palindromic");
}

Console.Write("Input number: "); // пользователю предлагается ввести число
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 9999 && user_number < 100000) // условие, что число должно быть пятизначным
{
    Palindrom(user_number); // вызов метода
}
else Console.Write("Impossible value!"); // метод не будет вызван, если число не пятизначное
*/

// Вариант 2 (для любого числа)
/*
void Palindrom(int num)
{
    int n = num;
    int rev = 0; // хранит обратную сторону числа
    while (n / 10 != 0)
    {
        int r = n % 10; // хранит последнюю цифру числа
        rev = rev * 10 + r;
        n = n / 10;
    }
    rev = (rev * 10) + (num % 10);
    
    if (rev == num)
    {
        Console.Write($"The number {num} is palindromic");
    }
    else Console.Write($"The number {num} is not palindromic");
}

Console.Write("Input number: "); // пользователю предлагается ввести число
int user_number = Convert.ToInt32(Console.ReadLine());

Palindrom(user_number); // вызов метода
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double DistanceAB(int xa, int ya, int za, int xb, int yb, int zb) // метод нахождения расстояния между точками А и В
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
    return distAB;
}

Console.Write("Input X coordinat of A: "); // пользователю предлагается ввести значение координаты х точки А
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinat of A: "); // пользователю предлагается ввести значение координаты y точки А
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinat of A: "); // пользователю предлагается ввести значение координаты z точки А
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinat of B: "); // пользователю предлагается ввести значение координаты х точки B
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinat of B: "); // пользователю предлагается ввести значение координаты y точки B
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinat of B: "); // пользователю предлагается ввести значение координаты z точки B
int zBcoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord); // вызов метода
Console.WriteLine($"Distance between A & B is {distanceAB:f2}"); // сообщение пользователю расстояния между точками
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cubes(int uN) // метод нахождения куба числа
{
    int current = 1; // начало метода с единицы
    while (current <= uN) // запускается цикл пока текущее значение станет равно N
    {
        int res = current * current * current; // куб числа
        Console.Write($"{res}, "); // вывод последовательности кубов
        current++; // инкремент
    }
    Console.WriteLine("\b\b "); // удаление двух последних символов "," и " "
}

Console.Write($"Input number: "); // пользователю предлагается ввести число
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number >= 1) // проверка условия на то, что число больше 1
{
    Console.Write($"{user_number} -> "); 
    Cubes(user_number); // вызов метода
}
else Console.WriteLine("Impossible value!"); // сообщение пользователю, если число не соответствует 
*/