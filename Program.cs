/*

// Минимальное и максимальное число из 2х

Console.WriteLine("input a first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

Console.WriteLine($"Min: {num1}");
Console.Write($"Max: {num2}");
*/



/* 

// Максимальное число из 3х

int Maximum(int first, int second, int third)
{
    int result = first;

    if(result < second)
    {
    result = second;
    }
    
    if(result < third)
    {
    result = third;
    }

    return result;
}

Console.WriteLine("input a first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a third number ");
int num3 = Convert.ToInt32(Console.ReadLine());

int res = Maximum(num1, num2, num3);
Console.Write($"Biggest number is {res}");
*/

/*
// Проверка числа на чётность

bool Chetniy(int num)
{
    num = num % 2;
    if(num == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("input an integer number ");
int number = Convert.ToInt32(Console.ReadLine());

bool answer = Chetniy(number);
Console.WriteLine($"number {number} is even: {answer}");
*/ 

