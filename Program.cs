//  Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// Console.WriteLine("Введите A");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите B");
// int B = Convert.ToInt32(Console.ReadLine());

// int prod = 1;

// int MathPow()
// {
//     for (int i = 0; i < B; i++)
//     {
//             prod = prod * A;
//     }
//     return prod;
// }
// Console.WriteLine("Число в степени равно: "+MathPow());





//  Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int NumberSum()
{
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.WriteLine("Сумма цифр числа равна: "+NumberSum());