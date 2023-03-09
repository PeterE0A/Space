using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
    internal class Planet : SpaceObject
    {
        public PlanetType planetType { get; set; }
        public double DiameterInMeters { get; set; }
        public double RotationPeriodInHours { get; set; }
        public double RevolutionPeriodInDays { get; set; }
        public List<Moon> moons { get; set; }

        public Planet()
        {
            moons = new List<Moon>();
        }

        public double Distance(Star star)
        {
            double x1 = this.position.X;
            double y1 = this.position.Y;
            double x2 = star.position.X;
            double y2 = star.position.Y;

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }
}
