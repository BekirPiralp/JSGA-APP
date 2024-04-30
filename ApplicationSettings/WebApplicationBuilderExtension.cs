using Microsoft.AspNetCore.Builder;

namespace ApplicationSettings
{
    public static class WebApplicationBuilderExtension
    {
        public static void AppSettingsConfigure(this WebApplicationBuilder builder)
        {
            if(builder == null)
                throw new ArgumentNullException(nameof(builder));
            Configuration.create().ConfigManagerSet = builder.Configuration;
        }
    }
}
