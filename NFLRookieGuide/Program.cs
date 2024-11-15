using NFLRookieGuide.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using NFLRookieGuide.Components.Account;
using NFLRookieGuide.Context;
using NFLRookieGuide.Model;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();


builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ApplicationScheme;
})
.AddIdentityCookies();

builder.Services.AddDbContext<DatabaseContext>();

builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<DatabaseContext>()
    .AddSignInManager();

builder.Services.AddHttpClient<HttpClient>();
builder.Services.AddHttpClient<HttpClient>("Proxy")
    .ConfigurePrimaryHttpMessageHandler(options =>
    {
        return new HttpClientHandler
        {
            UseProxy = true,
            Proxy = new WebProxy
            {
                Address = new Uri("http://smoothwall:8080/"),
                BypassProxyOnLocal = false,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential
                {
                    UserName = $"learning\\garcj143.212",
                    Password = $"1122334455fL"
                }
            }

        };
    });


builder.Services.AddScoped<DatabaseSeeder>();
builder.Services.AddScoped<PlayerProvider>();
builder.Services.AddScoped<TeamProvider>();
builder.Services.AddScoped<PlayProvider>();
builder.Services.AddScoped<PositionProvider>();
builder.Services.AddScoped<RosterPlayProvider>();


var app = builder.Build();
{
    using var scope = app.Services.CreateScope();
    var seeder = scope.ServiceProvider.GetService<DatabaseSeeder>();
    await seeder!.Seed();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalAccountRoutes();

app.Run();
