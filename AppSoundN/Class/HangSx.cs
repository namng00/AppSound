using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSoundN.Class
{
    class HangSx
    {
        private string _tenHang;
        private string _thongTinHang;
        private string _linkHang;

        public string TenHang { get => _tenHang; set => _tenHang = value; }
        public string ThongTinHang { get => _thongTinHang; set => _thongTinHang = value; }
        public string LinkHang { get => _linkHang; set => _linkHang = value; }
        public HangSx()
        {

        }

        public HangSx(string tenHang, string thongTinHang, string linkHang)
        {
            TenHang = tenHang;
            ThongTinHang = thongTinHang;
            LinkHang = linkHang;
        }
    }
}
