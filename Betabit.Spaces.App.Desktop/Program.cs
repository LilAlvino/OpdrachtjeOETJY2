using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Betabit.Spaces.App.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace Betabit.Spaces.App
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        [ExcludeFromCodeCoverage]
        static async Task Main()
        {
            var services = CreateServiceProvider();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = services.GetService<MainForm>();
            Application.Run(form);
        }

        public static ServiceProvider CreateServiceProvider()
            => new ServiceCollection()
                .AddScoped<MainForm>()
                .AddSingleton<HttpClient>()
                .AddSingleton<IReservationsClient, ReservationsClient>()
                .AddSingleton<ISpacesClient, SpacesClient>()
                .BuildServiceProvider();
    }
}
