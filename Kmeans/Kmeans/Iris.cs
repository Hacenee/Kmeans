using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMeans
{
    class Iris
    {
        private double v1;
        private double v2;
        private double v3;
        private double v4;
        private string label;

        public Iris(double v1, double v2, double v3, double v4, string label)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v4 = v4;
            this.v3 = v3;
            this.label = label;
        }

        public double Distance(Iris b)
        {
            // A compléter
            return 0;
        }

        public override string ToString()
        {
            return "(" + v1 + " " + v2 + " " + v3 + " " + v4 + ") ; " + this.label;
        }

    }
}
