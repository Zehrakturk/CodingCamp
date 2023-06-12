using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using video5_odev5.Entitiy;

namespace video5_odev5.Abstract
{
    internal interface IGamerManagerService
    {
        void Record(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
