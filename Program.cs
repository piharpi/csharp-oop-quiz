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
            Console.WriteLine("TotalVehicleSuv {0}", repoManager.Summary.GetTotalVehicle("Suv"));
            //Console.WriteLine("TotalVehicleTaxi {0}", repoManager.Summary.GetTotalVehicle("Taxi"));
            //Console.WriteLine("TotalVehiclePrivateJet {0}", repoManager.Summary.GetTotalVehicle("PrivateJet"));
            //Console.WriteLine("TotalVehicleAll {0}", repoManager.Summary.GetTotalVehicle());

            //Console.WriteLine("TotalIncomeVehicle Suv : {0}", repoManager.Summary.GetTotalIncomeVehicle("Suv"));
            //Console.WriteLine("TotalIncomeVehicle Taxi : {0}", repoManager.Summary.GetTotalIncomeVehicle("Taxi"));
            //Console.WriteLine("TotalIncomeVehicle PrivateJet : {0}", repoManager.Summary.GetTotalIncomeVehicle("PrivateJet"));
            //Console.WriteLine("TotalIncomeVehicle All : {0}", repoManager.Summary.GetTotalIncomeVehicle());

            //----------------- FindAllSuv ----------------
            //var findAllSuv = repoManager.Suv.FindAll();
            //foreach (var s in findAllSuv)
            //    Console.WriteLine(s);

            //----------------- Create Suv----------------
            //var createSuv = repoManager.Suv.Create(new Suv("P 1999 DK", "2010", 350000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 500_000M, 150_000M));
            //foreach (var suv in createSuv)
            //    Console.WriteLine(suv);

            //----------------- FindById Suv --------------
            //Suv findSuv = repoManager.Suv.FindById("D 1001 UM");
            //Console.WriteLine(findSuv);

            //----------------- Update Suv ----------------
            //var updateSuv = repoManager.Suv.Update("D 1001 UM", new Suv("P 1111 DK", "1999", 990000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 200000M, 150000M));
            //Console.WriteLine(updateSuv);

            //----------------- Delete Suv ----------------
            var deleteSuv = repoManager.Suv.Delete("D 1003 UM");
            //Console.WriteLine($"Deleted Row : {deleteSuv}");


            //----------------- FindAll Taxi ----------------
            //var findAllTaxi = repoManager.Taxi.FindAll();
            //foreach (var tx in findAllTaxi)
            //    Console.WriteLine(tx);

            //----------------- Create Taxi ----------------
            //var createTaxi = repoManager.Taxi.Create(new Taxi("D 99 DK", "2001", 350000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 71, 45000M));
            //foreach (var tx in createTaxi)
            //    Console.WriteLine(tx);

            //----------------- FindById Taxi --------------
            //Taxi findTaxi = repoManager.Taxi.FindById("D 11 UK");
            //Console.WriteLine(findTaxi);

            //----------------- Update Taxi ----------------
            //var updateTaxi = repoManager.Taxi.Update("D 12 UK", new Taxi("D 90 DK", "1999", 990000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 5, 150000M));
            //Console.WriteLine(updateTaxi);

            //----------------- Delete Taxi ----------------
            //var deleteTaxi = repoManager.Taxi.Delete("D 12 UK");
            //Console.WriteLine($"Deleted Row : {deleteTaxi}");


            //----------------- FindAll PrivateJet ----------------
            //var findAllPrivateJet = repoManager.PrivateJet.FindAll();
            //foreach (var jt in findAllPrivateJet)
            //    Console.WriteLine(jt);

            //----------------- Create PrivateJet ----------------
            //var createPrivateJet = repoManager.PrivateJet.Create(new PrivateJet("ID9892", "2001", 350000000M, 3500000M, 20, new DateOnly(2023, 01, 10), 58000000M, 45000000M));
            //foreach (var jt in createPrivateJet)
            //    Console.WriteLine(jt);

            //----------------- FindById PrivateJet --------------
            //PrivateJet findPrivateJet = repoManager.PrivateJet.FindById("ID9892");
            //Console.WriteLine(findPrivateJet);

            //----------------- Update PrivateJet ----------------
            //var updatePrivateJet = repoManager.PrivateJet.Update("ID8099", new PrivateJet("ID9999", "1999", 990000000M, 3500000M, 13, new DateOnly(2023, 01, 10), 5000000M, 150000M));
            //Console.WriteLine(updatePrivateJet);

            //----------------- Delete PrivateJet ----------------
            //var deletePrivateJet = repoManager.PrivateJet.Delete("ID8099");
            //Console.WriteLine($"Deleted Row : {deletePrivateJet}");


            //foreach (var vhc in collection.FetchAll())
            //{
            //    Console.WriteLine(vhc);
            //}

            Console.WriteLine("TotalIncomeVehicle Suv : {0}", repoManager.Summary.GetTotalVehicle("Suv"));
        }
    }
}