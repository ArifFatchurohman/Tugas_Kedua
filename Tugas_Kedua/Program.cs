using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Kedua
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateDatabase();
            new Program().InsertDatabase();
        }

        public void CreateDatabase()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-3QOIRAE6; database=ArifFatchurohman; Integrated Security = TRUE");
                con.Open();

                SqlConnection cm = new SqlConnection(
                "Create Tabel Karyawan(id_karyawan varchar(10) not null primary key, nama_karyawan varchar(30), email varchar(30))", con);
                "Create Tabel Obat(id_barang char(10) not null primary key, nama_barang varchar(20), jmlh_barang char(10), harga_satuan char(10), jmlh_harga char(20), tgl_pembelian date)", con);
                "Create Tabel Konsumen(id_konsumen char(10) not null primary key, nama_konsumen varchar(20), no_tlpn char(10))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }

    }
}
