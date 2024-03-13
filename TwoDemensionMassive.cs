public sealed class TwoDemensionMassive<T> : Massive<T>
{
        private T[,] massive;


    public TwoDemensionMassive(IProvider<T> provider,bool choice = false) 
    : base(choice, provider) { }

    public override void CreateMassiveByUser()
    {
        Console.WriteLine("Lengths of array");
        int length1 = int.Parse(Console.ReadLine());
        int length2 = int.Parse(Console.ReadLine());
        massive = new T[length1, length2];
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                massive[i, j] = _provider.ReturnByUser();
            }
        }
    }

    public override void CreateMassiveByRandom()
    {
        var random = new Random();
        massive = new T[random.Next(1, 51), random.Next(1, 51)];
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                massive[i, j] = _provider.ReturnByRandom();
            }
        }
    }
    public override void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            Console.Write($"Row {i}: ");
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                Console.Write(massive[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}