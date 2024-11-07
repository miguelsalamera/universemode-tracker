using UniverseModeTracker.API.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGeneralServices(builder.Configuration);
builder.Services.AddApplicationServices();

var app = builder.Build();

app.UseMiddlewares(app.Environment);

app.Run();