namespace Zalik.Prototypes
{
    public abstract class BasePrototype
    {
        private readonly int _maxDefectRate;

        public BasePrototype(int maxDefectRate)
        {
            _maxDefectRate = maxDefectRate;
        }

        public abstract BasePrototype Clone();

        public int MaxDefectRate => _maxDefectRate;
    }
}
