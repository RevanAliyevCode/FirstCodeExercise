// See https://aka.ms/new-console-template for more information
using static System.Console;

Task23();

void Task0()
{
    Write("Write a number: ");
    int number = int.Parse(ReadLine());

    if (number == 0)
    {
        WriteLine("Eded sifirdir");
    }
    else if (number < 0)
    {
        WriteLine("Eded menfidir");
    }
    else
    {
        WriteLine("Eded musbetdir");
    }
}

//Task 1
void Task1()
{
    int i = 1;
    int sum = 0;
    while (i <= 5)
    {
        Write("Enter number: ");
        int number = int.Parse(ReadLine());
        sum += number;
        i++;
    }

    WriteLine(sum);
}

//Task2
void Task2()
{
    Write("Enter nuber: ");
    int number = int.Parse(ReadLine());
    WriteLine($"{number * number}");
}

//Task3
void Task3()
{
    int temp = 0;
    int i = 1;

    while (i <= 3)
    {
        Write("Enter number: ");
        int number = int.Parse(ReadLine());
        if (number > temp)
        {
            temp = number;
        }
        i++;
    }
    WriteLine(temp);
}

//Task4
void Task4()
{
    Write("Enter num1: ");
    int num1 = int.Parse(ReadLine());
    Write("Enter num2: ");
    int num2 = int.Parse(ReadLine());

    if (Math.Pow(num1, 3) > num2)
    {
        WriteLine("Num1 power 3 grather then num2");
    }
    else
    {
        WriteLine("Num2 grather then num1 power 3");
    }
}

//Task5
void Task5()
{
    Write("Enter number: ");
    int number = int.Parse(ReadLine());

    if (number % 3 == 0 && number % 5 == 0)
    {
        WriteLine("Eded hem 3 e hemde 5 e bolunur");
    }
    else
    {
        WriteLine("Eded hem 3 e hemde 5 e bolunmur");
    }
}

//Task6
void Task6()
{
    Write("Enter balance: ");
    int balance = int.Parse(ReadLine());
    Write("Enter cost: ");
    int cost = int.Parse(ReadLine());

    if (balance < cost)
    {
        WriteLine("You can not buy this");
    }
    else
    {
        WriteLine("You can buy this");
    }
}

//Task7
void Task7()
{
    int i = 1;
    int avrg = 0;

    while (i <= 5)
    {
        Write("Write your point (0-100): ");
        int point = int.Parse(ReadLine());

        if (point < 0 || point > 100)
        {
            Write("Enter a point between 0-100: ");
            point = int.Parse(ReadLine());
        }

        avrg += point;
        i++;
    }

    avrg /= 5;
    if (avrg > 65)
    {
        WriteLine($"Your point {avrg}: you passed");
    }
    else
    {
        WriteLine($"Your point {avrg}: you fail");
    }
}

//Task8
void Task8()
{
    int num1;
    int num2;
    do
    {
        Write("Write num1: ");
        num1 = int.Parse(ReadLine());
        Write("Write num2: ");
        num2 = int.Parse(ReadLine());
    } while ((num1 == 0 || num1 > 9) || (num2 == 0 || num2 > 9));

    if (num1 == num2)
    {
        WriteLine("num1 beraberdir num2");
    }
    else if (num1 > num2)
    {
        WriteLine("num1 boyukdur num2 den");
    }
    else
    {
        WriteLine("num2 boyukdur num1 den");
    }
}

//Task9
void Task9()
{
    Write("Write temprature: ");
    int temp = int.Parse(ReadLine());

    if (temp < 0)
    {
        WriteLine("Suyun donma tempraturundan asagidir");
    }
    else
    {
        WriteLine("Suyun donma tenpuraturundan yuxaridir");
    }
}

//Task10
void Task10()
{
    for (int i = 1; i <= 50; i++)
    {
        WriteLine(i);
    }
}

//Task11
void Task11()
{
    int count = 0;

    for (int i = 1; i <= 40; i++)
    {
        if (i % 3 == 0)
        {
            count++;
        }
    }

    WriteLine($"1 den 40 a qeder olan ededlerden 3 e bolunenlerin sayi: {count}");
}

//Task12
void Task12()
{
    int count = 0;

    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 7 == 0)
        {
            WriteLine(i);
            count++;
        }
    }

    WriteLine($"1 den 100 qeder olan ededlerden hem 3 hemde 7 ye bolunen ededlerin sayi: {count}");
}

//Task13
void Task13()
{
    Write("Enter number: ");
    int number = int.Parse(ReadLine());
    int count = 0;

    if (number == 0)
    {
        count = 1;
    }
    while (number > 0)
    {
        count++;
        number /= 10;
    }

    WriteLine($"Reqem sayi: {count}");
}

//Task14
void Task14()
{
    Write("Write number: ");
    int number = int.Parse(ReadLine());
    int temp = 0;

    while (number > 0)
    {
        temp = (temp * 10) + number % 10;

        number /= 10;
    }

    WriteLine($"Ededin tersi {temp}");
}

//Task15
void Task15()
{
    Write("Enter number: ");
    int number = int.Parse(ReadLine());
    int fc = 1;

    for (int i = 1; i <= number; i++)
    {
        fc *= i;
    }

    WriteLine($"{number}-in faktoriali: {fc}");
}

//Task16
void Task16()
{
    Write("Enter number: ");
    int number = int.Parse(ReadLine());
    string answer = "";

    for (int i = 2; i <= (int)Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            answer = "Eded murekkebdir";
        }
    }

    answer = answer == "" ? "Eded sadedir" : answer;
    WriteLine(answer);
}

//Task17
void Task17()
{
    Write("Write number: ");
    int number = int.Parse(ReadLine());
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    WriteLine($"Reqemleri cemi: {sum}");
}

//Task18
void Task18()
{
    Write("Write number: ");
    int number = int.Parse(ReadLine());
    int temp = 0;

    while (number > 0)
    {
        if (temp < number % 10)
        {
            temp = number % 10;
        }
        number /= 10;
    }

    WriteLine($"Reqemler icinde en boyuyu: {temp}");
}

//Task19
void Task19()
{
    for (int i = 70; i > 0; i--)
    {
        if (i % 2 == 0)
        {
            WriteLine(i);
        }
    }
}

//Task20
void Task20()
{
    Write("Write number of mounth: ");
    string mounth = int.Parse(ReadLine()) switch
    {
        1 or 2 or 12 => "Qis fesilidir",
        3 or 4 or 5 => "Yaz fesilidir",
        6 or 7 or 8 => "Yay fesilidir",
        9 or 10 or 11 => "Payiz fesilidir",
        _ => "Bele bir fesil yoxdur"
    };

    WriteLine(mounth);
}

//Task21
void Task21()
{
    Write("Write height: ");
    int height = int.Parse(ReadLine());
    Write("Write width: ");
    int width = int.Parse(ReadLine());

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Write("*");
        }
        WriteLine();
    }
}

//Task22
void Task22()
{
    Write("Write height: ");
    int height = int.Parse(ReadLine());

    WriteLine();
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Write("*");
        }
        WriteLine();
    }
}

//Task23
void Task23()
{
    Write("Write height: ");
    int height = int.Parse(ReadLine());

    WriteLine();
    for (int i = height; i > 0; i--)
    {
        for (int j = i; j > 0; j--)
        {
            Write("*");
        }
        WriteLine();
    }
}