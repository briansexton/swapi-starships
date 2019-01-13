using NUnit.Framework;
using System;
using StarShips.Service;
using System.Numerics;


namespace StarShips
{
    [TestFixture()]
    public class UnitTests
    {
        [Test()]
        //Test for user input as text
        public void InputString()
        {
            CalculatorService c = new CalculatorService();

            StarShip ship = new StarShip();
            ship.name = "Y-Wing";
            ship.MGLT = "80";
            ship.consumables = "1 week";


            c.ParseInput("test");
        }

        [Test()]
        //Test for user input as partial text symbols and numbers
        public void InputPartialString()
        {
            CalculatorService c = new CalculatorService();

            StarShip ship = new StarShip();
            ship.name = "Y-Wing";
            ship.MGLT = "80";
            ship.consumables = "1 week";


            c.ParseInput("123test*-+");
        }

        [Test()]
        //Test for user input as a number
        public void InputNumber()
        {
            CalculatorService c = new CalculatorService();

            StarShip ship = new StarShip();
            ship.name = "Y-Wing";
            ship.MGLT = "80";
            ship.consumables = "1 week";

            String distance = "1000000";
            c.ParseInput(distance);
        }

        [Test()]
        //Test for unknown as a comsumeable value
        public void ConsumeableUnknown()
        {
            CalculatorService c = new CalculatorService();

            StarShip ship = new StarShip();
            ship.name = "Y-Wing";
            ship.MGLT = "80";
            ship.consumables = "unknown";

            BigInteger distance = 1000000;


            c.CalculateStops(ship, distance);
        }

        [Test()]
        //Test for unknown as a MGLT value
        public void MGLTUnknown()
        {
            CalculatorService c = new CalculatorService();

            StarShip ship = new StarShip();
            ship.name = "Y-Wing";
            ship.MGLT = "Unknown";
            ship.consumables = "1 week";

            BigInteger distance = 1000000;


            c.CalculateStops(ship, distance);
        }


        [Test()]
        //Test for an unexpected value as a comsumeable input
        public void ConsumeableBadFormat()
        {
            CalculatorService c = new CalculatorService();

            StarShip ship = new StarShip();
            ship.name = "Y-Wing";
            ship.MGLT = "80";
            ship.consumables = "1 wk";

            BigInteger distance = 1000000;


            c.CalculateStops(ship, distance);
        }
    }
}
