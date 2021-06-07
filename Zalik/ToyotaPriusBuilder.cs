using System;
using System.Collections.Generic;
using Zalik.Parts;

namespace Zalik
{
    public class ToyotaPriusBuilder : BaseBuilder
    {
        private List<BasePart> _partsList = new List<BasePart>();

        public override int DefectRate => new Random().Next(0, 10);

        public override string Name => "Toyota Prius";

        public override void BuildVehicle()
        {
            _partsList.Add(new RawVehicle());

            _partsList.Add(new ElectroEngine());
        }

        public override void CreateFrame()
        {
            _partsList.Add(new Frame());
        }

        public override void PrepareSource()
        {
            _partsList.Add(new MetalSource());
        }

        public override void ShowResult()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Result of Toyota Prius builder:");

            foreach (var item in _partsList)
            {
                Console.WriteLine(item.GetInfo());
            }

            Console.ResetColor();
        }

        public override void TestVehicle()
        {
            _partsList.Add(new TestServiceForVehicle());
        }
    }
}
