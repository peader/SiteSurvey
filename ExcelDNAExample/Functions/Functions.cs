using ExcelDna.Integration;

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
    }
}
