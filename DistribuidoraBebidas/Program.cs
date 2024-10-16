using Domain.Login;
using Domain.Repository;
using Domain.Token;
using Infraestruture.repository.Context;
using Infraestruture.repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(LoginHandler).Assembly));
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(LoginH).Assembly));
builder.Services.AddScoped<IUsuarioRepository, LocalRepository>();
builder.Services.AddScoped<TokenService>();
//builder.Services.AddScoped<DBContext>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



