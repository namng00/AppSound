using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSoundN.Class
{
    class Profile
    {
        private string _email;
        private string _ten;
        private string _diaChi;
        private byte _gioiTinh;
        private string _ngaySinh;
        private byte[] _avatar;
        private string _cauHoiBiMat;

        public string Email { get => _email; set => _email = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public byte GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public byte[] Avatar { get => _avatar; set => _avatar = value; }
        public string CauHoiBiMat { get => _cauHoiBiMat; set => _cauHoiBiMat = value; }

        public Profile()
        {

        }

        public Profile(string email, string ten, string diaChi, byte gioiTinh, string ngaySinh, byte[] avatar, string cauHoiBiMat)
        {
            Email = email;
            Ten = ten;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Avatar = avatar;
            CauHoiBiMat = cauHoiBiMat;
        }
    }
}
