using Entity.Base;

namespace Entity
{
    public class SKU : EntityBase <int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
