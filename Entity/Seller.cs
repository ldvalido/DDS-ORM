using System.Collections.Generic;
using Entity.Base;

namespace Entity
{
    public class Seller : EntityBase <int>
    {
        public string Name { get; set; }
        public string CUIL { get; set; }
        public List<Client> Clients { get; set; } 
    }
}
