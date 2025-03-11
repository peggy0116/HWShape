using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape001
{
    public abstract class Shape : IComparable<Shape>
    {
        private double _area;
        private double _perimeter;
        public double area
        {
            get { return _area; }
            set { _area = value; }
        }
        public double perimeter
        {
            get { return _perimeter; }
            set { _perimeter = value; }

        }
        public Shape() { }
        public void test()
        {
            Console.WriteLine("我是父類別爸爸的test");
        }

        public abstract double CountArea();  //算面積

        public int CompareTo(Shape? other)
        {
            //throw new NotImplementedException();
            if (other == null)
                throw new ArgumentNullException("傳入的形狀為null值");
            //throw new NotImplementedException();

            return this.area.CompareTo(other.area);

        }
    }
}
