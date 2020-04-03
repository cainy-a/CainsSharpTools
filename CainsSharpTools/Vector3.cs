namespace CainsSharpTools
{
    /// <summary>
    /// A 3d vector
    /// </summary>
    public class Vector3
    {
        private float _eulerX;
        private float _eulerY;
        private float _eulerZ;

        private float _magnitude;

        public Vector3(float eulerX, float eulerY, float eulerZ, float magnitude)
        {
            this._eulerX = eulerX;
            this._eulerY = eulerY;
            this._eulerZ = eulerZ;
            this._magnitude = magnitude;
        }
    }
}