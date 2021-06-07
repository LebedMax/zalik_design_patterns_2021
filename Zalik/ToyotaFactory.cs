using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Zalik.Parts;
using Zalik.Prototypes;

namespace Zalik
{
    public class ToyotaFactory : BaseFactory
    {
        private List<BasePart> _separateParts = new List<BasePart>();

        private BasePrototype _prototype = new VehiclePrototype(8);

        public ToyotaFactory()
        {
            _separateParts.Add(new ElectroEngine());
            _separateParts.Add(new PetrolEngine());
            _separateParts.Add(new Frame());
            _separateParts.Add(new MetalSource());
            _separateParts.Add(new RawVehicle());
            _separateParts.Add(new TestServiceForVehicle());
        }

        public override BasePart CreatePart(int partId)
        {
            var result = _separateParts.FirstOrDefault(t => t.PartId == partId);

            if (result == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine("No parts found by Id - " + partId);
                
                Console.ResetColor();
                
                Thread.Sleep(1500);

                throw new ArgumentException();

            }

            Console.WriteLine($"Ordered part number {result.PartId} - {result.Description}");

            return result;
        }

        public override BaseBuilder CreateVehicle2020()
        {
            var defectRateStandartPrototype = _prototype.Clone();

            var v = new ToyotaCamryBuilder();

            var defect = v.DefectRate;

            v.StartBuild();

            v.ShowResult();

            if (defect > defectRateStandartPrototype.MaxDefectRate)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"Created model 2020 - Toyota Camry. Rate: {defect} / {defectRateStandartPrototype.MaxDefectRate}");

            Console.ResetColor();

            return v;
        }

        public override BaseBuilder CreateVehicle2021()
        {
            var defectRateStandartPrototype = _prototype.Clone();

            var v = new ToyotaPriusBuilder();

            var defect = v.DefectRate;

            v.StartBuild();

            v.ShowResult();

            if (defect > defectRateStandartPrototype.MaxDefectRate)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"Created model 2021 - Toyota Prius. Rate: {defect} / {defectRateStandartPrototype.MaxDefectRate}");

            Console.ResetColor();

            return v;
        }
    }
}
