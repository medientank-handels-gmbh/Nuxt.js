var builder = WebApplication.CreateBuilder(args);
var Allcors = "corsapp";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p => p.AddPolicy(Allcors, policy =>
{
    policy.WithOrigins("http://localhost:3000", "https://localhost:3001").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseCors(Allcors);
    app.UseHttpsRedirection();
    app.UseAuthorization();
}*/
app.UseCors(Allcors);
// app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();