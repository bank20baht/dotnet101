using CleanDotnet.Model;

namespace CleanDotnet.IRepository;
public interface IUserRepository
{
    Task<List<User>> List();
    Task<User?> getById(int id);
    Task<Boolean> updateById(int id, User user);
    Task<User?> createUser(User user);
    Task<User?> remove(int id);
}
