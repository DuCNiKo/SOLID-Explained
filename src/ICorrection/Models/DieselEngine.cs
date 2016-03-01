namespace Models
{
    public class DieselEngine : IEngine
    {
        public EngineType EngineType { get; set; }
        public DieselEngine()
        {
            EngineType = EngineType.Diesel;
        }
        public string Needs()
        {
            return "Gasoil";
        }
    }
}
