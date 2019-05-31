using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_LinkedQueueStack
{
    public class Kat_Ust : LinkedListADT // LinkedList türündeki üst kat
    {
        public override void InsertFirst(Araba yeniAraba)
        {
            Node tempHead = new Node();
            tempHead.Data = yeniAraba;

            Head = tempHead;
            Last = Head;

            size++;
        }

        public override void InsertLast(Araba yeniAraba)
        {
            Node oldLast = Head;

            if (Head == null)
                InsertFirst(yeniAraba);

            else
            {
                Node newLast = new Node();
                newLast.Data = yeniAraba;

                while (oldLast != null)
                {
                    if (oldLast.Next != null && oldLast.Next != Head)
                        oldLast = oldLast.Next;

                    else
                        break;
                }

                oldLast.Next = newLast;
                Last = newLast;
                newLast.Next = Head;

                size++;
            }
        }

        public override Node Delete() 
        {
            Node cikacakAraba = Head.Next;

            if (cikacakAraba == null)
                Head = null;

            Head.Next = cikacakAraba.Next;
            Head = cikacakAraba.Next;

            size--;

            if (size == 0)
            {
                Last = null;
                Head = null;
            }

            return cikacakAraba;
        } // LinkedList ten araba silme işlmei josephus problemine yapılmıştır

        public void ArabalariListele(ListBox lstListe)
        {
            lstListe.Items.Clear();

            Node tempHead = Head;

            do
            {
                if (tempHead == null)
                    break;

                else if (tempHead.Next != null)
                {
                    if (tempHead == Head.Next)
                        lstListe.Items.Add("-> " + tempHead.Data.ad);

                    else
                        lstListe.Items.Add(tempHead.Data.ad);


                    tempHead = tempHead.Next;
                }

                else // tempHead.Next == null
                    break;


            } while (tempHead != Head);
        }

    }
}
