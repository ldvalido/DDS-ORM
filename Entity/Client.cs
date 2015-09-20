using System.Collections.Generic;
using Entity.Base;

namespace Entity
{
    public class Client : EntityBase<int>
    {
        public string Name { get; set; }
        public string CUIL { get; set; }
        public List<Seller> Selers { get; set; } 
    }
}
