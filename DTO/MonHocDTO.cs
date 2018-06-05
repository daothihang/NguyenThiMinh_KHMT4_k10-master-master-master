using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHocDTO
    {
        
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int Sotiet { get; set; }

        public MonHocDTO() { }
        public MonHocDTO(string mamon,string tenmon,int sotiet)
        {
            this.MaMon = mamon;
            this.TenMon = tenmon;
            this.Sotiet = sotiet;
                
        }
    }
}
