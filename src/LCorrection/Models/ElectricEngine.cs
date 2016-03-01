namespace Models
{
    public class ElectricEngine : IEngine
    {
        public EngineType EngineType { get; set; }
        public ElectricEngine()
        {
            EngineType = EngineType.Electric;
        }
        public string Needs()
        {
            return "Electricity";
        }
    }
}
