using CleanDotnet.Services;

public static class UserController
{
    public static void UseUserController(this IEndpointRouteBuilder routes)
    {
        var userRoutes = routes.MapGroup("/users");

        userRoutes.MapGet("/", async ( UserService userService) => await userService.List());
    }
}
