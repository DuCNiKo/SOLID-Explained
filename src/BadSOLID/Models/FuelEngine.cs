namespace Models
{
    public class FuelEngine : IEngine
    {
        public EngineType EngineType { get; set; }
        public FuelEngine()
        {
            EngineType = EngineType.Fuel;
        }
        public string Needs()
        {
            return "Fuel";
        }
    }
}
