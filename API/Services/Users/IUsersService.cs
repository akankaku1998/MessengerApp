using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities.User;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Users;

public interface IUsersService
{
    Task<IEnumerable<AppUserModel>> GetAllUsers();
    Task<AppUserModel> GetUser(int id);
}
