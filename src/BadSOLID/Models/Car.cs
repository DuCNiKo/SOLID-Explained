namespace Models
{
    public class Car : IVehicule
    {
        public IEngine Engine { get; private set; }
        public Car(EngineType engineType)
        {
            switch (engineType)
            {
                case EngineType.Diesel:
                    Engine = new DieselEngine();
                    break;
                case EngineType.Fuel:
                    Engine = new FuelEngine();
                    break;
            }
        }
        public virtual string MoveForward()
        {
            return "Car move forward.";
        }
        public virtual string MoveBackward()
        {
            return "Car move backward";
        }
        public string MoveAsText(bool forward)
        {
            return forward ? MoveForward() : MoveBackward();
        }
    }
}
