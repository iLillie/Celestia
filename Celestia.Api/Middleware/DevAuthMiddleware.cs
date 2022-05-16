namespace Celestia.Api.Middleware;

public class DevAuthMiddleware
{
    private readonly RequestDelegate _next;

    public DevAuthMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var accountId = context.Request.Query["accountId"];
        if (string.IsNullOrEmpty(accountId))
        {
            await _next(context);
            return;
        }

        await _next(context);
    }
}

public static class DevAuthMiddlewareExtensions
{
    public static IApplicationBuilder UseDevAuth(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<DevAuthMiddleware>();
    }
}