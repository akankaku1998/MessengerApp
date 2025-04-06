using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories.Users;

public class UsersRepository(ApplicationDbContext ctx) : IUsersRepository
{
    private readonly ApplicationDbContext _ctx = ctx;

    public async Task<IEnumerable<AppUserModel>> GetAll() => await _ctx.AppUsers.ToListAsync();

    public async Task<AppUserModel> GetById(int id) => await _ctx.AppUsers.SingleOrDefaultAsync(i => i.Id == id);
}
