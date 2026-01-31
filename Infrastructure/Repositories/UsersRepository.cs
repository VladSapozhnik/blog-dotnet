using BlogApplication.Domain.Entities;
using BlogApplication.Domain.Interfaces;

namespace BlogApplication.Infrastructure.Repositories;
public class UsersRepository: IUserRepository
{
    private static readonly List<UserEntity> _users = new List<UserEntity>();

    public void CreateUser(UserEntity newUser)
    {
        _users.Add(newUser);
    }

    public IEnumerable<UserEntity> GetUsers ()
    {
        return _users;
    }

    public Guid RemoveUser(Guid id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        
        if (user == null)
            throw new Exception("User not found");
        
        _users.Remove(user);
        
        return id;
    }
}