using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities.User;
using API.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUserModel>>> List()
    {
        var users = await _usersService.GetAllUsers();
        return Ok(users);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<AppUserModel>> GetUser(int id)
    {
        var user= await _usersService.GetUser(id);
        if(user == null) return NotFound();
        return Ok(user);
    }
}
