public class JsonDbReader : DbReader
{
    public override void LoadFile()
    {
        Console.WriteLine("loading json file");
    }
   
    public override void ParseFile()
    {
        Console.WriteLine("parsing json file");
    }

    public override Table CreateTable()
    {
        Console.WriteLine("creating table from json");
        return new Table();
    }
}
