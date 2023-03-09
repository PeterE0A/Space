using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    enum Startype {YellowDwarf, White, BlueNeutron, RedGiant}
    internal class Star : SpaceObject
    {

        public Startype Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet> Planets { get; set; }


        public Star()
        {
            position = new Position() { X = 0.0, Y = 0.0 };
            Planets = new List<Planet>();
        }
      


    }
}
