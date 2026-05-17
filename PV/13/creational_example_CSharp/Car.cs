public class Car : ITransport
{
    int cylinder_count;
    string name;
    
    public Car( string name, int cylinder_count)
    {
        this.cylinder_count = cylinder_count;
        this.name = name;
    }

    public void DoSound() 
    {
        Console.WriteLine("Generic Car Sound");
        Console.WriteLine($"{name} {cylinder_count}");
    }

    public ITransport Clone()
    {
        return new Car(name, cylinder_count);
    }
}
