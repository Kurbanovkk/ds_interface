using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ds_interface
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };


        public string GetInfo()
        {
            return "Quadcopter Information";
        }

        public List<string> GetComponents()
        {
            return _components;
        }

        public void GetRobotType()
        {

        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000); // Подождать 3 секунды
            Console.WriteLine("Charged!");
        }
    }
}
