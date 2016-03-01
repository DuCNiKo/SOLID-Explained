namespace OCorrection
{
    using Models;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var outputManager = new VehiculeOutputManager();
            var car1 = new Car(EngineType.Electric);
            var dragster1 = new Dragster();

            Console.WriteLine(outputManager.MoveBackwardAsHTML(car1));
            Console.WriteLine(outputManager.MoveForwardAsText(dragster1));

            Console.ReadLine();
        }
    }
}
