using System;

namespace FacadeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //NoFacadeMode();
            FacadeMode();
        }   
        
        static void NoFacadeMode()
        {
            var wifiController = new NoFacade.WifiController();
            var airController = new NoFacade.AirConditionerController();
            var lightController = new NoFacade.LightController();
            Console.WriteLine("Arriving home...");
            wifiController.TurnOn();
            airController.TurnOn();
            lightController.TurnOn();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Leaving home...");
            wifiController.TurnOff();
            airController.TurnOff();
            lightController.TurnOff();
            Console.ReadLine();
        }

        static void FacadeMode()
        {
            var homeController = new FacadeMode.HomeController();
            Console.WriteLine("Arriving home...");
            homeController.TurnOn();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Leaving home...");
            homeController.TurnOff();
            Console.ReadLine();
        }
    }
}
