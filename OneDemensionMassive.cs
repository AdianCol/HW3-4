using System;

public sealed class OneDemensionMassive<T> : Massive<T>
{
    private T[] massive;


    public OneDemensionMassive(IProvider<T> provider,bool choice = false) 
    : base(choice, provider) { }

    public override void CreateMassiveByUser()
    {
        Console.WriteLine("Length of array");
        int length = int.Parse(Console.ReadLine());
        massive = new T[length];
        for (int i = 0; i < massive.Length; i++)
        {
            massive[i] = _provider.ReturnByUser();
        }
    }

    public override void CreateMassiveByRandom()
    {
        var random = new Random();
        massive = new T[random.Next(1, 10)];
        for (int i = 0; i < massive.Length; i++)
        {
            massive[i] = _provider.ReturnByRandom();
        }
    }

    public override void Print()
    {
        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(" ", massive));
    }
}