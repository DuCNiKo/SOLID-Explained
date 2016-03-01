namespace Models
{
    using System;

    public static class EngineFactory
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
}
