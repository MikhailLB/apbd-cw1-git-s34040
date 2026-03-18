namespace ConsoleApp2.Internal.Users;

public record User(int Id, string Name, string Email);

public interface IUserStorage
{
    User GetUser(int id);
    
    void UpdateUser(User user);

    void PartiallyUpdateUser(int id, object updates);
}