namespace Models
{
    public class Car : IVehicule, ICanGoBackward, ICanGoForward
    {
        public IEngine Engine { get; private set; }
        public Car(EngineType engineType)
        {
            Engine = EngineFactory.GetEngine(engineType);
        }
        public virtual string MoveForward()
        {
            return "Car move forward.";
        }
        public virtual string MoveBackward()
        {
            return "Car move backward";
        }
    }
}
