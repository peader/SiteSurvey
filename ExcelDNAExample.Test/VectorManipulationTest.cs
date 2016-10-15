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
    }


}
