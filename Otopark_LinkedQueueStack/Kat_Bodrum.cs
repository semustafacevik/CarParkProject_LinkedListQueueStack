using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_LinkedQueueStack
{
    public class Kat_Bodrum : IStack
    {
        public Araba[] yigin;
        private int top = -1;

        public Kat_Bodrum(int arabaSayisi)
        {
            yigin = new Araba[arabaSayisi];
        }

        public void Push(Araba yeniAraba)
        {
            yigin[++Top] = yeniAraba;
        }

        public Araba Pop()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public int Top
        {
            get
            {
                return top;
            }

            set
            {
                top = value;
            }
        }
    }
}
