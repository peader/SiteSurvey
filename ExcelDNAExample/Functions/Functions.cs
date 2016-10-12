using ExcelDna.Integration;
using ElevationDataAPI.TerrainProfiler;

namespace ExcelDNAExample.Functions
{
    public class Functions
    {
        // The function GetCurrentVersion will return the current version of the library and should be incremented whenever the library is released 
        [ExcelFunction(Name = "Hello",
        Description = "Returns ta customized greeting",
        Category = "ExcelDNAExample")]
        public static string Hello()
        {
            // Increment this variable whenever a new release of these functions occurs
            string HelloString = "Hello!";

            return HelloString;
        }

        // The function GetCurrentVersion will return the current version of the library and should be incremented whenever the library is released 
        [ExcelFunction(Name = "GetTerrainProfile",
        Description = "Returns a terrain profile",
        Category = "ExcelDNAExample")]
        public static void GetTerrainProfile(string lat, string lon)
        {
            // Increment this variable whenever a new release of these functions occurs
            Site testsite = new Site(lat, lon, "google");
            
        }
    }
}
