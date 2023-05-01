using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Facade
{

    // Facade class
    class FoodFacade
    {
        private Bors bors_rosu;
        private Coltunasi coltunasi;
        private ToppingDecorator smantana;
        private ToppingDecorator ardei;

        public FoodFacade()
        {
            bors_rosu = new Bors();
            coltunasi = new Coltunasi();
            smantana = new Smantana(coltunasi);
            ardei = new Ardei(bors_rosu);
        }

        public string GetColtunasiWithSmantana()
        {
            return smantana.GetDescription() + ", Price: " + smantana.GetPrice();
        }

        public string GetBorsWithArdei()
        {
            return ardei.GetDescription() + ", Price: " + ardei.GetPrice();
        }
    }
}
