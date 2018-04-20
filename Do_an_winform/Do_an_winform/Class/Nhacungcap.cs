using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_winform.Class
{
    public class Nhacungcap
    {
        [DisplayName("Mã nhà cung cấp")]
        public string Manhacc { get; set; }
        [DisplayName("Tên nhà cung cấp")]
        public string Tennhacc { get; set; }
        [DisplayName("Địa chỉ nhà cung cấp")]
        public string Dcnhacc { get; set; }
        [DisplayName("Mặt hàng")]
        public string Mathang { get; set; }
    }
}
