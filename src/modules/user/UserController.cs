using CleanDotnet.Services;
using CleanDotnet.Model;

public static class UserController
{
    public static void UseUserController(this IEndpointRouteBuilder routes)
    {
        var userRoutes = routes.MapGroup("/users");

        userRoutes.MapGet("", async (UserService userService)
            =>
        {
            try
            {
                var response = await userService.List();
                return Results.Ok(response);
            }
            catch (Exception ex)
            {
                return Results.Problem(detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
            }

        });
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
