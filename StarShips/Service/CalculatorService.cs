using System;
using System.Numerics;


namespace StarShips.Service
{
    public class CalculatorService
    {


        /*
         * Check to validate if the user input valid 
         * 
         * Input: (string) input distance
         * 
         * Output: (boolean) A true or false response
         *         
         */

        public bool ParseInput(string input)
        {
            BigInteger X;
            if (!BigInteger.TryParse(input, out X))
            {
                Console.WriteLine("Not a valid number, try again.");
                return false;
            }
            else if(!(BigInteger.Parse(input) >0))
            {
                Console.WriteLine("Number must be greater than 0, try again.");
                return false;
            }

            else return true;
        }

        /*
         * Calculate the number of stops for a starship. If the starship has
         * valid data for MGLT, consumeables the distance will be output to the 
         * console with the ship name. If any of the data isnt valid the distance
         * will be output as unknown        
         * 
         * Input: (StarShip) Starship object, (BigInterger) input distance
         * 
         * Output: void
         *         
         */
        public void CalculateStops(StarShip starShip, BigInteger distance)
        {
            BigInteger numStops;


            BigInteger MGLT = 0;

            string[] split = starShip.consumables.Split();

            if (starShip.MGLT.ToLower() != "unknown" && split.Length == 2)
            {


                int days = CalcuateDays(split[1]);
                int dayMultiplier = Int32.Parse(split[0]);

                if (days == 0 | dayMultiplier == 0)
                    Console.WriteLine("{0,-40} {1,5:N1}", starShip.name, "Unknown");
                else
                {
                    MGLT = BigInteger.Parse(starShip.MGLT);
                    numStops = distance / (days * dayMultiplier * 24 * MGLT );
                    Console.WriteLine("{0,-40} {1,5:N1}", starShip.name, numStops);

                }

            }
            else
            {
                numStops = 0;
                Console.WriteLine("{0,-40} {1,5:N1}", starShip.name, "Unknown");
            }
        }


        /*
         * Returns a number of days based on a string input
         *  
         * 
         * Input: (String) the time value from the consumbales field
         * 
         * Output: (int) the number of days in each time value
         *         
         */
        private static int CalcuateDays(string time)
        {
            int days = 0;


            switch (time.ToLower())
            {
                case "month":
                case "months":
                    days = 30;
                    break;
                case "week":
                case "weeks":
                    days = 7;
                    break;
                case "year":
                case "years":
                    days = 365;
                    break;
                case "day":
                case "days":
                    days = 1;
                    break;
                default:
                    days = 0;
                    break;

            }
            return days;
        }
    }
}
