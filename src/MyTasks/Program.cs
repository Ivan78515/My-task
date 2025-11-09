using DataAccess;
using BusinesLogica;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataAccess();
builder.Services.AddBusinesLogica();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
