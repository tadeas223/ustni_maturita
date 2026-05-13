public class UserController
{
    List<User> users = new();
    public UserView? View {get; set;}

    bool IsRunning {get; set;} = false;

    public void Run()
    {
        IsRunning = true;

        if(View == null)
        {
            throw new Exception("View not set");
        }

        users.Add(new User("Name1", "Surname1"));
        users.Add(new User("Name2", "Surname2"));
        users.Add(new User("Name3", "Surname3"));

        View.Controller = this;
        
        while(IsRunning)
        {
            View.StartSelection();
        }
    }

    public void OnShowUsers()
    {
        View!.ShowUsers(users);
    }

    public void OnExit()
    {
        IsRunning = false;
    }

}
