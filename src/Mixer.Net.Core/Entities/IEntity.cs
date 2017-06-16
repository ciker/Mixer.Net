namespace Mixer
{
    public interface IEntity<T>
    {
        IMixerClient Client { get; }
        T Id { get; }
    }
}
