using ApiDesafio.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.TryAddSingleton<IWordService, WordService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();
if (builder.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();
}
app.UseSwagger();
app.MapControllers();
app.UseSwaggerUI();

app.Run();
