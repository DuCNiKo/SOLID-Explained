namespace Models
{
    using System;

    public class VehiculeOutputManager
    {
        public string MoveBackwardAsHTML(ICanGoBackward vehicule)
        {
            if (vehicule == null) throw new ArgumentNullException(nameof(vehicule));
            return $"<p>{vehicule.MoveBackward()}</p>";
        }
        public string MoveBackwardAsText(ICanGoBackward vehicule)
        {
            if (vehicule == null) throw new ArgumentNullException(nameof(vehicule));
            return vehicule.MoveBackward();
        }
        public string MoveForwardAsHTML(ICanGoForward vehicule)
        {
            if (vehicule == null) throw new ArgumentNullException(nameof(vehicule));
            return $"<p>{vehicule.MoveForward()}</p>";
        }
        public string MoveForwardAsText(ICanGoForward vehicule)
        {
            if (vehicule == null) throw new ArgumentNullException(nameof(vehicule));
            return vehicule.MoveForward();
        }
    }
}
