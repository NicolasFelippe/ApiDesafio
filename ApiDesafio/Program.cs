using ApiDesafio.Controllers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/{wordOne}/{wordTwo}", new WordController().IsPrimeWord);

app.Run();
