using DigitalCursos.Web.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DigitalCursos.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Identity
var connectionString = builder.Configuration.GetConnectionString("DigitalCursosWebContextConnection");
builder.Services.AddDbContext<DigitalCursosWebContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DigitalCursosWebContext>();

builder.Services.AddAuthentication("Identity.Application")
                .AddCookie();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// HttpClient Api Services
builder.Services.AddHttpClient<IAlunoService, AlunoService>(p =>
{
    p.BaseAddress = new Uri(@"https://localhost:7295");
    p.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddHttpClient<ICursoService, CursoService>(p =>
{
    p.BaseAddress = new Uri(@"https://localhost:7295");
    p.DefaultRequestHeaders.Add("Accept", "application/json");
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
