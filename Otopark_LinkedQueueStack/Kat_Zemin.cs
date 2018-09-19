using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_LinkedQueueStack
{
    public class Kat_Zemin : IQueue
    {
        public Araba[] Kuyruk;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public Kat_Zemin(int arabaSayisi)
        {
            size = arabaSayisi;
            Kuyruk = new Araba[size];
        }

        public void Insert(Araba yeniAraba)
        {
            if (count == 0)
            {
                front = 0;
                Kuyruk[++rear] = yeniAraba;
            }

            else if (rear == size - 1)
            {
                rear = 0;
                Kuyruk[rear] = yeniAraba;
            }

            else
            {
                Kuyruk[++rear] = yeniAraba;
            }

            count++;
        }

        public Araba Remove()
        {
            Araba cikacakAraba = Kuyruk[front];
            Kuyruk[front] = null;

            if (front == size - 1)
                front = 0;

            else
                front++;

            count--;
            return cikacakAraba;
        }

        public Araba Peek()
        {
            return Kuyruk[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public void ArabalariListele(ListBox lstListe)
        {
            lstListe.Items.Clear();

            foreach (Araba arabalar in Kuyruk)
            {
                Araba siradakiAraba = Peek();

                if (arabalar != null)
                {
                    if (arabalar == siradakiAraba)
                        lstListe.Items.Add("-> " + arabalar.ad);

                    else
                        lstListe.Items.Add(arabalar.ad);
                }
                else
                { }
            }
        }

    }
}
