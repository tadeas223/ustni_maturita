public class Program
{
    public static void Main(string[] args)
    {
        UserView view = new();
        UserController controller = new();

        view.Controller = controller;
        controller.View = view;

        controller.Run();
    }
}
