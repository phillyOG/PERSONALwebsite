using PhilsWebsite.Services;
using PhilsWebsite.Interfaces;
using PhilsWebsite.Controllers;

//whitelisted mailgun sending on r h side auth participants verify
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IMailgunSenderEmail, MailgunSenderEmail>();
builder.Services.Configure<AuthorizeMessageSender>(builder.Configuration.GetSection("Mailgun"));
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
