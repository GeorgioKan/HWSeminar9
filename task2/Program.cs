// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



int Function(int numb)
{
    if (numb == 0)
    {
        return 0;
    }
    return numb%10 + Function(numb/10);    
}

int number = 123;
System.Console.WriteLine(Function(number));