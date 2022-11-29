using Confab.Modules.Conferences.Api;
using Confab.Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddInfrastructure();
services.AddConferences();

var app = builder.Build();

app.UseInfrastructure();

app.Run();