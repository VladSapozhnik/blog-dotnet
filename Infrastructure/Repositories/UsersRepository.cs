using WebApplication1.Models;
using System.Collections.Generic;
namespace WebApplication1.Infrastructure.Repositories;

public interface IUsersRepository
{
    void CreateUser(CreateUserDto model);
    IEnumerable<CreateUserDto> GetUsers();
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
}