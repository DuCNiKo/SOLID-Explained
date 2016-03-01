using System;

namespace DCorrection
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
    }
    interface ICanGoForward : IVehicule
    {
        string MoveForward();
    }
    interface ICanGoBackward : IVehicule
    {
        string MoveBackward();
    }
    class FuelEngine : IEngine
    {
        public EngineType EngineType { get { return EngineType.Fuel; } }
        public string Needs()
        {
            return "Fuel";
        }
    }
    class DieselEngine : IEngine
    {
        public EngineType EngineType { get { return EngineType.Diesel; } }
        public string Needs()
        {
            return "Gasoil";
        }
    }
    class ElectricEngine : IEngine
    {
        public EngineType EngineType { get { return EngineType.Electric; } }
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
    class Car : IVehicule, ICanGoBackward, ICanGoForward
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
    class Dragster : IVehicule, ICanGoForward
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
    }
    class Bike : IVehicule, ICanGoForward
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
    }
    class VehiculeOutputManager
    {
        public string MoveAsText(IVehicule vehicule, bool forward)
        {
            if (vehicule == null) throw new ArgumentNullException(nameof(vehicule));
            if (forward)
            {
                var forwardVehicule = vehicule as ICanGoForward;
                if (forwardVehicule == null) throw new Exception("Vehicule can not go forward.");
                return forwardVehicule.MoveForward();
            }
            else
            {
                var backwardVehicule = vehicule as ICanGoBackward;
                if (backwardVehicule == null) throw new Exception("Vehicule can not go backward.");
                return backwardVehicule.MoveBackward();
            }
        }
        public string MoveAsHTML(IVehicule vehicule, bool forward)
        {
            if (vehicule == null) throw new ArgumentNullException(nameof(vehicule));
            return $"<p>{MoveAsText(vehicule, forward)}</p>";
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
