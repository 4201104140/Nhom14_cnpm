using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_winform.Class
{
    public class Khachhang
    {
        [DisplayName("Mã khách hàng")]
        public string Makh { get; set; }

        [DisplayName("Họ khách hàng")]
        public string Hokh { get; set; }

        [DisplayName("Tên khách hàng")]
        public string Tenkh { get; set; }

        [DisplayName("Giới tính")]
        public string Gioitinh { get; set; }

        [DisplayName("Địa chỉ khách hàng")]
        public string Diachikhachhang { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime Ngaysinh { get; set; }
    }
}
