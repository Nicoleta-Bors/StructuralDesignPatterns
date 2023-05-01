using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Implementarea clasei pentru meniul vechi, care are o structură diferită fata de meniul nou
    class MenuProductOld
    {
        public string ItemName { get; set; }
        public decimal ItemCost { get; set; }
        public string Desc { get; set; }
        public short Quant { get; set; }
    }
}
