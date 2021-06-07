namespace Zalik
{
    public abstract class BasePart
    {
        public abstract int PartId { get;  }

        public abstract string Description { get; }

        public string GetInfo()
        {
            return $"Part {PartId} - '{Description}'";
        }
    }
}
