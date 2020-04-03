namespace CainsSharpTools
{
    /// <summary>
    /// A 2d vector
    /// </summary>
    public class Vector2
    {
        private float _eulerX;
        private float _eulerY;

        private float _magnitude;

        public Vector2(float eulerX, float eulerY, float magnitude)
        {
            this._eulerX = eulerX;
            this._eulerY = eulerY;
            this._magnitude = magnitude;
        }
    }
}