using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection("Server=SL11B97077\\SQLEXPRESS03;initial Catalog=EgitimKampiDb501;integrated security=true;");

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query1 = "select Count(*) from TblProduct";
            var productTotalCount = await conn.QueryFirstOrDefaultAsync<int>(query1);
            lblProductCount.Text = productTotalCount.ToString();

            string query2 = "select ProductName from TblProduct where ProductPrice=(select Max(ProductPrice) from TblProduct)";
            var maxPriceBook = await conn.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPriceBook.Text = maxPriceBook.ToString();

            string query3 = "select Count(Distinct(ProductCategory)) from TblProduct";
            var distinctProductCount = await conn.QueryFirstOrDefaultAsync<int>(query3);
            lblCategoryCount.Text = distinctProductCount.ToString();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from TblProduct";
            var values=await conn.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //string query = "insert into TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory) values ('" + productName + "','" + productStock + "','" + productPrice + "','" + productCategory + "')";
            string query = "insert into TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory) values (@productName,@productStock,@productPrice,@productCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName",productName.Text);
            parameters.Add("@productStock",productStock.Text);
            parameters.Add("@productPrice", productPrice.Text);
            parameters.Add("@productCategory", productCategory.Text);
            await conn.ExecuteAsync(query,parameters);
            MessageBox.Show("Ekleme işlemi başarılı!");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from TblProduct where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", productId.Text);
            await conn.ExecuteAsync(query, parameters);
            MessageBox.Show("Silme işlemi başarılı!");
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            string query = "update TblProduct set ProductName=@productName, ProductStock=@productStock,ProductPrice=@productPrice,ProductCategory=@productCategory where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", productId.Text);
            parameters.Add("@productName", productName.Text);
            parameters.Add("@productStock", productStock.Text);
            parameters.Add("@productPrice", productPrice.Text);
            parameters.Add("@productCategory", productCategory.Text);
            await conn.ExecuteAsync(query, parameters);
            MessageBox.Show("GÜncelleme işlemi başarılı!","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
