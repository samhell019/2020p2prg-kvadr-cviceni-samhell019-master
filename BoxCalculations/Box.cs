using System;
using System.Collections.Generic;
using System.Text;

namespace BoxCalculations
{
    public class Box
    {
        private float _a;
        private float _b;
        private float _c;


        public Box(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public void SetA(float a)
        {
            _a = a;

        }

        public void SetB(float b)
        {
            _b = b;

        }
        public void SetC(float c)
        {
            _c = c;

        }
        public float GetVolume()
        {
            return _a * _b * _c;
        }
        public float GetSurface()
        {
            return 2 * (_a * _b + _b * _c + _c * _a);

        }

    }
}






