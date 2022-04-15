using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astjkld
{
    internal class Child : Base
    {
        public double chisloa { get; set; } = 0;
        public double chislob { get; set; } = 0;
        public double chisloc { get; set; } = 0;
        public Child(double chislox, double chisloy, double chisloz, double chisloa, double chislob, double chisloc) : base(chislox, chisloy, chisloz)
        {
            this.chisloa = chisloa;
            this.chislob = chislob;
            this.chisloc = chisloc;
        }
        public double action()
        {
            return chislox * chisloa + chisloy * chislob + chisloz * chisloc;
        }
    }
}
