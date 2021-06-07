namespace Zalik.Prototypes
{
    public class VehiclePrototype : BasePrototype
    {
        private int _maxDefectRate;

        public VehiclePrototype(int maxDefectRate)
            :base(maxDefectRate)
        {
            _maxDefectRate = maxDefectRate;
        }

        public override BasePrototype Clone()
        {
            return new VehiclePrototype(_maxDefectRate);
        }
    }
}
