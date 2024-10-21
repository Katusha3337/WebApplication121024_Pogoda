using WebApplication121024_Pogoda.Servises;

var builder = WebApplication.CreateBuilder(args);

// ������������ WeatherService
builder.Services.AddSingleton<IWeatherService, WeatherService>();

// ��������� ����������� � ���������������
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ���������� ����������� �����
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

