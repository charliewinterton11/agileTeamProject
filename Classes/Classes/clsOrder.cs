using System;

namespace Classes
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public int CustomerNo { get; set; }
        public int OrderNo { get; set; }
        public bool Active { get; set; }
        public DateTime OrderDate { get; set; }
    }
}