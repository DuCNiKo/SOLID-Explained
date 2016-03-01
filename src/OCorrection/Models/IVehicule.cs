namespace Models
{
    public interface IVehicule
    {
        IEngine Engine { get; }
        string MoveForward();
        string MoveBackward();
    }
}
