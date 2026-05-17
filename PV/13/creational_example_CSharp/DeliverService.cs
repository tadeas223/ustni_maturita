public class DeliverService
{
    TransportFactory factory;
    public DeliverService(TransportFactory factory)
    {
        this.factory = factory;
    }

    public void StartDelivery()
    {
        // Wait for package
        Logger.Instance.Print("delivery waiting for package");
        Thread.Sleep(1000);

        var transporter = factory.Create();

        transporter.DoSound();
    }
}
