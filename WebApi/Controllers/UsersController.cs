using BlogApplication.Domain.Entities;
using BlogApplication.Domain.Interfaces;
using BlogApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.WebApi.Controllers;


[ApiController]
[Route("users")]
public class UsersController : Controller
{
    private readonly IUserRepository _usersRepository;

    public UsersController(IUserRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }
    
    [HttpGet("registration")]
    public IActionResult Registration() => View(new CreateUserDto());

    [HttpPost("create")]
    public IActionResult CreateUser([FromForm] CreateUserDto model) 
    {
        if (!ModelState.IsValid)
            return View("Registration", model);
        var newUser = new UserEntity
        {
            UserName = model.UserName,
            Password = model.Password,
        };
        
        _usersRepository.CreateUser(newUser);

        return View("UserCreated", model);
    }

    [HttpGet("all-users")]
    public IActionResult GetAllUsers()
    {
        var users = _usersRepository.GetUsers();
        return Ok(users);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(Guid id)
    {
        var removeUserId = _usersRepository.RemoveUser(id);
        
        return Ok(removeUserId);
    }
}