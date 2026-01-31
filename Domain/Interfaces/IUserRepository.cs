using BlogApplication.Domain.Entities;
using BlogApplication.Models;

namespace BlogApplication.Domain.Interfaces;

public interface IUserRepository
{
    void CreateUser(UserEntity newUser);
    IEnumerable<UserEntity> GetUsers();
    Guid RemoveUser(Guid id);
}