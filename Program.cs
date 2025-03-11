// See https://aka.ms/new-console-template for more information
using shape;

//Shape myshape = new Shape();

Shape mycircle = new Circle(6);

Shape myTrianble = new Triangle(30,10);

Shape myTrapeZoide = new TrapeZoid(20, 10,5);





Console.WriteLine("圓形:" + mycircle.area.ToString());
Console.WriteLine("三角形:" + myTrianble.area.ToString());
Console.WriteLine("梯形:" + myTrapeZoide.area.ToString());
string msg = "";

if (mycircle.CompareTo(myTrianble) == 0 && mycircle.CompareTo(myTrapeZoide) == 0)
    msg = "一樣大";
else if (mycircle.CompareTo(myTrianble) >= 0 && mycircle.CompareTo(myTrapeZoide) >= 0)
    msg = "圓形最大";
else if (myTrianble.CompareTo(mycircle) >= 0 && myTrianble.CompareTo(myTrapeZoide) >= 0)
    msg = "三角形最大";
else
    msg = "梯形最大";

Console.WriteLine(msg);