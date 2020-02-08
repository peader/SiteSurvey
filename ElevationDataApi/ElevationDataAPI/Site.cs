/* 
 * SiteSurvey
 * https://github.com/peader/SiteSurvey/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using System;
using System.Collections.Generic;
using System.Numerics;
using ElevationDataAPI.VectorManipulation;

namespace ElevationDataAPI.TerrainProfiler
{
    public class Site : List<ElevationProfileBase>
    {
        private double lat = 0;
        private double lon = 0;
        private string mapProvider = null;

        // @lattitude - The site lattitude
        // @longitude - The sites longitude
        // @mapDataProvider - The source of the elevation data
        // returns an instance of the site class which contains an empty list of elevation profiles 
        public Site(string lattitude, string longitude, string mapDataProvider = "google")
        {                
            //Position, Centre point of site
            lat = Convert.ToDouble(lattitude);
            lon = Convert.ToDouble(longitude);
            mapProvider = mapDataProvider;
        }

        //
        //  @ param the radius of the site. must be > 0
        //  @ param steplength must be > 0
        //  @ angle of section 
        //  populates a site with late long and elevation data 
        //  
        public void GenerateRadial(float siteRadius, float steplength, float angleOfSection)
        {
            try
            {
                float NumberOfSteps = siteRadius / steplength;

                for (float theta = 0; theta < 180; theta += angleOfSection)
                {
                    // Rotate the vector normalised along the axis about the z axis by theta to get 
                    // the unit offset vector for this profile      
                    Vector3 OffsetUnitVector = VectorManipulation.VectorManipulation.RotateAboutZAxis(new Vector3(steplength, 0, 0), theta);

                    // Get the initial position of the elevation profile
                    // This will be the outermost point of the site radius
                    Vector3 InitialPosition = new Vector3(0, 0, 0);
                    InitialPosition.X = OffsetUnitVector.X * (-1 * NumberOfSteps);
                    InitialPosition.Y = OffsetUnitVector.Y * (-1 * NumberOfSteps);

                    // Here we initialise the elevation profile to the relevant subclass depending on 
                    // what is our elevation data source i.e. google maps
                    ElevationProfileBase ElevationProfile = MapProvider.GetProfile(mapProvider);
                    // Now we need to intialise this Profile with points relative to the initial position and the offsetunit vector worked out above
                    ElevationProfile.InitiliseProfile(NumberOfSteps, InitialPosition, OffsetUnitVector, lat, lon, theta, steplength);

                    this.Add(ElevationProfile);

                }


                // now we need to get the elevation data for each of the profiles
                foreach (ElevationProfileBase Profile in this)
                {
                    Profile.GetElevationData();
                }

                // Return the SiteProfile
                return;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //
        //  @ param the length of the grid > 0
        //  @ param steplength must be > 0
        //  populates a site with late long and elevation data 
        //  
        public void GenerateGrid(float gridlength, float steplength)
        {
            try
            {

                float NumberOfSteps = (gridlength/2) / steplength;

                for (float step=(-gridlength/2); step <= (gridlength/2); step += steplength)
                {
                    // Rotate the vector normalised along the axis about the z axis by theta to get 
                    // the unit offset vector for this profile      
                    Vector3 OffsetUnitVector = new Vector3(steplength, 0, 0);

                    // Get the initial position of the elevation profile
                    // This will be the outermost point of the grid at this profile step
                    Vector3 InitialPosition = new Vector3(0, 0, 0);
                    InitialPosition.X = OffsetUnitVector.X * (-1 * NumberOfSteps);
                    InitialPosition.Y = OffsetUnitVector.Y + step;

                    // Here we initialise the elevation profile to the relevant subclass depending on 
                    // what is our elevation data source i.e. google maps
                    ElevationProfileBase ElevationProfile = MapProvider.GetProfile(mapProvider);
                    // Now we need to intialise this Profile with points relative to the initial position and the offsetunit vector worked out above
                    ElevationProfile.InitiliseProfile(NumberOfSteps, InitialPosition, OffsetUnitVector, lat, lon, double.NaN, steplength);

                    this.Add(ElevationProfile);

                }


                // now we need to get the elevation data for each of the profiles
                foreach (ElevationProfileBase Profile in this)
                {
                    Profile.GetElevationData();
                }

                // Return the SiteProfile
                return;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
