int userInput = int.Parse(Console.ReadLine()!);


TransportFactory factory;

if(userInput == 0)
{
    factory = new CarFactory("auto", 2);
}
else
{
    factory = new ShipFactory("lod", 2, 2);
}

factory = new ShipFactory("lod", 2, 2);

var deliver = new DeliverService(factory);

deliver.StartDelivery();


var ship = new ShipBuilder("dol")
    .SetChimneyCount(1)
    .SetPropellerStrength(1)
    .Build();


