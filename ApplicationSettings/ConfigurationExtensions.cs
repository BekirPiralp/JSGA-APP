using Microsoft.Extensions.Configuration;

namespace ApplicationSettings
{
    public static class ConfigurationExtensions
    {
        public static string? GetSQLCompatibilityString(this IConfiguration configuration, string name)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            // int[] b = {1,2,3}; var c = b?[0]; olduğunda c => null olabilir fakat var c = b?[0]; null olamaz
            return configuration.GetSection("SQLCompatibility")?[name];
        }
    }

}
