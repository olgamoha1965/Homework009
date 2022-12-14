//Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNumbers (int n)
{
    Console.Write($"{n} ");
    if(n > 1) ShowNumbers(n - 1);
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);
*/


//Задача 66. Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*
int SumNumbersMN(int m, int n)
{
    int sum = m;
    if(n > m) return  sum += SumNumbersMN(m + 1, n);
    if(n < m) return sum += SumNumbersMN(m - 1, n);
    if(n == m) return sum;
            
return sum;
}

Console.WriteLine("Input first number: ");
int fir_num= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int sec_num= Convert.ToInt32(Console.ReadLine());
int res = SumNumbersMN(fir_num, sec_num);

Console.Write($"Sum of elements in the interval from {fir_num} to {sec_num} is {res}.");
*/

//Задача 68 (дополнительно). Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

/*
int FuncAkkerman(int m, int n)
{
    if(m == 0)
	{
		return n + 1;
	}
    if(n == 0)
    {
        return FuncAkkerman(m - 1, 1);
    }
	return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}

Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = FuncAkkerman(num1, num2);
Console.WriteLine(res);
*/

//Задача. Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

/*
int Func(int number)
{
    if(number != 0)
    {
        int res = number % 2 + Func(number / 2);
        Console.Write(res);
        return 0;
                     
    }
    else return 0;   
}
    
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine()); 
Func(num);
Console.WriteLine(" - binary system");
*/