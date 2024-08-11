using CleanDotnet.Services;
using CleanDotnet.Model;
public static class UserController
{
    public static void UseUserController(this IEndpointRouteBuilder routes)
    {
        var userRoutes = routes.MapGroup("/users");

        userRoutes.MapGet("", (UserService userService)
            => userService.List());
        userRoutes.MapGet("{id:int}", (int id, UserService userService)
            => userService.getById(id));
        userRoutes.MapPost("", (User user, UserService userService)
            => userService.CreateUser(user));
        userRoutes.MapPut("{id:int}", (int id, User user, UserService userService)
            => userService.updateById(id, user));
        userRoutes.MapDelete("{id:int}", (int id, UserService userService)
            => userService.remove(id));
    }
}
