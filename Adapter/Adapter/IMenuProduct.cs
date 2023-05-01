using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IMenuProduct
    {
        string Name { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        short Quantity { get; set; }
    }
}
