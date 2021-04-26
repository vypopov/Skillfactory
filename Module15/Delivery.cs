using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15
{
    abstract class Delivery
    {
        string Adress;
        string Phone;
        Delivery(string Adress, string Phone);
    }
    class PickPoint : Delivery
    {
        string Adress;
        PickPoint(string Adress) : base(Adress);
    
    }
}
