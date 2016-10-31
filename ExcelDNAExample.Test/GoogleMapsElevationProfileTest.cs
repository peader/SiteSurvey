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
        private GoogleMapsElevationProfile testFourProfile = null;
        private GoogleMapsElevationProfile testFiveProfile = null;
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


            testFourProfile = new GoogleMapsElevationProfile();
            Position pos1 = new Position();
            pos1.latitude = 38.5;
            pos1.longitude = -120.2;

            Position pos2 = new Position();
            pos2.latitude = 40.7;
            pos2.longitude = -120.95;

            Position pos3 = new Position();
            pos3.latitude = 43.252;
            pos3.longitude = -126.453;
            testFourProfile.Add(pos1);
            testFourProfile.Add(pos2);
            testFourProfile.Add(pos3);

            testFiveProfile = new GoogleMapsElevationProfile();
            Position pos5 = new Position();
            pos5.latitude = -0.00015;
            pos5.longitude = -0.00001;
            testFiveProfile.Add(pos5);

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
            double expected = -3554.390;
            Assert.AreEqual(expected, actual, 0.001);
        }

        [Test]
        public void TestDataGoogleExampleResponseFromServer()
        {
            testFourProfile.GetElevationData();
            double actual = testFourProfile[0].elevation;
            double expected = 1200.000;
            Assert.AreEqual(expected, actual, 0.001);
            actual = testFourProfile[1].elevation;
            expected = 1691.376;
            Assert.AreEqual(expected, actual, 0.001);
            actual = testFourProfile[2].elevation;
            expected = -2984.855;
            Assert.AreEqual(expected, actual, 0.001);
        }

        [Test]
        public void TestDataEncodedEscapeCharactersResponseFromServer()
        {
            testFiveProfile.GetElevationData();
            double actual = testFiveProfile[0].elevation;
            double expected = -3493.563;
            Assert.AreEqual(expected, actual, 0.001);            
        }



    }
}
