using System;

namespace BadSOLID
{
    enum EngineType
    {
        Fuel,
        Diesel,
        Electric
    }
    interface IEngine
    {
        EngineType EngineType { get; }
        string Needs();
    }
    interface IVehicule
    {
        IEngine Engine { get; }
        string MoveForward();
        string MoveBackward();
        string MoveAsText(bool forward);
    }
    class FuelEngine : IEngine
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
    class DieselEngine : IEngine
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
    class ElectricEngine : IEngine
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
    class Car : IVehicule
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
        public string MoveForward()
        {
            return "Car move forward.";
        }
        public string MoveBackward()
        {
            return "Car move backward";
        }
        public string MoveAsText(bool forward)
        {
            return forward ? MoveForward() : MoveBackward();
        }
    }
    class Dragster : Car
    {
        public Dragster()
            : base(EngineType.Fuel)
        {

        }
        new string MoveBackward()
        {
            throw new NotSupportedException();
        }
    }
    class Bike : IVehicule
    {
        public IEngine Engine { get; private set; }
        public Bike(EngineType engineType)
        {
            Engine = new FuelEngine();
        }
        public string MoveForward()
        {
            return "Bike move forward.";
        }
        public string MoveBackward()
        {
            throw new Exception("Bike cannot move backward.");
        }
        public string MoveAsText(bool forward)
        {
            return forward ? MoveForward() : MoveBackward();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car(EngineType.Diesel);
            var bike1 = new Bike(EngineType.Fuel);

            Console.WriteLine(car1.MoveAsText(false));
            Console.WriteLine(bike1.MoveAsText(true));

            Console.ReadLine();
        }
    }
}
