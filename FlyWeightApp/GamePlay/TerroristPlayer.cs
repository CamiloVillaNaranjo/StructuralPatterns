using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightApp.GamePlay
{
    public class TerroristPlayer : IPalyer
    {
        private string _task;
        private string _weapon;
        public TerroristPlayer()
        {
            _task = "* Plant an explosive bomb.";
        }
        public string PlayerType() => "Terrorist";
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
