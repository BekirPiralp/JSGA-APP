using Microsoft.Extensions.Configuration;

namespace ApplicationSettings
{
    public class Configuration
    {
        private static Configuration? _configuration;
        private static readonly object _lock = new object();

        public static Configuration create()
        {
            if (_configuration == null)
                lock (_lock)
                {
                    _configuration ??= new Configuration(); //if variable == null, variable = new object
                }

            return _configuration;
        }


        private ConfigurationManager? _configurationManager;

        private Configuration()
        {

        }

        public ConfigurationManager ConfigManager {
            get
            {
                if (_configurationManager == null)
                    throw new NullReferenceException(nameof(_configurationManager));

                return _configurationManager;
            } 
        }

        internal ConfigurationManager ConfigManagerSet{
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));

                _configurationManager = value;
            }
        }

    }
}
