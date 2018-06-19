﻿using SampleSyncfusion.ViewModels;
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
    public partial class GridViewMakanan : ContentPage
    {
        public GridViewMakanan()
        {
            InitializeComponent();
            this.BindingContext = new KategoriMakananViewModel();
        }
    }
}