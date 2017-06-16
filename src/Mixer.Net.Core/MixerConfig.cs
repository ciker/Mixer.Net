using System.Reflection;

namespace Mixer
{
    public class MixerConfig
    {
        public static string Version { get; } =
            typeof(MixerConfig).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ??
            typeof(MixerConfig).GetTypeInfo().Assembly.GetName().Version.ToString(3) ??
            "Unknown";

        public static string UserAgent { get; } = $"MixerNetApp (https://github.com/Aux/Mixer.Net, v{Version})";
        public static readonly string DefaultApiUrl = $"https://mixer.com/api/v{ApiVersion}";

        public const int ApiVersion = 1;
        public const int DefaultRequestTimeout = 15000;
        
        /// <summary> Gets or sets the minimum log level severity that will be sent to the Log event. </summary>
        public LogSeverity LogLevel { get; set; } = LogSeverity.Info;
    }
}
