using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_lab_4
{
    class Queue
    {
        private string[] queue;
        private int maxSize;
        private int nElem;
        private int front;
        private int rear;

        public Queue(int maxSize)
        {
            this.maxSize = maxSize;
            queue = new string[maxSize];
            rear = -1;
            front = 0;
            nElem = 0;
        }

        public void insert(string elem)
        {
            if (rear == maxSize - 1)
                rear = -1;

            queue[++rear] = elem;
            nElem++;
        }

        public string remove()
        {
            string temp = queue[front++];

            if (front == maxSize)
                front = 0;

            nElem--;
            return temp;
        }

        public string getFront() { return queue[front]; }
        public string getRear() { return queue[rear]; }
        public bool isFull() {  return nElem == maxSize - 1; }
        public bool isEmpty() { return nElem == 0; }
        public int getSize() {  return nElem; }
    }
}
