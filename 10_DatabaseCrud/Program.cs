using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AddCategory
            //Console.WriteLine("Eklemek istediğiniz kategori adını giriniz:");
            //string categoryName=Console.ReadLine();
            SqlConnection conn=new SqlConnection("Data Source=SL11B97077\\SQLEXPRESS03; initial Catalog=EgitimKampiDb; integrated Security=true");
            //conn.Open();
            //SqlCommand cmd=new SqlCommand("insert into Tbl_Category (CategoryName) Values (@p1)", conn);
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();           
            //conn.Close();

            //Console.WriteLine("Kategori adı başarıyla eklendi :)");
            #endregion

            #region AddProduct
            //Console.WriteLine("Eklemek istediğiniz ürünün adını giriniz");
            //string productName = Console.ReadLine();
            //Console.WriteLine("Ürünün fiyatını giriniz:");
            //decimal productPrice=decimal.Parse(Console.ReadLine());
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into Tbl_Product (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)",conn);
            //cmd.Parameters.AddWithValue("@p1",productName);
            //cmd.Parameters.AddWithValue("@p2",productPrice);
            //cmd.Parameters.AddWithValue("@p3",true);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("Ürün ekleme işlemi başarıyla gerçekleşti :)");
            #endregion

            #region ProductList
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Tbl_Product",conn);
            //SqlDataAdapter adp= new SqlDataAdapter(cmd);
            //DataTable dt=new DataTable();
            //adp.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}
            //conn.Close();
            #endregion

            #region DeleteProduct
            //Console.WriteLine("Lütfen silmek istediğiniz ürünün Id'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Delete from Tbl_Product where ProductId=@p1",conn);
            //cmd.Parameters.AddWithValue("@p1",productId);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("Ürün başarıyla silindi.");
            #endregion

            #region UpdateProduct
            //Console.WriteLine("Güncellemek istediğiniz ürünün Id'sini girin:");
            //int productId = int.Parse(Console.ReadLine());
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select * from Tbl_Product where ProductId=@p1",conn);
            //cmd.Parameters.AddWithValue("@p1",productId);
            //cmd.ExecuteNonQuery();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adp.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //conn.Close();
            //conn.Open();

            //Console.WriteLine("Yeni ürün ismi");
            //string productName=Console.ReadLine();
            //Console.WriteLine("Yeni ürün fiyatı");
            //decimal productPrice = Decimal.Parse(Console.ReadLine());
            //SqlCommand cmd2=new SqlCommand("update Tbl_Product set ProductName=@p1 ,ProductPrice=@p2 where ProductId=@p3",conn);
            //cmd2.Parameters.AddWithValue("@p1",productName);
            //cmd2.Parameters.AddWithValue("@p2",productPrice);
            //cmd2.Parameters.AddWithValue("@p3",productId);
            //cmd2.ExecuteNonQuery();
            //Console.WriteLine("Ürün başarıyla güncellendi");
            //conn.Close();
            #endregion


            Console.Read();
        }
    }
}
