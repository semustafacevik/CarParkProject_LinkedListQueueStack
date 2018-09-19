using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_LinkedQueueStack
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public Node Last;
        public int size;

        public abstract void InsertFirst(Araba yeniAraba);
        public abstract void InsertLast(Araba yeniAraba);
        public abstract Node Delete();
    }
}
