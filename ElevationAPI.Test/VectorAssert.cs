using System.Numerics;

namespace ExcelDNAExample.Test
{
    class VectorAssert: NUnit.Framework.Assert
    {
        public static void AreEqual(Vector3 expected, Vector3 actual, double delta)
        {
            AreEqual(expected.X, actual.X, delta);
            AreEqual(expected.Y, actual.Y, delta);
            AreEqual(expected.Z, actual.Z, delta);
        }
    }
}
