public class ShipFactory : TransportFactory
{
    string name;
    int propeller_strength;
    int chimney_count; 

    public ShipFactory(string name, int propeller_strength, int chimney_count)
    {
        this.name = name;
        this.propeller_strength = propeller_strength;
        this.chimney_count = chimney_count;
    }

    public override ITransport Create()
    {
        Logger.Instance.Print("creating ship");
        return new Ship(name, propeller_strength, chimney_count);
    }
}
