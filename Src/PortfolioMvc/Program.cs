using KissLog.AspNetCore;
using KissLog.CloudListeners.Auth;
using KissLog.CloudListeners.RequestLogsListener;
using KissLog.Formatters;
using PortfolioMvc;
using PortfolioMvc.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddLogging(provider =>
{
    provider
        .AddKissLog(options =>
        {
            options.Formatter = (FormatterArgs args) =>
            {
                if (args.Exception == null)
                    return args.DefaultValue;

                string exceptionStr = new ExceptionFormatter().Format(args.Exception, args.Logger);
                return string.Join(Environment.NewLine, new[] { args.DefaultValue, exceptionStr });
            };
        });
});
builder.Services.AddHttpContextAccessor();
// Adiciona servi�os no container DI
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IProjetosService, ProjetosService>();
builder.Services.AddTransient<IEmailService, EmailService>();

builder.Services.Configure<Settings>(builder.Configuration);
var settings = builder.Configuration.Get<Settings>();
builder.Services.AddSingleton(settings);

var app = builder.Build();

// Configura o pipeline do request HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseKissLogMiddleware(options => {
    options.Listeners.Add(new RequestLogsApiListener(new Application(
       settings.KissLog.OrganizationId,
        settings.KissLog.ApplicationId)
    )
    {
        ApiUrl = settings.KissLog.ApiUrl
    });;
});

app.Run();
