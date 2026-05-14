using MySql.Data.MySqlClient;

public class UserRepository
{
    MySqlConnection connection;
    
    public UserRepository(MySqlConnection connection)
    {
        this.connection = connection;
    }

    public List<User> GetUsers()
    {
        List<User> users = new();

        using var cmd = new MySqlCommand(@"
            select id, name, email from users;
        ", connection);

        using MySqlDataReader reader = cmd.ExecuteReader();

        while(reader.Read())
        {
            int id = reader.GetInt32(0);
            string username = reader.GetString(1);
            string email = reader.GetString(2);

            users.Add(new User(id, username, email));
        }

        return users;
    }
}
