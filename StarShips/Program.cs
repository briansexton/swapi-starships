using System;
using System.Numerics;
using StarShips.Service;
using System.Collections.Generic;

/********************************************
* StarShips Logistics Console Application
* Author: Brian Sexton
* Version: 1.0
*
* The Application accesses the Star Wars API
* and gets all of the available data from the
* starships endpoint.
* 
* Taking in a distance from the user it calculates
* the number of stops required for each spaceship
* to travel the distance.
*
*********************************************/
namespace StarShips
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Starships Logistics. Please Wait, Loading Data......");


            //Access the first page of data from  the API
            string url = "https://swapi.co/api/starships/?page=1";

            SwAPIService service = new SwAPIService();

            SWPage swpage = service.GetStarShipData(url);




            //Create the initial list of starships from the  results
            List<StarShip> starShips = swpage.Results;

            // Check the results to see if there are  more pages of data available
            // If there is more data keep looking the call  to the next page until 
            // end of the pageinated data is reached
            while (swpage.Next != null)
            {

                swpage = service.GetStarShipData(swpage.Next);
                starShips.AddRange(swpage.Results);
            }




            //Take an input from the user for the distance
            Console.WriteLine("Plese enter the desired distance to travel:");

            String distance  = Console.ReadLine();

            CalculatorService c = new CalculatorService();

            //Check that the input is a valid number
            while (!c.ParseInput(distance))
            {


                distance = Console.ReadLine();
            }



            //Create the results header
            Console.WriteLine("{0,-40} {1,5}\n", "StarShip", "Total Stops");


            //Calculate and output the data for each starship then exit the  program
            foreach (var data in starShips)
            {
                 c.CalculateStops(data, BigInteger.Parse(distance));
            }

            Console.WriteLine("Press any key to exit......");
            Console.Read();


        }




    }





}
