using System.Windows.Media.Media3D;

namespace ExcelDNAExample.Test
{
    class VectorAssert: NUnit.Framework.Assert
    {
        public static void AreEqual(Vector3D expected, Vector3D actual, double delta)
        {
            AreEqual(expected.X, actual.X, delta);
            AreEqual(expected.Y, actual.Y, delta);
        }
    }
}
