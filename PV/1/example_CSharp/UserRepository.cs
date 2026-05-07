public class UserRepository {
    public User GetUserById(int id) {
        return new User(id, "test_user");
    }

    public void UpdateUser(ref User user) {
        User newUser = new User(user.Id, "updated_user");
        user = newUser;
    }
}
