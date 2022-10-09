// using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.Configure<ForwardedHeadersOptions>(options =>
// {
//     options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
// });
var app = builder.Build();

// app.UseForwardedHeaders();

app.MapGet("/", () => $"Hello World! / says the time is {DateTime.Now}");
app.MapGet("/{*path}", (string path) => $"Hello World! {path} says the time is {DateTime.Now}");

app.Run();
