using System;
using Newtonsoft.Json;

using System.Net;


/*
* Class for handling access to the Star Wars API
*/
namespace StarShips
{
    public class SwAPIService
    {


       

        /*
         * Accessor method for connecting to the SW API and deserializes the data to an SWPage object
         * 
         * Input: a string URL to connect to 
         * 
         * Output: An SWPage object
         *         
         */
        public SWPage GetStarShipData(string url)
        {


            string json = new WebClient().DownloadString(url);



            SWPage page = JsonConvert.DeserializeObject<SWPage>(json);


            return page;



        }
    }
}
