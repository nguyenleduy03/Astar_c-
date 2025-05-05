using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class Element
    {
        private int tenDinh;
        private int g;
        private double f;
        private int pre;
        public Element()
        {
            tenDinh = -1;
            g = 0;
            pre = -2;
            f = f;
        }
        public Element(int dinh, int chiphi, double f, int dinhtruoc)
        { 
            tenDinh = dinh;
            g = chiphi;  
            pre = dinhtruoc;
            this.f = f;
        }
        public void InPhanTu()
        { 
            Console.WriteLine($"\n {this.tenDinh}, {this.g}, {this.f}, {this.pre}");
        }
        public int TenDinh 
        {
            get { return tenDinh; }
            set { tenDinh = value; }
        }
        public int G
        { 
            get { return g; }
            set { g = value; } 
        }
        public double F 
        {
            get { return f; }
            set { f = value; } 
        }
        public int Pre 
        {
            get { return pre; }
            set { pre = value; }
        } 
    }
}
