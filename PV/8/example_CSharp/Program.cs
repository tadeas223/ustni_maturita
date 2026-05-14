public class Animal
{
    public string Name {get; set;}

    public Animal(string name)
    {
        Name = name;
    }

    public virtual string MakeSound()
    {
        return "generic animal sound";
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
    
    public override string MakeSound()
    {
        return "bark";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog("pes");
        Console.WriteLine(dog.MakeSound());


        Animal dogAnimal = dog;
        Console.WriteLine(dogAnimal.MakeSound());
    }
}
