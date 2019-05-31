using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_LinkedQueueStack
{
    public class Kat_Zemin : IQueue // Kuyruk türündeki zemin kat
    {
        public Araba[] Kuyruk;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public Stopwatch sure;

        public Kat_Zemin(int arabaSayisi)
        {
            sure = new Stopwatch();
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
            sure.Start();
            Araba cikacakAraba = Kuyruk[front];
            Kuyruk[front] = null;

            if (front == size - 1)
                front = 0;

            else
                front++;

            count--;

            sure.Stop();
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

            Araba siradakiAraba = Peek();

            foreach (Araba araba in Kuyruk)
            {
                if (araba != null)
                {
                    if (araba == siradakiAraba)
                        lstListe.Items.Add("-> " + araba.ad);

                    else
                        lstListe.Items.Add(araba.ad);
                }

                else
                {
                }// diger arabalara gec
            }
        }

        /// <summary>
        /// Bilgisayarın belirli sürede kaç adet otopark problemi çözeceğine dair sürenin saklandığı fonksiyon
        /// </summary>
        /// <returns>İlgili süre</returns>
        public double ArabaCikisSuresi()
        {
            double sure;
            sure = this.sure.Elapsed.TotalSeconds;
            return sure;
        }

    }
}
