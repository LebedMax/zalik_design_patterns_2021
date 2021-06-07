namespace Zalik
{
    public abstract class BaseFactory
    {
        public abstract BasePart CreatePart(int partId);

        public abstract BaseBuilder CreateVehicle2020();

        public abstract BaseBuilder CreateVehicle2021();
    }
}
