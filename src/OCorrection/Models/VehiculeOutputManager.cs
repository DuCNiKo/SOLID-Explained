namespace Models
{
    using System;

    public class VehiculeOutputManager
    {
        public string MoveBackwardAsHTML(Car car)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            return $"<p>{car.MoveBackward()}</p>";
        }
        public string MoveBackwardAsText(Car car)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            return car.MoveBackward();
        }
        public string MoveForwardAsHTML(Car car)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            return $"<p>{car.MoveForward()}</p>";
        }
        public string MoveForwardAsText(Car car)
        {
            if (car == null) throw new ArgumentNullException(nameof(car));
            return car.MoveForward();
        }
    }
}
