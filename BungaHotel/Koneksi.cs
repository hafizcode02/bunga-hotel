using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BungaHotel
{
    public class Koneksi
    {
        public static string database = ("Data Source=DESKTOP-K1NGH4;Initial Catalog=bungahotel;Integrated Security=True");
        public SqlConnection koneksi = new SqlConnection(database);
        public SqlCommand cmd;
        public SqlDataAdapter adp = new SqlDataAdapter();
        public SqlDataReader dr;
        public DataTable dt;
        
        public void select(string query)
        {
            try
            {
                dt.Clear();
                koneksi.Open();
                cmd = new SqlCommand(query, koneksi);
                adp.SelectCommand = cmd;
                adp.Fill(dt);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        public void cud(string query)
        {
            try
            {
                koneksi.Open();
                cmd = new SqlCommand(query, koneksi);
                dr = cmd.ExecuteReader();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

    }
}
