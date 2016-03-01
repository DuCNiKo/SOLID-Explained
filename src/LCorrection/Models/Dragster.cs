namespace Models
{
    using System;

    public class Dragster : IVehicule
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
        public string MoveBackward()
        {
            throw new NotSupportedException();
        }
    }
}
