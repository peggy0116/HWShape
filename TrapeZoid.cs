using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape001
{
    internal class TrapeZoid : Shape
    {
        private double _upperBase;
        private double _lowerBase;
        private double _height;
        public double upperBase
        {
            get { return _upperBase; }
            set { _upperBase = value; }
        }
        public double lowerBase
        {
            get { return _lowerBase; }
            set { _lowerBase = value; }
        }
        public double height
        {
            get { return _height; }
            set { _height = value; }
        }
        public TrapeZoid(double UpperBase, double LowerBase, double Height)
        {
            this.upperBase = UpperBase;
            this.lowerBase = LowerBase;
            this.height = Height;
            CountArea();
        }
        public override double CountArea()
        {
            this.area = (this.upperBase + this.lowerBase) * this.height / 2;
            return area;
        }
    }
}
