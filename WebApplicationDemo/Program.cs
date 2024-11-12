using System.Diagnostics.Eventing.Reader;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers();

//var summaries = new[]
//{
//    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
//        (
//            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//});

//app.MapGet("/shirts", () =>
//{
//    return "Reading shirts";
//});
//app.MapGet("/shirts/{id}", (int id) =>
//{
//    return $"Reading a  shirt of id :{id}";
//});
//app.MapPost("/shirts/{id}", (int id) =>
//{
//    return $"Creating a shirt with id:{id}";   
//});
//app.MapPut("/shirts/{id}", (int id) =>
//{
//    return $"Updating a shirt with id:{id}";
//});

//app.MapDelete("/shirts/{id}", (int id) =>
//{
//    return $"Deleting a shirt with id:{id}";
//});

app.Run();

//internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}
