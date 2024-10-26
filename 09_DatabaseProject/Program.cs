using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Kategoriler \n 2- Ürünler \n 3- Siparişler");
            Console.WriteLine("Lütfen verilerini görmek istediğiniz tablo numarasını giriniz: ");
            string tableNumber=Console.ReadLine();

            SqlConnection conn=new SqlConnection("Data Source=SL11B97077\\SQLEXPRESS03; initial Catalog=EgitimKampiDb; integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Category",conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            adp.Fill(dt);
            conn.Close();

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }




            Console.Read();
        }
    }
}
