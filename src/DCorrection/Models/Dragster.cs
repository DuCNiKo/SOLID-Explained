namespace Models
{
    public class Dragster : IVehicule, ICanGoForward
    {
        public IEngine Engine { get; set; }
        public Dragster()
        {
            Engine = EngineFactory.GetEngine(EngineType.Fuel);
        }
        public string MoveForward()
        {
            return "Dragster move forward.";
        }
    }
}
