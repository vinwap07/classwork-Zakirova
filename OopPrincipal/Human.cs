namespace OopPrincipal;

public abstract class Human : ISpeakable, IMoveable, IHuman
{
    // поля
    public string Name { get; protected set; }
    public int Age { get; protected set; }
    
    // конструкторы
    protected Human(string name, int age) 
    {
        Name = name;
        Age = age;
    }

    // методы
    public virtual void Say(string message)
    {
        Console.WriteLine($"{Name} {Age} : {message}");
    }

    public virtual void Move() { }

    //public abstract string Position { get; }

}
