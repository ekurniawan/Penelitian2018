﻿using SampleSyncfusion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleSyncfusion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddBiodata : ContentPage
    {
        public AddBiodata()
        {
            InitializeComponent();
            btnDaftar.Clicked += BtnDaftar_Clicked;
        }

        private async void BtnDaftar_Clicked(object sender, EventArgs e)
        {
            string bioID = Guid.NewGuid().ToString();
            var newBiodata = new Biodata
            {
                BiodataID = bioID,
                Nama = txtNama.Text,
                Usia = Convert.ToInt32(txtUsia.Text),
                Gender = txtGender.Text
            };

            try
            {
                //menambahkan biodata kedalam global variable
                Global.Instance.myBio.BiodataID = bioID;
                Global.Instance.myBio.Nama = txtNama.Text;
                Global.Instance.myBio.Usia = Convert.ToInt32(txtUsia.Text);
                Global.Instance.myBio.Gender = txtGender.Text;

                //menambahkan biodata kedalam sqlite
                //App.DBUtils.InsertBiodata(newBiodata);
                await DisplayAlert("Keterangan", "Tambah data biodata berhasil","OK");
                await Navigation.PushAsync(new MenuTest());
                //cek apakah data sudah masuk
                /*List<Biodata> dataBio = App.DBUtils.GetAllBiodata().ToList();
                if (dataBio.Count > 0)
                {
                    DisplayAlert("Keterangan", "Jumlah " + dataBio.Count + " dan field pertama " + dataBio[0].Nama+" - "+dataBio[0].BiodataID,"OK");
                }
                else
                {
                    DisplayAlert("Keterangan", "Data tidak ada pada list", "OK");
                }*/
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Ditemukan kesalahan " + ex.Message, "OK");
            }
           
        }
    }
}