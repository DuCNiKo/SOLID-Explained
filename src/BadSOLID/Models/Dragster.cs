namespace Models
{
    using System;

    public class Dragster : Car
    {
        public Dragster()
            : base(EngineType.Fuel)
        {

        }
        public override string MoveBackward()
        {
            throw new NotSupportedException();
        }
    }
}
