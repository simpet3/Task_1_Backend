using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Task_1_Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://localhost:50229/")
                .Build();
    }
}