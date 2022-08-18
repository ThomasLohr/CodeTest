using Softwarehouse.Repositorys;
using Softwarehouse.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<ProductRepository>();
builder.Services.AddSingleton<CustomerService>();
builder.Services.AddSingleton<CustomerRepository>();
builder.Services.AddSingleton<ShoppingCartRepository>();
builder.Services.AddSingleton<ShoppingCartService>();

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
