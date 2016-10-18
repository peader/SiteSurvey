using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ElevationDataAPI.TerrainProfiler;

namespace ExcelDNAExample.Test
{
    class GoogleMapsElevationProfileTest
    {
        private GoogleMapsElevationProfile testOneProfile = null;
        [SetUp]
        public void InitiliseProfiles()
        {
            testOneProfile = new GoogleMapsElevationProfile();
            Position testOneProfilePosition = new Position();
            testOneProfilePosition.latitude = 53;
            testOneProfilePosition.longitude = -9;

            testOneProfile.Add(testOneProfilePosition);

        }
        [Test]
        public void TestSinglePositionElevationRequest()
        {
            testOneProfile.GetElevationData();
            double actual = testOneProfile[0].elevation;
            double expected = 29.453;
            Assert.AreEqual(expected, actual, 0.001);
        }

    }
}
