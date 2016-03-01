namespace BadSOLID
{
    using Models;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car(EngineType.Diesel);
            var dragster1 = new Dragster();

            Console.WriteLine(car1.MoveAsText(false));
            Console.WriteLine(dragster1.MoveAsText(true));

            Console.ReadLine();
        }
    }
}
