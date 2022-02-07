var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.UseMiddleware<TokenMiddleware>();
app.UseToken();
app.Map("/test", appBuilder =>
{
    appBuilder.Use(async (context, next) =>
    {
        Console.WriteLine("appBuilder.Use");
        await next();
    });

    appBuilder.Run(async (context) =>
    {
        Console.WriteLine("appBuilder.Run");
        await context.Response.WriteAsync("TEST");
    });
});

app.Use(HandleResponseUse);

app.Run(HandleResponseJSON);

app.Run();

async Task HandleRequest(HttpContext context)
{
    // context.Response.Headers
    // context.Response.StatusCode = 404;
    await context.Response.WriteAsync("Hello World!");
}

async Task HandleRequestHTML(HttpContext context)
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync("<h1>Hello World!</h1>");
    // System.Diagnostics.Debug.WriteLine(context.Request.Path);
}

async Task HandleResponseJSON(HttpContext context)
{
    Console.WriteLine($"HandleResponseJSON {context.Request.Path}");
    var p = new Person() { Age = 23, Name = "Andrey" };

    await context.Response.WriteAsJsonAsync(p);
}

async Task HandleResponseUse(HttpContext context,RequestDelegate next)
{
    Console.WriteLine($"1 HandleResponseUse {context.Request.Path}");

    await next.Invoke(context);
    
    Console.WriteLine("2 HandleResponseUse");
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class TokenMiddleware
{
    private readonly RequestDelegate next;

    public TokenMiddleware(RequestDelegate next)
    {
        Console.WriteLine("TokenMiddleware");
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var token = context.Request.Query["token"];

        if (token != "12345678")
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsync("Token is invalid!");
        }
        else
        {
            await next.Invoke(context);
        }
    }
}

public static class TokenE
{
    public static IApplicationBuilder UseToken(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TokenMiddleware>();
    }
}