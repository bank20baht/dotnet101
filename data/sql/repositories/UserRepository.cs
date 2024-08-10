using CleanDotnet.Model;
using Microsoft.EntityFrameworkCore;
namespace CleanDotnet.Repository;

public class UserRepository
{
    private readonly AppDBContext _dbContext;

    public UserRepository(AppDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<User>> List()
    {
       return await _dbContext.Users.ToListAsync();
    }
}
