using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{

    // Definim clasa adapter care convertește un MenuProductOld într-un IMenuProduct
    class MenuProductOldAdapter : IMenuProduct
    {
        private MenuProductOld _menuProductOld;

        public MenuProductOldAdapter(MenuProductOld menuProductOld)
        {
            _menuProductOld = menuProductOld;
        }

        public string Name
        {
            get { return _menuProductOld.ItemName; }
            set { _menuProductOld.ItemName = value; }
        }

        public string Description
        {
            get { return _menuProductOld.Desc; }
            set { _menuProductOld.Desc = value; }
        }

        public decimal Price
        {
            get { return _menuProductOld.ItemCost; }
            set { _menuProductOld.ItemCost = value; }
        }

        public short Quantity
        {
            get { return _menuProductOld.Quant; }
            set { _menuProductOld.Quant = value; }
        }
    }
}
