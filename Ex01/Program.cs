 //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число: ");
int exponent = Convert.ToInt32(Console.ReadLine());



int count = 1;
int result = number;

while (count < exponent)
{
    result = result * number;
    count++;
}

Console.WriteLine($"{number} ^ {exponent} = {result}");

