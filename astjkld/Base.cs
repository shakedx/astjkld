using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astjkld
{
    public class Base
    {
        public double chislox { get; set; } = 0;
        public double chisloy { get; set; } = 0;
        public double chisloz { get; set; } = 0;

        public Base(double chislox, double chisloy, double chisloz)
        {
            this.chislox = chislox;
            this.chisloy = chisloy;
            this.chisloz = chisloz;
        }
    }
}
