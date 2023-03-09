using Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Space.SpaceObject;

namespace Galactica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sun
            Star sun = new Star()
            {
                Id = 1,
                Name = "Sun",
                Type = Startype.YellowDwarf,
                Temperature = 5778
            };


            //Planets



            //---- Mercury ----

            Planet mercury = new Planet()
            {
                Id = 2,
                Name = "Mercury",
                planetType = PlanetType.Terrestial,
                DiameterInMeters = 4879,
                RotationPeriodInHours = 1407,
                RevolutionPeriodInDays = 88,
                position = new SpaceObject.Position() { X = 0.387, Y = 0.0 }
            };

            //---- Venus ----

            Planet venus = new Planet()
            {
                Id = 3,
                Name = "Venus",
                planetType = PlanetType.Terrestial,
                DiameterInMeters = 12104,
                RotationPeriodInHours = 5832.5,
                RevolutionPeriodInDays = 225,
                position = new SpaceObject.Position() { X = 0.723, Y = 0.0 }
            };


            ////---- Earth ----

            Planet earth = new Planet()
            {
                Id = 4,
                Name = "Earth",
                planetType = PlanetType.Terrestial,
                DiameterInMeters = 12742,
                RotationPeriodInHours = 24,
                RevolutionPeriodInDays = 365,
                position = new SpaceObject.Position() { X = 0.345, Y = 0.0 }
            };


            ////---- Mars ----

            Planet mars = new Planet()
            {
                Id = 5,
                Name = "Mars",
                planetType = PlanetType.Terrestial,
                DiameterInMeters = 2356,
                RotationPeriodInHours = 23,
                RevolutionPeriodInDays = 543,
                position = new SpaceObject.Position() { X = 0.445, Y = 0.0 }
            };

            ////---- Jupiter ----

            Planet jupiter = new Planet()
            {
                Id = 6,
                Name = "Jupiter",
                planetType = PlanetType.Giant,
                DiameterInMeters = 14600,
                RotationPeriodInHours = 10,
                RevolutionPeriodInDays = 4300,
                position = new SpaceObject.Position() { X = 0.563, Y = 0.0 }
            };


            ////---- Saturn ----

            Planet saturn = new Planet()
            {
                Id = 7,
                Name = "Saturn",
                planetType = PlanetType.Gas_Giant,
                DiameterInMeters = 125432,
                RotationPeriodInHours = 32,
                RevolutionPeriodInDays = 10800,
                position = new SpaceObject.Position() { X = 0.432, Y = 0.0 }
            };


            ////---- Uranus ----

            Planet uranus = new Planet()
            {
                Id = 8,
                Name = "Uranus",
                planetType = PlanetType.Gas_Giant,
                DiameterInMeters = 51673,
                RotationPeriodInHours = 17,
                RevolutionPeriodInDays = 30500,
                position = new SpaceObject.Position() { X = 0.215, Y = 0.0 }
            };


            ////---- Neptune ----

            Planet neptune = new Planet()
            {
                Id = 9,
                Name = "Neptune",
                planetType = PlanetType.Gas_Giant,
                DiameterInMeters = 3249,
                RotationPeriodInHours = 21,
                RevolutionPeriodInDays = 59800,
                position = new SpaceObject.Position() { X = 0.231, Y = 0.0 }
            };



            ////Moons


            ////---- Luna ----

            Moon luna = new Moon()
            {
                Id = 10,
                Name = "Luna",
                planetType = PlanetType.Dwarf,
                DiameterInMeters = 49654,
                RotationPeriodInHours = 16,
                RevolutionPeriodInDays = 59832,
                position = new SpaceObject.Position() { X = 0.145, Y = 0.0 },
                Orbiting = earth
            };


            ////---- Titan ----

            Moon titan = new Moon()
            {
                Id = 11,
                Name = "Titan",
                planetType = PlanetType.Dwarf,
                DiameterInMeters = 5151,
                RotationPeriodInHours = 382,
                RevolutionPeriodInDays = 16,
                position = new SpaceObject.Position() { X = 5.145, Y = 0.0 },
                Orbiting = jupiter
            };


            ////---- Phobos ----

            Moon phobos = new Moon()
            {
                Id = 12,
                Name = "Phobos",
                planetType = PlanetType.Dwarf,
                DiameterInMeters = 2343,
                RotationPeriodInHours = 32,
                RevolutionPeriodInDays = 322,
                position = new SpaceObject.Position() { X = 3.145, Y = 0.0 },
                Orbiting = mars
            };


            ////---- Europa ----

            Moon europa = new Moon()
            {
                Id = 13,
                Name = "Europa",
                planetType = PlanetType.Dwarf,
                DiameterInMeters = 2345,
                RotationPeriodInHours = 23,
                RevolutionPeriodInDays = 35653,
                position = new SpaceObject.Position() { X = 3.455, Y = 0.0 },
                Orbiting = jupiter
            };


            ////---- Deimos ----

            Moon deimos = new Moon()
            {
                Id = 14,
                Name = "Deimos",
                planetType = PlanetType.Dwarf,
                DiameterInMeters = 24653,
                RotationPeriodInHours = 235,
                RevolutionPeriodInDays = 245,
                position = new SpaceObject.Position() { X = 3.362, Y = 0.0 },
                Orbiting = mars
            };


            ////---- Ganymedes ----

            Moon ganymedes = new Moon()
            {
                Id = 15,
                Name = "Ganymedes",
                planetType = PlanetType.Dwarf,
                DiameterInMeters = 44354,
                RotationPeriodInHours = 136,
                RevolutionPeriodInDays = 4352,
                position = new SpaceObject.Position() { X = 1.545, Y = 0.0 },
                Orbiting = jupiter
            };


            ////---- Io ----

            Moon io = new Moon()
            {
                Id = 16,
                Name = "Io",
                planetType = PlanetType.Dwarf,
                DiameterInMeters = 3654,
                RotationPeriodInHours = 43,
                RevolutionPeriodInDays = 2456,
                position = new SpaceObject.Position() { X = 2.525, Y = 0.0 },
                Orbiting = jupiter
            };


            ////---- Mimas ----

            Moon mimas = new Moon()
            {
                Id = 17,
                Name = "Mimas",
                planetType = PlanetType.Dwarf,
                DiameterInMeters = 2345,
                RotationPeriodInHours = 36,
                RevolutionPeriodInDays = 3345,
                position = new SpaceObject.Position() { X = 5.764, Y = 0.0 },
                Orbiting = saturn
            };


            //Adding to list

            sun.Planets.AddRange(new Planet[] { mercury, venus, earth, mars, jupiter, saturn, uranus, neptune });


            luna.moons.AddRange(new Moon[] { titan, phobos, europa, deimos, ganymedes, io, mimas });

            //Show List

            foreach (Planet planet in sun.Planets)
            {
                Console.WriteLine($"Name: {planet.Name}\nType: {planet.planetType}\nDistance From Sun {planet.Distance(sun)}\n");


                //if (planet.moons.Count > 0)
                //{
                //    Console.WriteLine("  Moons:");

                //foreach (Moon moon in planet.moons)
                //{
                //    Console.WriteLine($"    Moon: {moon.Name}, Distance to {planet.Name}: {moon.Distance(luna)}");

                //}
                //Console.ReadLine();

                //}


            }
                Console.ReadLine();  

        }
    }
}
