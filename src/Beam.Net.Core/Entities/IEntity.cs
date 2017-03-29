namespace Beam
{
    public interface IEntity<T>
    {
        IBeamClient Client { get; }
        T Id { get; }
    }
}
