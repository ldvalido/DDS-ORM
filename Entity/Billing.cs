using System.Collections.Generic;
using Entity.Base;

namespace Entity
{
    public class Billing: EntityBase<int>
    {
        public Client Client { get; set; }
        public List<SKU> SKUs { get; set; }
        public double Total { get; set; }
    }
}
