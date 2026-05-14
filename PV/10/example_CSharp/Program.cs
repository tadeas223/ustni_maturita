using MySql.Data;
using MySql.Data.MySqlClient;

public class Program
{

    public static void Main(string[] args)
    {
        string conString = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            Database = "test",
            UserID = "root",
            Password = "test"
        }.ToString();

        using MySqlConnection connection = new MySqlConnection(conString);

        connection.Open();

        using var command = new MySqlCommand(@"
            create table if not exists users (
                id int auto_increment primary key,
                name varchar(100),
                email varchar(100)
            );
        ", connection);

        UserDao dao = new UserDao(connection);

        dao.Insert("test", "email");
        
        User user = dao.SelectById(1);

        Console.WriteLine(user);
    

        UserRepository repo = new UserRepository(connection);
    
        List<User> users = repo.GetUsers();

        foreach(User u in users)
        {
            Console.WriteLine(u);
        }

        command.ExecuteNonQuery();
    }
}
