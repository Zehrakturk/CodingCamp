using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using video5_odev5.Entitiy;

namespace video5_odev5.Abstract
{
    internal interface IGameSalesService
    {
        void AddToCart(Gamer gamer,Game game, Campaign campaign);
        void DeleteToCart(Gamer gamer,Game game, Campaign campaign);

    }
}
