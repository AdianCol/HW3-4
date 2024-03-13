using System;

public interface IProvider<T>
{
    T ReturnByRandom();
    T ReturnByUser();
}


class IntValueProvider:IProvider<int>
{
    public int ReturnByRandom()
    {
        Random random = new Random();
        int a = random.Next(0,10);
        return a;
    }

    public int ReturnByUser()
    {
        return int.Parse(Console.ReadLine());
    }
}


class StringValueProvider:IProvider<string>
{
    public string ReturnByRandom()
    {   
        char[] CharArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        Random random = new Random();
        char[] array1 = new char[10];
        for(int i = 0; i < 10; i++)
        {
            int number = random.Next(0,26);
            array1[i] = CharArray[number];
        }
        return new string(array1);
    }

    public string ReturnByUser()
    {
        return Console.ReadLine();
    }
}


class DoubleValueProvider:IProvider<double>
{
    public double ReturnByRandom()
    {
        Random random = new Random();

        int value = random.Next(10, 100000);
        int length = value.ToString().Length;
        double number = value/(10*(length-1));

        return number;
    }

    public double ReturnByUser()
    {
        return double.Parse(Console.ReadLine());
    }
}


class BoolValueProvider:IProvider<bool>
{
    public bool ReturnByRandom()
    {
        Random random = new Random();
        int value = random.Next(0, 2);
        return value == 0;
    }

    public bool ReturnByUser()
    {
        return bool.Parse(Console.ReadLine());
    }
}