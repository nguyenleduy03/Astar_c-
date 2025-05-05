using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class HDUT
    {
        private int front;
        private int rear;
        private int noItems;
        private Element[] arr;
        static readonly int max = 1000;
        public HDUT()
        {
            this.front = 0;
            this.rear = -1;
            this.noItems = 0;
            this.arr = new Element[max];
        }
        public void enQueue(Element x)
        {
            if (this.noItems == max)
                this.rear = 0;
            else
                this.rear++;

            this.arr[rear] = x; 
            this.noItems++;
        }
        public Element deQueue()
        {
            Element pt = new Element(0, 0, 0, -5);

            int j = front; 
            for (int i = 0; i <= this.rear; i++)
            {
               
                 
                if (this.arr[i].F < this.arr[front].F)  // F
                {
                    j = i;
                } 
                 
            }
            pt = arr[j];
            for (int i = j; i < this.rear; i++)
            {
                arr[i] = arr[i + 1]; 
            }
            this.rear--;
            this.noItems--;
            return pt;
        }
        public void InHangDoi()
        { 
            for (int i = this.front; i <= this.rear; i++)
            { 
                arr[i].InPhanTu();
            } 
        }
        public bool isEmpty()
        {
            if (this.noItems < 0)
                return true; 
            else 
                return false;
        } 
        public bool isFull()
        {
            if (this.noItems == max) 
                return true;
            else
                return false;
        }
    }
}
