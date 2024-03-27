// Напишите программу, которая на вход принимает 2 целых числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"Квадрат числа {number2} равен {number1}");
}
else Console.WriteLine("Квадрат числа {0} НЕ равен {1}", number2, number1);

// Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int notN = -N;

while (notN <= N)
{
    Console.Write($"{notN} ");
    notN++; // То же самое, что и notN = notN + 1
}

//Напишите программу, которая принимает на вход трёхзначное число, а на выходе показывает сумму первой и последней цифры этого числа.


Console.Write("Введите трехзначное число: ");
string n = Console.ReadLine()!;

if (n.Length != 3){
    Console.Write("это не трехзначное число...");
}
else{
    Console.WriteLine(Convert.ToInt32(Convert.ToString(n[0])) 
    + Convert.ToInt32(Convert.ToString(n[2]))); //To.Int32 преобразует в целое число, а string преобразовывает в строку
}