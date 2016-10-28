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

        // credit to Brian Caos from who's work parts of the below encoding is used.
        // https://briancaos.wordpress.com/2009/10/16/google-maps-polyline-encoding-in-c/

        // @param the previous position - Must be a valid position or zero if this is the first 
        //   point in the polyline
        // @param the current point being converted
        // @return an encoded point relative to the previous position as per the google docs spec 
        // https://developers.google.com/maps/documentation/utilities/polylinealgorithm
        public string GetEncodedPolylineAlgorithmFormat(Position previousPosition)
        {
            try
            {
                StringBuilder encodedCoordinates = new StringBuilder();
                int relativeLattitude = 0;
                int relativeLongitude = 0;
                // if the previous position provided is null than this is the start point of the poly line
                if (previousPosition == null)
                {
                    relativeLattitude = Convert.ToInt32(this.latitude * 1E5);
                    relativeLongitude = Convert.ToInt32(this.longitude * 1E5);
                }
                else
                {
                    relativeLattitude = Convert.ToInt32(this.latitude * 1E5) - Convert.ToInt32(previousPosition.latitude * 1E5);
                    relativeLongitude = Convert.ToInt32(this.longitude * 1E5) - Convert.ToInt32(previousPosition.longitude * 1E5);

                }

                encodedCoordinates.Append(EncodeSignedNumber(relativeLattitude));
                encodedCoordinates.Append(EncodeSignedNumber(relativeLongitude));

                return encodedCoordinates.ToString();
            }

            catch(Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Encode a signed number in the encode format.
        /// </summary>
        /// <param name="num">The signed number</param>
        /// <returns>The encoded string</returns>
        private static string EncodeSignedNumber(int num)
        {
            int sgn_num = num << 1; //shift the binary value
            if (num < 0) //if negative invert
            {
                sgn_num = ~(sgn_num);
            }
            return (EncodeNumber(sgn_num));
        }

        /// <summary>
        /// Encode an unsigned number in the encode format.
        /// </summary>
        /// <param name="num">The unsigned number</param>
        /// <returns>The encoded string</returns>
        private static string EncodeNumber(int num)
        {
            StringBuilder encodeString = new StringBuilder();
            while (num >= 0x20)
            {
                encodeString.Append((char)((0x20 | (num & 0x1f)) + 63));
                num >>= 5;
            }
            encodeString.Append((char)(num + 63));
            // All backslashes needs to be replaced with double backslashes
            // before being used in a Javascript string.
            return encodeString.ToString();
        }
    }


}

