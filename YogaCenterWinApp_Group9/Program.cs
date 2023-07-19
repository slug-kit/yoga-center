using Microsoft.Extensions.Configuration;
using System.Globalization;
using YogaCenter.Repository.Models;

namespace YogaCenterWinApp_Group9;

internal static class Program
{
    public static readonly IConfiguration AppConfig = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();

    internal static User? CurrentUser { get; set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var culture = CultureInfo.GetCultureInfo(AppConfig["Cultures:DefaultCulture"] ?? CultureInfo.CurrentCulture.Name);
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;

        ApplicationConfiguration.Initialize();
        Application.Run(new frmTimetable());
    }
}