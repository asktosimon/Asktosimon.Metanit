var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

/*app.Map("/Index", (appBuilder) =>
{
    appBuilder.Use(async (context, next) =>
    {
        Console.WriteLine("appBuilder");
        await next();
    });
});*/



app.Map("/{id}", (string id) => Console.WriteLine(id));
app.Use(async (context, next) =>
{
    Console.WriteLine("1");
    await next.Invoke();
    Console.WriteLine("2");
});
/*app.Run(async context =>
{
    await context.Response.WriteAsync("Resource not found");
    Console.WriteLine("wswddsd");
});*/

/*app.Map("/", async (context) =>
{
    await context.Response.WriteAsync("About Page");
    Console.WriteLine("context");
});*/

app.Run();
