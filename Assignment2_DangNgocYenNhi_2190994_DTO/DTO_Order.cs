using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_DangNgocYenNhi_2190994_DTO
{
    public class DTO_Order
    {
        public int IdDetails { get; set; }
        public string NameDetails { get; set; }
        public int Quantity { get; set; }
        public decimal Totail { get; set; }
        public DateTime CreatedDate { get; set; }
        public DTO_Order() { }

    }
}
