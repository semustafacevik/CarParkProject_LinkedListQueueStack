using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_LinkedQueueStack
{
    public interface IStack
    {
        void Push(Araba yeniAraba);
        Araba Pop();
        Araba Peek();
        Boolean IsEmpty();
        int Top { get; set; }
    }
}
