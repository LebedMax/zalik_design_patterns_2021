using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Zalik
{
    public static class DeliveryServiceSingleton
    {
        private static List<BasePart> _parts = new List<BasePart>();

        private static List<BaseBuilder> _builders = new List<BaseBuilder>();

        public static void OrderSparePartOrService(BasePart part)
        {
            _parts.Add(part);
        }

        public static void OrderVehicle(BaseBuilder builder)
        {
            _builders.Add(builder);
        }

        public static void MakeDelievery()
        {
            foreach (var part in _parts)
            {
                Console.WriteLine($"Spare part {part.PartId} - {part.Description} has shipped to customer");

                Thread.Sleep(500);
            }

            _parts.Clear();

            foreach (var builder in _builders)
            {
                Console.WriteLine($"Vehicle {builder.Name} has shipped to customer");

                Thread.Sleep(500);
            }

            _builders.Clear();
        }
    }
}
