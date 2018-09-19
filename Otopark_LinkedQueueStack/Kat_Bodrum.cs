using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_LinkedQueueStack
{
    public class Kat_Bodrum : IStack
    {
        public Araba[] Yigin;
        private int _top = -1;

        public Kat_Bodrum(int arabaSayisi)
        {
            Yigin = new Araba[arabaSayisi];
        }

        public void Push(Araba yeniAraba)
        {
            Yigin[++Top] = yeniAraba;
        }

        public Araba Pop()
        {
            Araba cikacakAraba = Yigin[Top];
            Yigin[Top] = null;
            Top--;

            return cikacakAraba;
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public Araba Peek()
        {
            return Yigin[Top];
        }

        public int Top
        {
            get
            {
                return _top;
            }

            set
            {
                _top = value;
            }
        }

        public void ArabalariListele(ListBox lstListe)
        {
            lstListe.Items.Clear();

            foreach (Araba arabalar in Yigin)
            {
                Araba siradakiAraba;

                if (Top == -1)
                    siradakiAraba = null;
                else
                    siradakiAraba = Peek();

                if (arabalar != null)
                {
                    if (arabalar == siradakiAraba)
                        lstListe.Items.Add("-> " + arabalar.ad);
                    else
                        lstListe.Items.Add(arabalar.ad);
                }
                else
                    break;
            }
        }


    }
}
