using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevationDataAPI.TerrainProfiler
{
    // this interface will set up the contract for all methods of obtaining elevation data i.e. from google maps, offline maps etc.
    internal interface IElevationProfile
    {
        void GetElevationData();
    }
}
