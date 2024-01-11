using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using LeitorNfe.Data;


var builder = WebApplication.CreateBuilder(args);

if (!builder.Environment.IsDevelopment())
{    
    builder.Services.AddDbContext<NotaFiscalContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionNotaFiscalContext")));
}
else
{
    builder.Services.AddDbContext<NotaFiscalContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("NotaFiscalContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));
}


builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseRequestLocalization("pt-BR");


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
     app.UseHsts();
}

app.UseStatusCodePagesWithRedirects("/Error/{0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=NotaFiscal}/{action=Index}/{id?}");

app.Run();
