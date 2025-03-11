using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    public class Triangle : Shape
    {
        private readonly double value;
        private double _underlineLength;
        private double _height;
        public double UnderlineLength
        {
            get { return _underlineLength; }
            set { _underlineLength =value; }
        }
        public double height
        {
            get { return _height; }
            set { _height = value; }
        }
        public Triangle() { }
        public Triangle(double underlineLength,double height)
        {
            this.UnderlineLength= underlineLength;
            this.height = height;
            this.CountArea();

        }

        public override void CountArea()
        {
            //把計算三角形面積的code寫在這,同時用return回傳面積 
             this.area= (this.UnderlineLength * this.height)/ 2;             
        }
    }
}
