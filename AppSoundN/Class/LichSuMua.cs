using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSoundN.Class
{
    class LichSuMua
    {
        private string _id_buy;
        private string _ngaymua;

        public string Id_buy { get => _id_buy; set => _id_buy = value; }
        public string Ngaymua { get => _ngaymua; set => _ngaymua = value; }
        public LichSuMua()
        {

        }

        public LichSuMua(string id_buy, string ngaymua)
        {
            Id_buy = id_buy;
            Ngaymua = ngaymua;
        }
    }
}
