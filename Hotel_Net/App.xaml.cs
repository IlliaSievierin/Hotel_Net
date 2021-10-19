using Hotel.BLL.Interfaces;
using Hotel.BLL.Services;
using Hotel.DAL.EF;
using Hotel.DAL.Interfaces;
using Hotel.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel_Net
{

    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HotelContext>(options =>
                    options.UseSqlServer("data source=DESKTOP-IA97AVE;initial catalog=Hotel_Net;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"));

            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IPriceCategoryService, PriceCategoryService>();
            services.AddTransient<IReservationService, ReservationService>();
            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<IWorkUnit, EFWorkUnit>();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow(serviceProvider.GetService<ICustomerService>(),
                serviceProvider.GetService<ICategoryService>(),
                serviceProvider.GetService<IPriceCategoryService>(),
                serviceProvider.GetService<IReservationService>(),
                serviceProvider.GetService<IRoomService>());


            mainWindow.Show();
        }

    }

}
