using BlogApplication.Infrastructure.Repositories;
using BlogApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.Controllers;


[ApiController]
[Route("users")]
public class UsersController : Controller
{
    private readonly IUsersRepository _usersRepository;

    public UsersController(IUsersRepository usersRepository)
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
        _usersRepository.CreateUser(model);

        return View("UserCreated", model);
    }

    [HttpGet("all-users")]
    public IActionResult GetAllUsers()
    {
        var users = _usersRepository.GetUsers();
        return Ok(users);
    }
}