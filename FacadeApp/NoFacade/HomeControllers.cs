using System;

namespace FacadeApp.NoFacade
{
    public interface IHomeController
    {
        void TurnOn();
        void TurnOff();
    }

    public class WifiController :IHomeController
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

    public class AirConditionerController: IHomeController
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
