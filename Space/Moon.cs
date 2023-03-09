using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    internal sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }

        public double Distance(Planet orbiting)
        {
            double x1 = this.position.X;
            double y1 = this.position.Y;
            double x2 = Orbiting.position.X;
            double y2 = Orbiting.position.Y;

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }
}
