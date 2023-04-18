var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(Options =>
    {
        Options.AddPolicy("AllowSpecificOrigin",
            builder => builder.WithOrigins("http://zealand.dk").AllowAnyMethod().AllowAnyHeader());

        Options.AddPolicy("AllowAny",
            builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

        Options.AddPolicy("AllowOnlyGetPut",
            builder => builder.AllowAnyOrigin().WithMethods("Get", "Put").AllowAnyHeader());
    }
    );
    
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

//Cors
app.UseCors("AllowOnlyGetPut");

app.MapControllers();

app.Run();
