using System;
using System.Linq;
using System.Collections.Generic;

namespace Vehicles
{
    public class Program
    {
        public static void Main() {

            // Build a collection of all vehicles that fly
            List <IAirBased> airVehicles = new List <IAirBased>();
            var Cessna172Skyhawk = new Cessna ("Cessna 172 Skyhawk", 4, 150.0, 50.0, 141.0);
            var Freedom150HangGlider = new HangGlider ("Freedom 150", 1, 0.0, 90.0);
            var Bell429 = new Helicopter ("Bell 429", 4, 8, "idn", 217.0, 172.7);
            airVehicles.Add(Cessna172Skyhawk);
            airVehicles.Add(Freedom150HangGlider);
            airVehicles.Add(Bell429);

            // With a single `foreach`, have each vehicle Fly()
            Console.WriteLine();
            foreach (IAirBased vehicle in airVehicles) {
                vehicle.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            List <IGroundBased> landVehicles = new List <IGroundBased>();
            var Trek = new Bicycle ("Trek", 1, 45);
            var Harley = new Motorcycle ("Harley Davidson Street 500", 1, "5-speed", 30.0, 342.8);
            var HondaOdyssey = new SoccerMomVan ("Honday Odyssey", 4, 5, 8, 120, "6-Speed Automatic", 1.5);
            landVehicles.Add(Trek);
            landVehicles.Add(Harley);
            landVehicles.Add(HondaOdyssey);

            // With a single `foreach`, have each road vehicle Drive()
            Console.WriteLine();
            foreach (IGroundBased vehicle in landVehicles) {
                vehicle.Drive();
            }

            // Build a collection of all vehicles that operate on water
            List <IWaterBased> waterVehicles = new List <IWaterBased>();
            var YamahaEXJetSKi = new JetSki ("Yamaha EX", 2, 1049.0, 65);
            var EmotionGuster10Kayak = new Kayak ("Emotion Guster 10", 1);
            waterVehicles.Add(YamahaEXJetSKi);
            waterVehicles.Add(EmotionGuster10Kayak);
            
            // With a single `foreach`, have each water vehicle Drive()
            Console.WriteLine();
            foreach (IWaterBased vehicle in waterVehicles) {
                vehicle.Drive();
            }
        }

    }
}
