using CleanDotnet.Model;
using Microsoft.EntityFrameworkCore;
using CleanDotnet.IRepository;

namespace CleanDotnet.Repository;

public class UserRepository : IUserRepository
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

    public async Task<User?> getById(int id)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> createUser(User user)
    {
        var entry = await _dbContext.AddAsync(user);
        await _dbContext.SaveChangesAsync();

        var newUser = entry.Entity;
        return newUser;

    }

    public async Task<User?> remove(int id)
    {
        var updateUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);

        _dbContext.Users.Remove(updateUser);
        await _dbContext.SaveChangesAsync();

        return updateUser;
    }

    public async Task<Boolean> updateById(int id, User user)
    {
        var existingUser = await _dbContext.Users
    .FirstOrDefaultAsync(u => u.Id == id)!;
        if (existingUser == null)
        {
            return false;
        }

        existingUser.Name = user.Name;
        _dbContext.Update(existingUser);
        await _dbContext.SaveChangesAsync();

        return true;
    }
}
