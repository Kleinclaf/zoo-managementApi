var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();


app.MapGet("/health", () => new
{
    success = true,
    message = "ZooManagement API is running",
    data = (object?)null
});

app.MapGet("/", () => Results.Redirect("/swagger"));

app.Run();
