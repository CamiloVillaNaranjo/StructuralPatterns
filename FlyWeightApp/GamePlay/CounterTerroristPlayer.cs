using System;

namespace FlyWeightApp.GamePlay
{
    public class CounterTerroristPlayer : IPalyer
    {
        private string _task;
        private string _weapon;
        public CounterTerroristPlayer()
        {
            _task = "* Disarm an explosive bomb.";
        }
        public string PlayerType() => "Counter Terrorist";
        public void AssingWeapon(string weapon)
        {
            _weapon = weapon;
        }
        public void Missions()
        {
            Console.WriteLine($"The {PlayerType()} with weapon {_weapon} has the following task(s): {_task}");
        }
    }
}
