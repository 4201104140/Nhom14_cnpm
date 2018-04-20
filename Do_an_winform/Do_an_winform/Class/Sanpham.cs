using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_winform.Class
{
    public class Sanpham
    {
        [DisplayName("Mã hàng hoá")]
        public string Mahh { get; set; }

        [DisplayName("Tên hàng hoá")]
        public string Tenhh { get; set; }

        [DisplayName("Giá bán")]
        public double Giaban { get; set; }

        [DisplayName("Nhóm hàng hoá")]
        public string Nhom { get; set; }

        [DisplayName("Tên nhà cung cấp")]
        public string Tennhacc { get; set; }

        [DisplayName("Mô tả")]
        public string Mota { get; set; }
    }
}
