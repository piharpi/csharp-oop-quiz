using JuraganMobil.Base;
using JuraganMobil.Collection;
using JuraganMobil.Model;
using System.Data;
using System.Runtime.InteropServices;

namespace JuraganMobil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new VehicleCollection();
            var repoManager = new RepositoryManager(collection);

            //---------------- Summary -----------------
            //Console.WriteLine("TotalVehicleSuv {0}", repoManager.Summary.GetTotalVehicle("Suv"));
            //Console.WriteLine("TotalVehicleTaxi {0}", repoManager.Summary.GetTotalVehicle("Taxi"));
            //Console.WriteLine("TotalVehiclePrivateJet {0}", repoManager.Summary.GetTotalVehicle("PrivateJet"));
            //Console.WriteLine("TotalVehicleAll {0}", repoManager.Summary.GetTotalVehicle());

            //Console.WriteLine("TotalIncomeVehicle Suv : {0}", repoManager.Summary.GetTotalIncomeVehicle("Suv"));
            //Console.WriteLine("TotalIncomeVehicle Taxi : {0}", repoManager.Summary.GetTotalIncomeVehicle("Taxi"));
            //Console.WriteLine("TotalIncomeVehicle PrivateJet : {0}", repoManager.Summary.GetTotalIncomeVehicle("PrivateJet"));
            //Console.WriteLine("TotalIncomeVehicle All : {0}", repoManager.Summary.GetTotalIncomeVehicle());

            //----------------- FindAllSuv ----------------
            //var findAllSuv = repoManager.Suv.FindAllSuv();
            //foreach (var s in findAllSuv)
            //    Console.WriteLine(s);

            //----------------- Create ----------------
            //var createSuv = repoManager.Suv.Create(new Suv("P 1999 DK", "2010", 350000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M));
            //foreach (var suv in createSuv)
            //    Console.WriteLine(suv);

            //----------------- FindById --------------
            //BaseVehicle findSuv = repoManager.Suv.FindById("D 1001 UM");
            //Console.WriteLine(findSuv);

            //----------------- Update ----------------
            //var updateSuv = repoManager.Suv.Update("D 1003 UM", new Suv("P 1111 DK", "1999", 350000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M));
            //Console.WriteLine(updateSuv);

            //----------------- Delete ----------------
            //var deleteSuv = repoManager.Suv.Delete("D 1003 UM");
            //Console.WriteLine($"Deleted Row : {deleteSuv}");


            //foreach (var vhc in collection.FetchAll())
            //{
            //    Console.WriteLine(vhc);
            //}



        }
    }
}