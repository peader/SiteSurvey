/* 
 * TerrainProfiler
 * https://github.com/peader/TerrainProfiler/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using System;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace ElevationDataAPI.TerrainProfiler
{
    public abstract class ElevationProfileBase:  List<Position>,  IElevationProfile 
    {
        // @numberOfSteps - The number steps each profile line is to be broken into numberOfSteps > 0
        // @initialPosition - Starting point from which to step through the profile
        // @offsetUnitVector - The step length for stepping through the profile
        // @lat - The centre of the sites lattitude
        // @lon - The centre of the sites longitude
        // @theta - The angle to the horizontal "E-W" of the profile being intilised
        // @stepLength - The incremental step length along the profile being used
        // Initialise the Elevation profile for a given angle to the horizontal with a list of Position objects
        internal void InitiliseProfile(double numberOfSteps, Vector3D initialPosition, Vector3D offsetUnitVector,  double lat,
                                      double lon, double theta, double stepLength)
        {

            //Earth’s radius, assuming a perfect sphere
            const double R = 6378137;

            // Assign angle to the horizontal  property of the profile here
            if (this.AngleToHorizontal == null) this.AngleToHorizontal = theta;

            for (int j = 0; j <= (2 * numberOfSteps); j++)
            {
                Vector3D CurrentPosition = new Vector3D(0, 0, 0);
                Position temp = new Position();
                CurrentPosition += initialPosition + (offsetUnitVector * j);

                //Coordinate offsets in radians
                double dLat = CurrentPosition.Y / R;
                double dLon = CurrentPosition.X / (R * Math.Cos(Math.PI * lat / 180));

                temp.theta = theta;
                temp.Xoffset = (float)CurrentPosition.X;
                temp.Yoffset = (float)CurrentPosition.Y;
                temp.offsetLength = (float)(j * stepLength);

                //OffsetPosition, decimal degrees
                temp.latitude = lat + dLat * 180 / Math.PI;
                temp.longitude = lon + dLon * 180 / Math.PI;

                this.Add(temp);                

            }
        }

        public double MaxElevation()
        {
            double elev = 0;

            foreach (Position pos in this)
            {
                elev = System.Math.Max(elev, pos.elevation);
            }

            return elev;
        }

        public abstract void GetElevationData();
        public double? AngleToHorizontal { get; set; }



    }
}
