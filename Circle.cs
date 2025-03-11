using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    public class Circle : Shape
    {
        private double _r;
        public double r
        {
            get { return _r; }
            set { _r = value; }
        }
        public Circle(double userR) { 
           this.r= userR;
            CountArea();
        }

        public override void CountArea()
        {
            this.area=this.r * this.r * 3.141516; 
         
            //throw new NotImplementedException();
        }
    }
}
