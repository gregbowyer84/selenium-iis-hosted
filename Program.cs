using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x=>x.IgnoreObsoleteActions());

builder.Services.AddTransient<IWebDriver>(s =>
{
    ChromeOptions options = new ChromeOptions();
    options.AddArgument($@"load-extension={Path.Combine(builder.Environment.ContentRootPath, "extensions\\CapSolver.Browser.Extension")}");
    return new ChromeDriver(options);
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseDeveloperExceptionPage();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
