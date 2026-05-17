public class ShipBuilder
{
    public string? Name {get; set;}
    public int PropellerStrength {get; set;}
    public int ChimneyCount{get; set;}

    public ShipBuilder(string name)
    {
        Name = name;
    }

    public Ship Build()
    {
        return new Ship(Name ?? "", PropellerStrength, ChimneyCount);
    }

    public ShipBuilder SetName(string name)
    {
        Name = name;

        return this;
    }
    
    public ShipBuilder SetPropellerStrength(int s)
    {
        PropellerStrength = s;

        return this;
    }
    
    public ShipBuilder SetChimneyCount(int c)
    {
        ChimneyCount = c;

        return this;
    }
}
