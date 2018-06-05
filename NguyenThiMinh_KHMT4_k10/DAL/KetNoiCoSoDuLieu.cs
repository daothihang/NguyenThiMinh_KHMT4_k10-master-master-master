using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class KetNoiCoSoDuLieu
    {
        
        private static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings
            ["KETNOIQLHS"].ToString());

        public static SqlConnection KetNoi
        {
            get { return KetNoiCoSoDuLieu.conn; }
        }

        public static void MoKetNoi()
        {
            conn.Open();
        }
        public static void DongKetNoi()
        {
            conn.Close();
        }
    }
}
