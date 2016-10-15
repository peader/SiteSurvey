using System;
using ExcelDNAExample.Math.VectorManipulation;
using System.Windows.Media.Media3D;
using NUnit.Framework;


namespace ExcelDNAExample.Test
{
    [TestFixture]
    public class VectorManipulationTest
    {
        [Test]
        public void RotateNormalizedUnitVector()
        {
            Vector3D expected = new Vector3D(0.707107, 0.707107, 0);
            Vector3D actual = VectorManipulation.RotateAboutZAxis(new Vector3D(1, 0, 0), 45);
            VectorAssert.AreEqual(expected, actual, 0.0001);            
        }

        [Test]
        public void RotateVectorWithNonZeroXYZComponents()
        {
            Vector3D expected = new Vector3D(-15.980762, 32.320508, 45);
            Vector3D actual = VectorManipulation.RotateAboutZAxis(new Vector3D(20, 30, 45), 60);
            VectorAssert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void RotateNormalizedUnitVectorByALargeAngle()
        {
            Vector3D expected = new Vector3D(-6.830127, 1.830127, 5);
            Vector3D actual = VectorManipulation.RotateAboutZAxis(new Vector3D(5,5,5), 1200);
            VectorAssert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void RotateNormalizedUnitVectorByZeroDegrees()
        {
            Vector3D expected = new Vector3D(5, 5, 5);
            Vector3D actual = VectorManipulation.RotateAboutZAxis(new Vector3D(5, 5, 5), 0);
            VectorAssert.AreEqual(expected, actual, 0.0001);
        }

    }


}
