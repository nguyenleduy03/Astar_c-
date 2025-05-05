using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class Point
    { 
        private double x;
        private double y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x; 
            this.y = y;
        }
        //Tính Euclide
        public double h(Point d)
        {
            double kq;  
            double kq1 = Math.Pow(this.x - d.x, 2); 
            double kq2 = Math.Pow(this.y - d.y, 2); 
            kq = Math.Sqrt(kq1 + kq2); 
            return kq;
        }
        public void inToaDo() 
        {
            Console.WriteLine($"{x.ToString(CultureInfo.InvariantCulture)}, {y.ToString(CultureInfo.InvariantCulture)}"); 
        }
    }
}
