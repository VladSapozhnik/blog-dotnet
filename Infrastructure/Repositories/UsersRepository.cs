using System.Collections.Generic;
using BlogApplication.Models;

namespace BlogApplication.Infrastructure.Repositories;

public interface IUsersRepository
{
    void CreateUser(CreateUserDto model);
    IEnumerable<CreateUserDto> GetUsers();
    Guid RemoveUser(Guid id);
}

public class UsersRepository: IUsersRepository
{
    private static readonly List<CreateUserDto> _users = new List<CreateUserDto>();

    public void CreateUser(CreateUserDto model)
    {
        _users.Add(model);
    }

    public IEnumerable<CreateUserDto> GetUsers ()
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