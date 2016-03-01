namespace Models
{
    public interface IEngine
    {
        EngineType EngineType { get; }
        string Needs();
    }
}
