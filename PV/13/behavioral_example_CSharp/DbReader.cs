public abstract class DbReader
{
    public abstract void LoadFile();
    public abstract void ParseFile();
    public abstract Table CreateTable();

    public Table Load()
    {
        LoadFile();

        ParseFile();

        var table = CreateTable();

        return table;
    }
}
