public abstract class Massive<T> : IPrinter
{
    protected IProvider<T> _provider;


    public abstract void CreateMassiveByRandom();

    public abstract void CreateMassiveByUser();

    public virtual void InitializeArray(bool choice)
    {
        if(choice)
        {
            CreateMassiveByUser();
        }
        else
        {
            CreateMassiveByRandom();
        }
    }

    public abstract void Print();

    public Massive(bool choice, IProvider<T> provider)
    {
        _provider = provider;
        InitializeArray(choice);
    }
}
