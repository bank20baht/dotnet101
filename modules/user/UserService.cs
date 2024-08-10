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
}
