using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Program
    {
        public static int Main()
        {

            var builder = WebApplication.CreateBuilder();
            // Help us to creating Object for this controller
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            // Handling Routing for App 
            app.MapControllerRoute("", "{controller}/{action}");
            app.Run();
            return 0;
        }
    }
}
