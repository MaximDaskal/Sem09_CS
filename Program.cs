

//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void ShowNum(int N)
{
    Console.Write($"{N} ");
    if(N>1) ShowNum(N-1);
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNum(number);


/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int ShowSum(int N, int M)
{
    if(N<M) return ShowSum(N+1, M)+N;
    else return N;    
}

Console.Write("Input N number: ");
int numberN = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(numberN);
Console.Write("Input M number: ");
int numberM = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(numberM);

if(numberN<numberM)
{
    int res = ShowSum(numberN, numberM);
    Console.WriteLine($"Sum is: {res}");
}
else Console.WriteLine("Wrong order of numbers. \nFirst number should be less than second");

*/



/*
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AkFun(int m, int n)
{
    if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AkFun(m - 1, 1);
    else
      return AkFun(m - 1, AkFun(m, n - 1));
}

Console.Write("Input first positive number: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second positive number: ");
int numberM = Convert.ToInt32(Console.ReadLine());

if(numberN >= 0 && numberM >= 0)
{
    int result = AkFun(numberN, numberM);
    Console.WriteLine($"Result is: {result}");
}
else Console.WriteLine("Wrong numbers. \nBoth numbers should be positive or 0");
*/
