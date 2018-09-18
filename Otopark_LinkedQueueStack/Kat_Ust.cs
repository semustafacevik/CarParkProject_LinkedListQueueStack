using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_LinkedQueueStack
{
    public class Kat_Ust : LinkedListADT
    {

        public override void InsertFirst(Araba yeniAraba)
        {
            Node tmpHead = new Node();
            tmpHead.Data = yeniAraba;

            if(Head == null)
            {
                Head = tmpHead;
                Last = Head;
            }

            else
            {
                tmpHead.Next = Head;
                Last.Next = tmpHead;
                Head = tmpHead;
            }

            size++;
        }


        public override Node Delete()
        {
            throw new NotImplementedException();
        }


    }
}
