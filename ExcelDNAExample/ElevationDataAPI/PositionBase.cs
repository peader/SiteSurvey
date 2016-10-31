/* 
 * TerrainProfiler
 * https://github.com/peader/TerrainProfiler/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using System;
using System.Text;

namespace ElevationDataAPI.TerrainProfiler
{
    public class Position
    {
        public float Xoffset { get; set; }
        public float Yoffset { get; set; }
        public float offsetLength { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double elevation { get; set; }
        public double theta { get; set; }


        public override string ToString()
        {
            return this.latitude.ToString("F99").TrimEnd("0".ToCharArray()) + "," + this.longitude.ToString("F99").TrimEnd("0".ToCharArray()) + "|";
        }

    }


}

