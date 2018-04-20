using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_winform.Class
{
    public class Phieubanhang
    {
        [DisplayName("Mã phiếu bán hàng")]
        public string Maphieubanhang { get; set; }
        [DisplayName("Mã khách hàng")]
        public string Makhachhang { get; set; }
        [DisplayName("Mã nhân viên")]
        public string Manhanvien { get; set; }
        [DisplayName("Tên khách hàng")]
        public string Tenkhachhang { get; set; }
        [DisplayName("Tên nhân viên")]
        public string Tennhanvien { get; set; }
        [DisplayName("Địa chỉ khách hàng")]
        public string Diachi { get; set; }
        [DisplayName("Ngày lập")]
        public DateTime Ngaylap { get; set; }
        [DisplayName("Tổng tiền")]
        public double Tongtien { get; set; }
    }
}
