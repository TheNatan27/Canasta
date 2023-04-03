using CanastaWebsite.Core.Controllers;
using Fluid;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace CanastaWebsite.Core
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "CanastaWebsite.Core",
                pattern: "Home/Index",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapAreaControllerRoute(
                name: "ResultController",
                areaName: "CanastaWebsite.Core",
                pattern: "Result/Display/{runSummaryID}",
                defaults: new { controller = "Result", action = "Display" }
            );
            routes.MapAreaControllerRoute(
                name: "GalleryController",
                areaName: "CanastaWebsite.Core",
                pattern: "Gallery/Display",
                defaults: new { controller = "Gallery", action = "Display" }
            );
        }
    }
}
