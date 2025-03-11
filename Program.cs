// See https://aka.ms/new-console-template for more information
using Shape001;

Shape mycircle = new Circle(5);
Shape myTriangle = new Triangle(30, 10.2);
Shape myTrapeZoid = new TrapeZoid(3.8, 10, 5);
Shape maxShape = mycircle;

if (myTriangle.CompareTo(maxShape) > 0)
    maxShape = myTriangle;

if (myTrapeZoid.CompareTo(maxShape) > 0)
    maxShape = myTrapeZoid;
Console.WriteLine("圓形的面積 " + mycircle.area.ToString());
Console.WriteLine("三角形的面積 " + myTriangle.area.ToString());
Console.WriteLine("梯形的面積 " + myTrapeZoid.area.ToString());
Console.WriteLine("最大面積的圖形是: " + maxShape.GetType().Name + "，面積為: " + maxShape.area.ToString());
    