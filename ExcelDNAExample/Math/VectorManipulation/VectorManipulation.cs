using System.Windows.Media.Media3D;

namespace ExcelDNAExample.Math.VectorManipulation
{
    internal class VectorManipulation
    {
        // @vectorToBeRotated a real vector in 3d space
        // @theta the angle of rotation in degrees
        // @return vectorToBeRotated rotated "theta" degrees about the Z axis
        internal static Vector3D RotateAboutZAxis(Vector3D vectorToBeRotated, int theta)
        {
            Matrix3D identityMatrix = Matrix3D.Identity;
            Quaternion q = new Quaternion(new Vector3D(0, 0, 1), theta);
            identityMatrix.Rotate(q);
            return identityMatrix.Transform(vectorToBeRotated); ;
        }
    }
}
