# swapi-starships

The application will take as input a distance in mega lights (MGLT).
The output should be a collection of all the star ships and the total amount of stops required to
make the distance between the planets.
All other application details are at your own discretion.
Sample output for 1000000 input:
Y-wing: 74
Millennium Falcon: 9
Rebel Transport: 11

The application will access the SWAPI starships endpoint (https://swapi.co/api/starships/) and retrieve all of the data from the paginated results

The data returned fron the API is in JSON format and a list of  all of the startships is created from it

From the user input the total required stops for each starship is calculated where possible. If the any of the values are unknown the stops for that starship will be listed as unknown

The data is then presented in the console as a table listing the starship name and  the total stops.


# Inputs
Number: MGLT distance

# Outputs
The console will output a table with the starship name and the calulated number of stops to complete the distance 

# Running the application
The application can be found in StarShips/application/
Run StarShips.exe

# Accessing the project files

The application was developed using MonoDevelop and targetting .Net 4.7. Open the solution file at the root the project will allow you to view the code and rebuild the exe if required. All of the unit tests are located in UnitTest.cs file


