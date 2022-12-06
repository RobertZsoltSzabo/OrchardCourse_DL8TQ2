using System;
using DL8TQ2_CourseProject.Module.Drivers;
using DL8TQ2_CourseProject.Module.Handlers;
using DL8TQ2_CourseProject.Module.Migrations;
using DL8TQ2_CourseProject.Module.Models;
using Fluid;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;

namespace DL8TQ2_CourseProject.Module
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services
                .AddContentPart<MapPart>()
                .UseDisplayDriver<MapPartDisplayDriver>()
                .AddHandler<MapPartHandler>();
            
            services
                .AddContentPart<FoodItemPart>()
                .UseDisplayDriver<FoodItemPartDisplayDriver>()
                .AddHandler<FoodItemPartHandler>();
			
            services.AddScoped<IDataMigration, FoodItemPartsMigrations>();
            services.AddScoped<IDataMigration, MapPartMigrations>();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "DL8TQ2_CourseProject.Module",
                pattern: "Home/Index",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
