/* 
 * TerrainProfiler
 * https://github.com/peader/TerrainProfiler/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using ExcelDna.Integration;
using ElevationDataAPI.TerrainProfiler;
using AsyncFunctions;
using System;

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
        public static object GetTerrainProfile(string lat, string lon)
        {
            try
            {
                // Generate and retrieve all the required data for the user inputted site
                Site testsite = new Site(lat, lon, "google");

                int rows = (testsite.Count * testsite[0].Count) + 1;
                int columns = 6;

                object[,] result = new object[rows, columns];
                int rowCounter = 1;

                //Initilise the headers
                result[0, 0] = "Angle Profile makes to horizontal i.e. to E-W";
                result[0, 1] = "Lattitude";
                result[0, 2] = "Longitude";
                result[0, 3] = "X - Cartesian coordinate relative to site position";
                result[0, 4] = "Y - Cartesian coordinate relative to site position";
                result[0, 5] = "Elevation above sea level (m)";

                foreach (ElevationProfileBase profile in testsite)
                {
                    foreach (Position position in profile)
                    {
                        result[rowCounter, 0] = position.theta;
                        result[rowCounter, 1] = position.latitude;
                        result[rowCounter, 2] = position.longitude;
                        result[rowCounter, 3] = position.Xoffset;
                        result[rowCounter, 4] = position.Yoffset;
                        result[rowCounter, 5] = (double.IsNaN(position.elevation)) ? "NaN" : position.elevation.ToString();

                        rowCounter++;

                    }
                }

                return ArrayResizer.Resize(result);
            }
            catch(Exception ex)
            {
                return ex.Message;                
            }


        }
    }
}
