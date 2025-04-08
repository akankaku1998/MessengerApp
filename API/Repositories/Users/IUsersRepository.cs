using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities.User;

namespace API.Repositories.Users;

public interface IUsersRepository
{
    Task<IEnumerable<AppUsersModel>> GetAll();
    Task<AppUsersModel> GetById(int id);
    
}
