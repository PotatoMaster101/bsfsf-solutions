using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Section08;
using Section08.DataAccess;
using Section08.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);
var conStr = builder.Configuration.GetConnectionString("AppDbConnection");
builder.WebHost.UseWebRoot("wwwroot");
builder.WebHost.UseStaticWebAssets();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<AppDbContext>(o => o.UseNpgsql(conStr));
builder.Services.AddScoped<IUserRepository, UserRepository>();

// auto mapper config
var mapperConfig = new MapperConfiguration(x => x.AddProfile(new MappingProfile()));
builder.Services.AddSingleton(mapperConfig.CreateMapper());

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

// apply DB migrations
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await dbContext.Database.MigrateAsync().ConfigureAwait(false);
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
