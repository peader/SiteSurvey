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
    // this interface will set up the contract for all methods of obtaining elevation data i.e. from google maps, offline maps etc.
    internal interface IElevationProfile
    {
        void GetElevationData();
    }
}
