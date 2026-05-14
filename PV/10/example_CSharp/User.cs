public class User
{
    public int? Id {get; set;}
    public string Username {get; set;}
    public string Email {get; set;}

    public User(int id, string username, string email)
    {
        Id = id;
        Username = username;
        Email = email;
    }
    
    public User(string username, string email)
    {
        Id = null;
        Username = username;
        Email = email;
    }

    public override string ToString()
    {
        return $"User(Id = {Id}, Username = {Username}, Email = {Email})";
    }
}
