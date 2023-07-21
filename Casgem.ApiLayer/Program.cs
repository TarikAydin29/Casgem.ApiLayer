using Casgem.BLL.Abstract;
using Casgem.BLL.Concrete;
using Casgem.DAL.Abstract;
using Casgem.DAL.Concrete;
using Casgem.DAL.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDAL, EFProductDAL>();
builder.Services.AddScoped<ICustomerDAL, EFCustomerDAL>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();

builder.Services.AddDbContext<Context>();

builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

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
