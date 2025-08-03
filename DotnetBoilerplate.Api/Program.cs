using DotnetBoilerplate.Infra.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

/* Put your database options here, e.g., using SQL Server
 builder.Services.AddDbContext<BoilerplateContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); */
builder.Services.AddDbContext<BoilerplateContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.UseHttpsRedirection();
app.MapControllers();
app.Run();