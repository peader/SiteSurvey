using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
