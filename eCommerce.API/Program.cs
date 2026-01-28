using eCommerce.infrastructure;
using eCommerce.Core;
using eCommerce.API.Middlewares;
using System.Text.Json.Serialization;
using eCommerce.Core.Mappers;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructure();
builder.Services.AddCore();

//Add  controllers to service collection
builder.Services.AddControllers().AddJsonOptions(options=>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);

//Fluent Validations
builder.Services.AddFluentValidationAutoValidation();

//Build the web application
var app = builder.Build();

app.UseExceptionHandlingMiddleware();

//Routing
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//Comtroller routes
app.MapControllers();

app.Run();
