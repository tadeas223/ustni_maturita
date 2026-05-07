public class User {
    private int id;
    private string name;
    
    public int Id {get => id;}
    public string Label {get => name;}

    public User(int id, string name) {
        this.id = id;
        this.name = name;
    }

    public override string ToString() {
        return $"User(id={id}, name='{name}')";
    }

}
