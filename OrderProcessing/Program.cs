using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using OrderProcessing.Models;
using OrderProcessing.Auth.Models;
using log4net;
using log4net.Config;
using Ocelot.Values;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddJwtAuthentication();
builder.Configuration.AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
XmlConfigurator.Configure(new FileInfo("log4net.config"));
builder.Services.AddSingleton(LogManager.GetLogger(typeof(Program)));
var app = builder.Build();
app.UseHttpsRedirection();

var allowedIpAddresses = builder.Configuration.GetSection("AllowedIpAddresses").Get<string[]>();
app.Use((context, next) => new IpWhitelistMiddleware(next, allowedIpAddresses).Invoke(context));
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapGet("/", () => "Hello Customer! Welcome to Order Processing");
await app.UseOcelot();
app.Run();
