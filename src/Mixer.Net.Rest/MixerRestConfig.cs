namespace Mixer.Rest
{
    public class MixerRestConfig : MixerConfig
    {
        /// <summary> Gets or sets the provider used to generate new REST connections. </summary>
        public RestClientProvider RestClientProvider { get; set; } = DefaultRestClientProvider.Instance;
    }
}
