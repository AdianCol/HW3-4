using System;

class Prog{
    static void Main()
    {
        IProvider<int> intarrayprov = new  IntValueProvider();
        IProvider<double> doubarrayprov = new  DoubleValueProvider();
        IProvider<bool> boolarrayprov = new  BoolValueProvider();
        IProvider<string> strarrayprov = new  StringValueProvider();

        OneDemensionMassive<int> intArray1= new OneDemensionMassive<int>(intarrayprov);
        OneDemensionMassive<double> doubleArray1 = new OneDemensionMassive<double>(doubarrayprov);
        OneDemensionMassive<bool> boolArray1 = new OneDemensionMassive<bool>(boolarrayprov);
        OneDemensionMassive<string> stringArray1 = new OneDemensionMassive<string>(strarrayprov);

        TwoDemensionMassive<int> intArray2 = new TwoDemensionMassive<int>(intarrayprov);
        TwoDemensionMassive<double> doubleArray2 = new TwoDemensionMassive<double>(doubarrayprov);
        TwoDemensionMassive<bool> boolArray2 = new TwoDemensionMassive<bool>(boolarrayprov);
        TwoDemensionMassive<string> stringArray2 = new TwoDemensionMassive<string>(strarrayprov);

        IPrinter[] printers = new IPrinter[]
        {
            intArray1, doubleArray1, boolArray1, stringArray1, intArray2, doubleArray2, boolArray2, stringArray2
        };

        foreach (IPrinter printer in printers)
        {
            Console.WriteLine($"Элементы массива {printer.GetType()}:");
            printer.Print();
        }
    }
}