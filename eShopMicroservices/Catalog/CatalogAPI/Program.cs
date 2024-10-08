var builder = WebApplication.CreateBuilder(args);

//Add services to the container 
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);

});

var connectionString = builder.Configuration.GetConnectionString("Database");
Console.WriteLine($"Connection String: {connectionString}");
builder.Services.AddMarten(opts =>
{
    opts.Connection(connectionString!);
}).UseLightweightSessions();


var app = builder.Build();

//Configure the HTTP request pipeline lifecycle 
app.MapCarter();

app.Run();
