using CleanDotnet.Model;
using CleanDotnet.Repository;

namespace CleanDotnet.Services;

public class UserService
{
    private readonly ILogger<UserService> _logger;
    private readonly UserRepository _userRepository;

    public UserService(ILogger<UserService> logger, UserRepository userRepository)
    {
        _logger = logger;
        _userRepository = userRepository;
    }

    public async Task<List<User>> List()
    {
        var users = await _userRepository.List();
        return users;
    }

    public async Task<User?> getById(int id)
    {
        var user = await _userRepository.getById(id);
        return user;
    }

    public async Task<User?> CreateUser(User user)
    {
        var users = await _userRepository.createUser(user);
        return users;
    }

    public async Task<User?> remove(int id)
    {
        var users = await _userRepository.remove(id);
        return users;
    }

    public async Task<Boolean> updateById(int id, User user)
    {
        var users = await _userRepository.updateById(id, user);
        return users;
    }
}
