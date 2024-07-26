
using Microsoft.EntityFrameworkCore;
using ProductManagementAPI.Models.Data;
using ProductManagementAPI.Repository;
using ProductManagementAPI.Services;

namespace ProductManagementAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txt = "hello ";
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>(op=>
            op.UseSqlServer(builder.Configuration.GetConnectionString("constr")));

            // Register Services and Repositories
            builder.Services.AddScoped<IProductRepository,ProductRepository>();
            builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(txt,
                builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors(txt);

            app.MapControllers();

            app.Run();
        }
    }
}
