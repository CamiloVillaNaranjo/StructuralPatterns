using System;

namespace FacadeApp.FacadeMode
{
    public interface IHomeController
    {
        void TurnOn();
        void TurnOff();
    }

    public class HomeController : IHomeController
    {
        WifiController wifiController = new WifiController();
        AirConditionerController airController = new AirConditionerController();
        LightController lightController = new LightController();

        public void TurnOn()
        {
            wifiController.TurnOn();
            airController.TurnOn();
            lightController.TurnOn();
        }
        public void TurnOff()
        {
            wifiController.TurnOff();
            airController.TurnOff();
            lightController.TurnOff();
        }
    }

    public class WifiController : IHomeController
    {
        public void TurnOn()
        {
            Console.WriteLine("Wifi Routter is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Wifi Routter is off");
        }
    }

    public class AirConditionerController : IHomeController
    {
        public void TurnOn()
        {
            Console.WriteLine("Air conditioner is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Air conditioner is off");
        }
    }

    public class LightController : IHomeController
    {
        public void TurnOn()
        {
            Console.WriteLine("Lights on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Lights off");
        }
    }
}
