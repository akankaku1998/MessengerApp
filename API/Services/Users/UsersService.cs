using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities.User;
using API.Repositories.Users;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Users;

public class UsersService : IUsersService
{
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public Task<IEnumerable<AppUserModel>> GetAllUsers() => _usersRepository.GetAll();

    public Task<AppUserModel> GetUser(int id) => _usersRepository.GetById(id);
}
