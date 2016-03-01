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
        public string MoveBackwardAsHTML(Dragster dragster)
        {
            if (dragster == null) throw new ArgumentNullException(nameof(dragster));
            return $"<p>{dragster.MoveBackward()}</p>";
        }
        public string MoveBackwardAsText(Dragster dragster)
        {
            if (dragster == null) throw new ArgumentNullException(nameof(dragster));
            return dragster.MoveBackward();
        }
        public string MoveForwardAsHTML(Dragster dragster)
        {
            if (dragster == null) throw new ArgumentNullException(nameof(dragster));
            return $"<p>{dragster.MoveForward()}</p>";
        }
        public string MoveForwardAsText(Dragster dragster)
        {
            if (dragster == null) throw new ArgumentNullException(nameof(dragster));
            return dragster.MoveForward();
        }
    }
}
