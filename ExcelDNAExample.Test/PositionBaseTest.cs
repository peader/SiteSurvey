using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ElevationDataAPI.TerrainProfiler;

namespace ExcelDNAExample.Test
{
    class PositionBaseTest
    {
        private Position pos1 = null;
        private Position pos2 = null;
        private Position pos3 = null;
        private Position pos4 = null;
        private Position pos5 = null;

        [SetUp]
        public void InitiliseProfiles()
        {
            pos1 = new Position();
            pos1.latitude = 38.5;
            pos1.longitude = -120.2;

            pos2 = new Position();
            pos2.latitude = 40.7;
            pos2.longitude = -120.95;

            pos3 = new Position();
            pos3.latitude = 43.252;
            pos3.longitude = -126.453;

            pos4 = new Position();
            pos4.latitude = 0;
            pos4.longitude = 0;

            pos5 = new Position();
            pos5.latitude = -0.00015;
            pos5.longitude = -0.00001;
        }

        [Test]
        public void TestGetEncodedPolylineAlgorithmFormatGoogleSampleValues()
        {
            string actual = pos1.GetEncodedPolylineAlgorithmFormat(null);
            string expected = "_p~iF~ps|U";
            Assert.AreEqual(expected, actual);

            actual = pos2.GetEncodedPolylineAlgorithmFormat(pos1);
            expected = "_ulLnnqC";
            Assert.AreEqual(expected, actual);

            actual = pos3.GetEncodedPolylineAlgorithmFormat(pos2);
            expected = "_mqNvxq`@";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestGetEncodedPolylineAlgorithmFormatGoogleZeroPosition()
        {
            string actual = pos4.GetEncodedPolylineAlgorithmFormat(null);
            string expected = "??";
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestGetEncodedPolylineAlgorithmFormatGooglePositionWithEscapeCharacter()
        {
            string actual = pos5.GetEncodedPolylineAlgorithmFormat(null);
            string expected = "\\@";
            Assert.AreEqual(expected, actual);

        }


    }
}
