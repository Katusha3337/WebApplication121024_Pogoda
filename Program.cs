using WebApplication121024_Pogoda.Servises;

var builder = WebApplication.CreateBuilder(args);

// Регистрируем WeatherService
builder.Services.AddSingleton<IWeatherService, WeatherService>();

// Добавляем контроллеры с представлениями
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Используем статические файлы
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

