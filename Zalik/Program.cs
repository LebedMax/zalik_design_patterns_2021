using System;
using System.Collections.Generic;
using System.Threading;

namespace Zalik
{
    class Program
    {
        private static BaseFactory _toyotaFactory = new ToyotaFactory();

        private static List<BasePart> _parts = new List<BasePart>();

        private static List<BaseBuilder> _builders = new List<BaseBuilder>();

        static void Main()
        {
            var result = "";

            while (result != "0")
            {
                result = Execution();
            }

        }

        public static string Execution()
        {
            ShowMenu();

            var choose = Console.ReadLine();

            switch (choose)
            {
                case "1":

                    try
                    {
                        _parts.Add(_toyotaFactory.CreatePart(ReadPartNumber()));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong part number. ");

                        Thread.Sleep(1000);

                        Execution();
                    }

                    Thread.Sleep(1000);

                    Execution();
                    
                    break;
                case "2":
                    _builders.Add(_toyotaFactory.CreateVehicle2020());

                    Console.WriteLine("<Enter> to continue");

                    Console.ReadLine();

                    Execution();
                    break;
                case "3":
                    _builders.Add(_toyotaFactory.CreateVehicle2021());

                    Console.WriteLine("<Enter> to continue");

                    Console.ReadLine();

                    Execution();
                    break;
                case "4":
                    MakeDelievery();

                    Thread.Sleep(1000);

                    break;
                case "5":
                    return "0";
                default:
                    Console.WriteLine("Wrong number, try again: ");

                    Thread.Sleep(2000);

                    Execution();

                    break;
            }

            return "0";
        }

        private static void MakeDelievery()
        {
            foreach (var part in _parts)
            {
                DeliveryServiceSingleton.OrderSparePartOrService(part);
            }

            foreach (var builder in _builders)
            {
                DeliveryServiceSingleton.OrderVehicle(builder);
            }

            DeliveryServiceSingleton.MakeDelievery();
        }

        public static int ReadPartNumber()
        {
            Console.Write("Write part number: ");

            return int.Parse(Console.ReadLine());
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("**********Vehicle Catalog********************");
            Console.WriteLine("1. Order spare part or service");
            Console.WriteLine("2. Order Toyota Camry");
            Console.WriteLine("3. Order Toyota Prius");
            Console.WriteLine("4. Make delievery");
            Console.WriteLine("5. Exit");
        }
    }
}
