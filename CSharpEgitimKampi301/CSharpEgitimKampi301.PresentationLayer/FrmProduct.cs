﻿using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductName = txtProductName.Text;
            product.ProductDescription=txtDescription.Text;
            product.ProductStock=int.Parse(txtProductStock.Text);
            _productService.TInsert(product);
            MessageBox.Show("Ekleme işlemi başarıyla tamamlandı.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value=_productService.TGetById(id);
            _productService.TDelete(value);
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtProductId.Text);
            var value= _productService.TGetById(id);
            dataGridView1.DataSource = new List<Product> { value };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            value.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductName = txtProductName.Text;
            value.ProductDescription = txtDescription.Text;
            value.ProductStock = int.Parse(txtProductStock.Text);
            _productService.TUpdate(value);
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı.");
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values=_categoryService.TGetAll();
            cmbCategory.DataSource=values;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }
    }
}
