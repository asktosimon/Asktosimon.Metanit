var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
/*RequestDelegate res = async (context) => { context.Response.Redirect("/"); };
RequestDelegate ress = async (context) => { await context.Request.Form["name"]; };*/

/*RequestDelegate res = async (context) =>
{
    if (context.Request.HasJsonContentType())
    {
        var person = await context.Request.ReadFromJsonAsync<Person>();
        if (person != null)
        {
            Console.WriteLine("person");
        }
    }
};*/

RequestDelegate res = async (context) =>
{
    Console.WriteLine("RUN");
};

async Task GetData(HttpContext context, RequestDelegate next)
{
    Console.WriteLine("USE after");
    await next.Invoke(context);
    Console.WriteLine("USE before");
}

app.Use(GetData);

app.Run(res);

app.Run();

class Person { }