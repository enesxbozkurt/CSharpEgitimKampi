﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db=new EgitimKampiEfTravelDbEntities();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values=db.Guide.Select(x => new 
            {   
                FullName=x.GuideName +" "+x.GuideSurname,x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values=db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.City = txtCity.Text;
            location.Country=txtCountry.Text;
            location.Capacity = Byte.Parse(nudCapacity.Value.ToString());
            location.Price=int.Parse(txtPrice.Text.ToString());
            location.DayNight = txtDayNight.Text;
            location.GuideId=int.Parse(cmbGuide.SelectedIndex.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.ToString());
            var deletedValue=db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.ToString());
            var updatedValues=db.Location.Find(id);
            updatedValues.City= txtCity.Text;
            updatedValues.Country= txtCountry.Text;
            updatedValues.Capacity=byte.Parse(nudCapacity.Value.ToString());
            updatedValues.Price = decimal.Parse(txtPrice.Text.ToString());
            updatedValues.DayNight= txtDayNight.Text;
            updatedValues.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı!");
        }
    }
}
