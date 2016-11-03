/* 
 * SiteSurvey
 * https://github.com/peader/SiteSurvey/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using System.Windows.Media.Media3D;

namespace ExcelDNAExample.Math.VectorManipulation
{
    internal class VectorManipulation
    {
        // @vectorToBeRotated a real vector in 3d space
        // @theta the angle of rotation in degrees
        // @return vectorToBeRotated rotated "theta" degrees about the Z axis
        internal static Vector3D RotateAboutZAxis(Vector3D vectorToBeRotated, double theta)
        {
            Matrix3D identityMatrix = Matrix3D.Identity;
            Quaternion q = new Quaternion(new Vector3D(0, 0, 1), theta);
            identityMatrix.Rotate(q);
            return identityMatrix.Transform(vectorToBeRotated); ;
        }

        // @vectorToTranlated a real vector in 3d space
        // @distance the distance of the translation
        // @return returnVector translated distance along y axis
        internal static Vector3D TranslateAlongYAxis(Vector3D vectorToTranlated, double distance)
        {
            Vector3D returnVector = new Vector3D();
            returnVector = vectorToTranlated;
            returnVector.Y += distance;
            return returnVector;
        }
    }
}
