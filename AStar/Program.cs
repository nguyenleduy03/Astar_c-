using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class mainAstar
    {
        static void Main(string[] args)
        {
            
            //1. Đọc và in đồ thị
            //Dothii dt = new Dothii();
            //dt.DocDoThi();
            //dt.InDoThi();
            //Console.WriteLine();
           
            
            //2. Test tính khoảng cách Euclide của 2 điểm
            Point X = new Point(11.3, 4);
            Point goal = new Point(0, 0); 
            double kq = X.h(goal); 
            Console.WriteLine("ket qua la: " + kq);


            //3.Test Hàng đợi ưu tiên
            Element pt1 = new Element(4, 9, 18, 0);
            Element pt2 = new Element(5, 1, 12, 0); 

            HDUT q = new HDUT(); 
            q.enQueue(pt1);
            q.enQueue(pt2);
            Element Y = q.deQueue(); // Kết quả là (5, 1, 12, 0)
            Y.InPhanTu();
            Console.WriteLine();


            //4. Kiểm tra Astar 
            AlgAStar astar = new AlgAStar();
            astar.timKiemAstar();
            Console.WriteLine();
            astar.InDuongDi();

             
            Console.ReadLine();

        }
    }
}
