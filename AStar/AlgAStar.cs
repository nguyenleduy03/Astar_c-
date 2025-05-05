using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class AlgAStar
    {
        private HDUT OPEN;
        private Element[] CLOSE;
        private Dothii dt;
        private static readonly int NIL = -5;
        public AlgAStar() 
        {
            dt = new Dothii();
            OPEN = new HDUT();
            CLOSE = new Element[dt.SoDinh];
            for (int i = 0; i < dt.SoDinh; i++) 
            {
                CLOSE[i] = new Element(i, 0, 0, -2); 
            }
            double hStart = dt.DsPoint[dt.Start].h(dt.DsPoint[dt.Goal]); 
            double fStart = hStart + 0;
            Element T0 = new Element(0, 0, fStart, NIL);
            OPEN.enQueue(T0); 
        }
        public void timKiemAstar() 
        {
            while (!OPEN.isEmpty()) 
            {
                Element Tmax = OPEN.deQueue(); 

                if (CLOSE[Tmax.TenDinh].Pre != -2) 
                    continue;
                CLOSE[Tmax.TenDinh] = Tmax;
                 
                if (Tmax.TenDinh == dt.Goal)
                {
                    Console.WriteLine("\nTim thay duong di!"); 

                    return; 
                }

                else 
                {

                    for (int tk = 0; tk < dt.SoDinh; tk++) 
                    {
                        if (dt.MaTran[Tmax.TenDinh, tk] > 0 && CLOSE[tk].Pre == -2) 
                        {
                            int tk_g = Tmax.G + dt.MaTran[Tmax.TenDinh, tk];
                            double tk_h = dt.DsPoint[tk].h(dt.DsPoint[dt.Goal]);
                            double tk_f = tk_g + tk_h;


                            if (tk == Tmax.TenDinh && tk_h < Tmax.G)
                            {
                                Element X = new Element(Tmax.TenDinh, tk_g, tk_f, Tmax.Pre);

                                OPEN.enQueue(X);
                            }

                            else if (tk == CLOSE[Tmax.TenDinh].TenDinh && tk_g < CLOSE[Tmax.TenDinh].G)
                            {
                                Element Y = new Element(CLOSE[Tmax.TenDinh].TenDinh, tk_g, tk_f, CLOSE[Tmax.TenDinh].Pre);

                                OPEN.enQueue(Y);
                            }

                            else
                            {
                                Element Z = new Element(tk, tk_g, tk_f, Tmax.TenDinh);

                                OPEN.enQueue(Z);
                            }
                        }
                    }
                }
            }
        }
        public void InDuongDi()
        {
            if (CLOSE[dt.Goal].Pre == -2)
                Console.WriteLine("KHONG tim duoc");
            else
            {
                int current = dt.Goal;
                System.Console.Write("Duong di: ");
                while (current != dt.Start && CLOSE[current].Pre != NIL)
                {
                    Console.Write($"{current} <== ");
                    current = CLOSE[current].Pre;
                }
                Console.WriteLine($"{dt.Start}");
                Console.WriteLine($"Tong chi phi (G): {CLOSE[dt.Goal].G}");
                Console.WriteLine($"Tong chi phi (F): {CLOSE[dt.Goal].F}");
            }
        }
    }
}
