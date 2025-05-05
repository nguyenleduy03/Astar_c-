using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AStar
{
    class Dothii
    {
        private int sodinh;
        private int start;
        private int goal;
        private Point[] dsPoint;
        private int[,] matran;
        //Hàm khởi tạo lớp DoThi 
        public Dothii()
        {
            this.sodinh = -1;
            this.start = -1;
            this.dsPoint = new Point[12];
            this.matran = new int[12, 12];
            DocDoThi();
        }
        //Hàm đọc đồ thị từ tệp text 
        public void DocDoThi() 
        {
            //Đường đẫn tuyệt đối 
            string textFile = @"D:\NGUYENLEDUY\AStar\AStar\AstarInput.txt"; 

            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);
                string line0 = lines[0].Trim();
                this.sodinh = int.Parse(line0);

                string line1 = lines[1].Trim();
                string[] tam = line1.Split(' ');
                this.start = int.Parse(tam[0]);
                this.goal = int.Parse(tam[1]);

                for (int i = 0; i < this.sodinh; i++)
                {
                    string linei = lines[i + 2].Trim();
                    string line2 = linei.Substring(1, linei.Length - 2);
                    string[] arr = line2.Split(',');
                    this.dsPoint[i] = new Point(double.Parse(arr[0], CultureInfo.InvariantCulture), double.Parse(arr[1], CultureInfo.InvariantCulture));
                }
                for (int i = 0; i < this.sodinh; i++)
                {
                    string linei = lines[i + 14].Trim();
                    string[] arr = linei.Split(' ');
                    for (int j = 0; j < this.sodinh; j++)
                    {
                        this.matran[i, j] = int.Parse(arr[j]);
                    }
                }
            }
        }
        //Hàm in đồ thị ra màn hình 
        public void InDoThi()
        {
            Console.WriteLine($"So dinh: {this.sodinh}");
            Console.WriteLine($"Start: {this.start}\nGoal: {this.goal}");
            Console.WriteLine($"\ntoa do: ");
            for (int i = 0; i < this.sodinh; i++)
            {
                Console.Write($"\nToa do diem {i}: ");
                this.dsPoint[i].inToaDo();
            }

            Console.WriteLine("\nMa tran:");
            for (int i = 0; i < this.sodinh; i++)
            {
                for (int j = 0; j < this.sodinh; j++)
                {
                    Console.Write(this.matran[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        //GET và SET các thuộc tính 
        public int SoDinh
        {
            get { return sodinh; }
            set { sodinh = value; }
        }
        public int Start
        {
            get { return start; }
            set { start = value; }
        }
        public int Goal
        {
            get { return goal; }
            set { goal = value; } 
        }
        public int[,] MaTran 
        { 
            get { return matran; }
            set { matran = value; } 
        }
        internal Point[] DsPoint 
        {
            get { return dsPoint; } 
            set { dsPoint = value; } 
        }
    }
}
