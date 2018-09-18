using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_LinkedQueueStack
{
    public interface IQueue
    {
        void Insert(Araba yeniAraba);
        Araba Remove();
        Boolean IsEmpty();
    }
}
