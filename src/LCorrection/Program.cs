using System;

namespace LCorrection
{
    enum EngineType
    {
        Fuel,
        Diesel,
        Electric,
        Nitro
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
    static class EngineFactory
    {
        public static IEngine GetEngine(EngineType engineType)
        {
            switch (engineType)
            {
                case EngineType.Diesel:
                    return new DieselEngine();
                case EngineType.Electric:
                    return new ElectricEngine();
                case EngineType.Fuel:
                    return new FuelEngine();
                default:
                    throw new Exception("Engine type not supported.");
            }
        }
    }
    class Car : IVehicule
    {
        public IEngine Engine { get; private set; }
        public Car(EngineType engineType)
        {
            Engine = EngineFactory.GetEngine(engineType);
        }
        public string MoveForward()
        {
            return "Car move forward.";
        }
        public string MoveBackward()
        {
            return "Car move backward";
        }
    }
    class Dragster : IVehicule
    {
        public IEngine Engine { get; private set; }
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
    class Bike : IVehicule
    {
        public IEngine Engine { get; private set; }
        public Bike(EngineType engineType)
        {
            Engine = EngineFactory.GetEngine(engineType);
        }
        public string MoveForward()
        {
            return "Bike move forward.";
        }
        public string MoveBackward()
        {
            throw new Exception("Bike cannot move backward.");
        }
    }
    class VehiculeOutputManager
    {
        public string MoveAsText(Car car, bool forward)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            return forward ? car.MoveForward() : car.MoveBackward();
        }
        public string MoveAsHTML(Car car, bool forward)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            return $"<p>{MoveAsText(car, forward)}</p>";
        }
        public string MoveAsText(Bike bike, bool forward)
        {
            if (bike == null) throw new ArgumentNullException(nameof(bike));
            return forward ? bike.MoveForward() : bike.MoveBackward();
        }
        public string MoveAsHTML(Bike bike, bool forward)
        {
            if (bike == null) throw new ArgumentNullException(nameof(bike));
            return $"<p>{MoveAsText(bike, forward)}</p>";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var outputManager = new VehiculeOutputManager();
            var car1 = new Car(EngineType.Electric);
            var bike1 = new Bike(EngineType.Fuel);

            Console.WriteLine(outputManager.MoveAsHTML(car1, false));
            Console.WriteLine(outputManager.MoveAsText(bike1, true));

            Console.ReadLine();
        }
    }
}
