using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape001
{
    internal class Triangle : Shape
    {
        private double _low;
        public double low
        {
            get { return _low; }
            set { _low = value; }
        }
        private double _high;
        public double high
        {
            get { return _high; }
            set { _high = value; }
        }
        public Triangle(double low, double high)
        {
            this.low = low;
            this.high = high;
            CountArea();
        }

        public override double CountArea()
        {
            this.area = (this._high * this._low) / 2;
            return this.area;
            //throw new NotImplementedException();
        }
    }
}
