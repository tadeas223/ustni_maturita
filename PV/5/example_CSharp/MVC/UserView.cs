public class UserView
{
    public UserController? Controller {get; set;}

    public void ShowUsers(List<User> users)
    {
        foreach(User user in users)
        {
            Console.WriteLine(user);
        }
    }

    public void StartSelection()
    {
        int selectionCount = 1;
        Console.WriteLine("Select action:");
        Console.WriteLine("[0]: ShowUsers");
        Console.WriteLine("[1]: Exit");
        
        int number;
        while(true)
        {
            try 
            {
                number = int.Parse(Console.ReadLine()!);

                if(number < 0 && number >= selectionCount) {
                    Console.WriteLine("Invalid Selection");   
                }

                break;
            }
            catch(Exception)
            {
                Console.WriteLine("Not A Number");   
            }
        }

        switch(number)
        {
            case 0:
                Controller!.OnShowUsers();
                break;
            
            case 1:
                Controller!.OnExit();
                break;
        }
    }
}
