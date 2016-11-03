/* 
 * SiteSurvey
 * https://github.com/peader/SiteSurvey/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

namespace ElevationDataAPI.TerrainProfiler
{
    internal class MapProvider
    { 
        public static ElevationProfileBase GetProfile(string ElevationProfleDataProvider)
        {
            switch (ElevationProfleDataProvider.ToLower())
            { 
                case "google":
                    return new GoogleMapsElevationProfile();
            }

            return null;
        }

    }
}
