using Microsoft.EntityFrameworkCore;
using Exemplo.Business.Models;
using Exemplo.Data.Context;
using Exemplo.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddRedisConfig(configuration);

builder.Services.AddIdentityConfiguration(configuration);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.WebApiConfig();

builder.Services.AddSwaggerConfig();

builder.Services.AddHttpContextAccessor();

builder.Services.ResolveDependencies();

builder.Services.AddDbContext<ExemploDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ExemploDbContext"));
});

var emailConfig = builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
builder.Services.AddSingleton(emailConfig);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ServisApi v1"));
    app.UseCors("Development");
}
//else
//{
//    app.UseDeveloperExceptionPage();
//    app.UseSwagger();
//    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ServisApi v1"));
//    app.UseCors("Staging");
//}

app.UseAuthentication();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.UseIdentityConfiguration();

app.Run();