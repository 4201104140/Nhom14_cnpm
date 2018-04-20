using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_winform.Class
{
    public class Nhanvien
    {
        [DisplayName("Mã nhân viên")]
        public string Manv { get; set; }
        [DisplayName("Họ nhân viên")]
        public string Holot { get; set; }
        [DisplayName("Tên nhân viên")]
        public string Tennv { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime Ngaysinh { get; set; }
        [DisplayName("Ngày vào làm")]
        public DateTime Ngayvaolam { get; set; }
    }
}
