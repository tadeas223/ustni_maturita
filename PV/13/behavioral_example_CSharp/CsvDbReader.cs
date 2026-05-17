public class CsvDbReader : DbReader
{
    public override void LoadFile()
    {
        Console.WriteLine("loading csv file");
    }
   
    public override void ParseFile()
    {
        Console.WriteLine("parsing csv file");
    }

    public override Table CreateTable()
    {
        Console.WriteLine("creating table from csv");
        return new Table();
    }
}
