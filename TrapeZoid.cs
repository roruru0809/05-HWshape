using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    public class TrapeZoid : Shape
    {
        private readonly double value;
        private double _underlineLength;
        private double _uplineLength;
        private double _height;
        public double UnderlineLength
        {
            get { return _underlineLength; }
            set { _underlineLength = value; }
        }
        public double UplineLength
        {
            get { return _uplineLength; }
            set { _uplineLength = value; }
        }
        public double height
        {
            get { return _height; }
            set { _height = value; }
        }
        public TrapeZoid() { }
        public TrapeZoid(double underlineLength,double uplineLength, double height)
        {
            this.UnderlineLength = underlineLength;
            this.UplineLength = uplineLength;
            this.height = height;
            this.CountArea();

        }

        public override void CountArea()
        {
     
            this.area = (this .UplineLength + this.UnderlineLength * this.height) / 2;
           
        }

    }
}

