using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_LinkedQueueStack
{
    public class Kat_Zemin : IQueue
    {
        public Araba[] kuyruk;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public Kat_Zemin(int arabaSayisi)
        {
            size = arabaSayisi;
            kuyruk = new Araba[size];
        }

        public void Insert(Araba yeniAraba)
        {
            if (count == 0)
            {
                front = 0;
                kuyruk[++rear] = yeniAraba;
            }

            else if (rear == size - 1)
            {
                rear = 0;
                kuyruk[rear] = yeniAraba;
            }

            else
            {
                kuyruk[++rear] = yeniAraba;
            }

            count++;
        }

        public Araba Remove()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
