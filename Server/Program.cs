using Microsoft.AspNetCore.ResponseCompression;
using Server.Repository;


namespace Server
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddControllers();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("policy",
                                  policy =>
                                  {
                                      policy.AllowAnyOrigin();
                                  });
            });

            builder.Services.AddSingleton<IShelterRepo, IShelterMongo>();

            var app = builder.Build();

           
            app.UseHttpsRedirection();

            app.UseCors("policy");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();


        }
    }
}