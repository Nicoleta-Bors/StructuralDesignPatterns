using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Implementarea clasei pentru meniul nou, care respectă interfața IMenuProduct
    class MenuProductNew : IMenuProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public short Quantity { get; set; }
    }
}
