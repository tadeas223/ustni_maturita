public class Ship : ITransport
{
    string name;
    int propeller_strength = 0;
    int chimney_count = 0; 
    
    public Ship(string name, int propeller_strength, int chimney_count)
    {
        this.name = name;
        this.propeller_strength = propeller_strength;
        this.chimney_count = chimney_count;
    }

    public void DoSound() {
        Console.WriteLine("Generic Ship Sound"); 
        Console.WriteLine($"{name} {propeller_strength} {chimney_count}");
    }

    public ITransport Clone() {
        return new Ship(name, propeller_strength, chimney_count);
    }
}
