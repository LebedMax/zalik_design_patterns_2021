namespace Zalik
{
    public abstract class BaseBuilder
    {
        public abstract void PrepareSource();

        public abstract void CreateFrame();

        public abstract void BuildVehicle();

        public abstract void TestVehicle();

        public abstract void ShowResult();

        public abstract int DefectRate { get; }

        public abstract string Name { get; }

        public void StartBuild()
        {
            PrepareSource();

            CreateFrame();

            BuildVehicle();

            TestVehicle();
        }
    }
}
