using System;

public abstract class Animal
{
    protected string name;
    public abstract void MakeSound();
    public virtual void Describe()
    {
        Console.WriteLine("This is an animal");
    }
}
