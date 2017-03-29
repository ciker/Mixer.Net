using System.Reflection;

namespace Beam
{
    public class BeamConfig
    {
        public static string Version { get; } =
            typeof(BeamConfig).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ??
            typeof(BeamConfig).GetTypeInfo().Assembly.GetName().Version.ToString(3) ??
            "Unknown";
        public static string UserAgent { get; } = $"BeamNetApp (https://github.com/Aux/Beam.Net, v{Version})";

        public LogLevel LogLevel { get; set; } = LogLevel.Info;
    }
}
