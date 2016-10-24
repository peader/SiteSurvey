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
        private GoogleMapsElevationProfile testTwoProfile = null;
        private GoogleMapsElevationProfile testThreeProfile = null;
        [SetUp]
        public void InitiliseProfiles()
        {
            testOneProfile = new GoogleMapsElevationProfile();
            Position testOneProfilePosition = new Position();
            testOneProfilePosition.latitude = 53;
            testOneProfilePosition.longitude = -9;
            testOneProfile.Add(testOneProfilePosition);


            testTwoProfile = new GoogleMapsElevationProfile();
            Position testTwoProfilePosition = new Position();
            testTwoProfilePosition.latitude = -0.00007;
            testTwoProfilePosition.longitude = -0.0004;
            testTwoProfile.Add(testTwoProfilePosition);

            testThreeProfile = new GoogleMapsElevationProfile();
            Position testThreeProfilePosition = new Position();
            testThreeProfilePosition.latitude = -0.00449157642059761;
            testThreeProfilePosition.longitude = -0.000000000000000000997330311802182;
            testThreeProfile.Add(testThreeProfilePosition);

        }
        [Test]
        public void TestSinglePositionElevationRequest()
        {
            testOneProfile.GetElevationData();
            double actual = testOneProfile[0].elevation;
            double expected = 29.453;
            Assert.AreEqual(expected, actual, 0.001);
        }

        [Test]
        public void TestPositionWithSmallCoordinates()
        {
            testTwoProfile.GetElevationData();
            double actual = testTwoProfile[0].elevation;
            double expected = -3474.608;
            Assert.AreEqual(expected, actual, 0.001);
        }

        [Test]
        public void TestDataNotAvaiableResponseFromServer()
        {
            testThreeProfile.GetElevationData();
            double actual = testThreeProfile[0].elevation;
            double expected = double.NaN;
            Assert.AreEqual(expected, actual);
        }



    }
}
