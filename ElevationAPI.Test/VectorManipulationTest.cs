using System;
using ElevationDataAPI.VectorManipulation;
using System.Numerics;
using NUnit.Framework;


namespace ExcelDNAExample.Test
{
    [TestFixture]
    public class VectorManipulationTest
    {
        [Test]
        public void RotateNormalizedUnitVector()
        {
            Vector3 expected = new Vector3(0.707107f, 0.707107f, 0);
            Vector3 actual = VectorManipulation.RotateAboutZAxis(new Vector3(1, 0, 0), 45);
            VectorAssert.AreEqual(expected, actual, 0.0001);            
        }

        [Test]
        public void RotateVectorWithNonZeroXYZComponents()
        {
            Vector3 expected = new Vector3(-15.980762f, 32.320508f, 45);
            Vector3 actual = VectorManipulation.RotateAboutZAxis(new Vector3(20, 30, 45), 60);
            VectorAssert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void RotateNormalizedUnitVectorByALargeAngle()
        {
            Vector3 expected = new Vector3(-6.830127f, 1.830127f, 5);
            Vector3 actual = VectorManipulation.RotateAboutZAxis(new Vector3(5,5,5), 1200);
            VectorAssert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void RotateNormalizedUnitVectorByZeroDegrees()
        {
            Vector3 expected = new Vector3(5, 5, 5);
            Vector3 actual = VectorManipulation.RotateAboutZAxis(new Vector3(5, 5, 5), 0);
            VectorAssert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void TestTranslateAlongYAxisPositive()
        {
            Vector3 expected = new Vector3(5, 10, 5);
            Vector3 actual = VectorManipulation.TranslateAlongYAxis(new Vector3(5, 5, 5), 5);
            VectorAssert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void TestTranslateAlongYAxisNegative()
        {
            Vector3 expected = new Vector3(5, 0, 5);
            Vector3 actual = VectorManipulation.TranslateAlongYAxis(new Vector3(5, 5, 5), -5);
            VectorAssert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void TestTranslateAlongYAxisNoTranslation()
        {
            Vector3 expected = new Vector3(5, 5, 5);
            Vector3 actual = VectorManipulation.TranslateAlongYAxis(new Vector3(5, 5, 5), 0);
            VectorAssert.AreEqual(expected, actual, 0.0001);
        }

    }


}
