public class CarFactory : TransportFactory
{
    string name;
    int cylinder_count;

    public CarFactory(string name, int cylinder_count)
    {
        this.name = name;
        this.cylinder_count = cylinder_count;
    }

    public override ITransport Create()
    {
        return new Car(name, cylinder_count);
    }
}
