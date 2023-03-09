using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    internal class SpaceObject 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position position { get; set; }

        public class Position
        {
            public double X { get; set; }
            public double Y { get; set; }

            public override string ToString()
            {
                return $"({X},{Y})";
            }
        }
    }
}
