using MySql.Data.MySqlClient;

public class UserDao
{
    MySqlConnection connection;

    public UserDao(MySqlConnection connection)
    {
        this.connection = connection;
    }

    public User SelectById(int id)
    {
        using var cmd = new MySqlCommand(@"
            select name, email from users
                where id = @id;
        ", connection);

        cmd.Parameters.Add("@id", MySqlDbType.Int32);
        cmd.Parameters["@id"].Value = id;

        using MySqlDataReader reader = cmd.ExecuteReader();
        
        if(!reader.HasRows)
        {
            throw new Exception("user not found");
        }
        
        reader.Read();

        string username = reader.GetString(0);
        string email = reader.GetString(1);
        
        return new User(id, username, email);
    }

    public void Insert(string username, string email)
    {
        using var cmd = new MySqlCommand(@"
            insert into users(name, email)
            values(@username, @email)
        ", connection);

        cmd.Parameters.Add("@username", MySqlDbType.VarString);
        cmd.Parameters["@username"].Value = username;
        
        cmd.Parameters.Add("@email", MySqlDbType.VarString);
        cmd.Parameters["@email"].Value = username;

        cmd.ExecuteNonQuery();
    }
}
