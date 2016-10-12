using System;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace ElevationDataAPI.TerrainProfiler
{
    public class Site : List<ElevationProfileBase>
    {
        // @lattitude - The site lattitude
        // @longitude - The sites longitude
        // @mapDataProvider - The source of the elevation data
        // returns an instance of the site class which contains elevation profiles i.e. (offset and elevation points)
        public Site(string lattitude, string longitude, string mapDataProvider)
        {
            try
            {
                
            //Position, Centre point of site
            double lat = Convert.ToDouble(lattitude);
            double lon = Convert.ToDouble(longitude);

            double SiteRadius = 500;
            double StepLength = 50;

            double NumberOfSteps = SiteRadius / StepLength;

            for (int theta = 0; theta < 180; theta += 10)
            {

                // Using the offset length create an appropriate, rotated, offset unit vector
                Matrix3D identityMatrix = Matrix3D.Identity;
                Quaternion q = new Quaternion(new Vector3D(0, 0, 1), theta);
                identityMatrix.Rotate(q);
                Vector3D OffsetUnitVector = identityMatrix.Transform(new Vector3D(StepLength, 0, 0));

                // Get the initial position of the elevation profile
                // This will be the outermost point of the site radius
                Vector3D InitialPosition = new Vector3D(0, 0, 0);
                InitialPosition.X = OffsetUnitVector.X * (-1 * NumberOfSteps);
                InitialPosition.Y = OffsetUnitVector.Y * (-1 * NumberOfSteps);


                ElevationProfileBase ElevationProfile = MapProvider.GetProfile(mapDataProvider);
                // Now we need to intialise this Profile with points relative to the initial position and the offsetunit vector worked out above
                ElevationProfile.InitiliseProfile(NumberOfSteps, InitialPosition, OffsetUnitVector, lat, lon, theta, StepLength);

                this.Add(ElevationProfile);

            }


            // now we need to get the elevation data for each of the profiles
            foreach(ElevationProfileBase Profile in this)
            {
                Profile.GetElevationData();
            }
     
               // Return the SiteProfile
                return;
            }
            catch(Exception)
            {
                throw;             
            }
        }


    }
}
