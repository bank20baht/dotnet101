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

    public async Task<IResult> List()
    {
        var users = await _userRepository.List();
        return TypedResults.Ok(users);
    }

    public async Task<IResult> getById(int id)
    {
        var user = await _userRepository.getById(id);
        return TypedResults.Ok(user);
    }

    public async Task<IResult> CreateUser(User user)
    {
        var users = await _userRepository.createUser(user);
        return TypedResults.Created("success", users);
    }

    public async Task<IResult> remove(int id)
    {
        var users = await _userRepository.remove(id);
        return TypedResults.Ok("");
    }

    public async Task<IResult> updateById(int id, User user)
    {
        var users = await _userRepository.updateById(id, user);
        return TypedResults.Ok("");
    }
}
