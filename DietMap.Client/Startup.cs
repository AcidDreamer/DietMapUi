using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using MatBlazor;

namespace DietMap.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMatToaster(config =>
                {
                    config.Position = MatToastPosition.TopRight;
                    config.PreventDuplicates = true;
                    config.NewestOnTop = true;
                    config.ShowCloseButton = true;
                    config.MaximumOpacity = 95;
                    config.VisibleStateDuration = 3000;
                });
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
