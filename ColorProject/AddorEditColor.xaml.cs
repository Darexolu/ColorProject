﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddorEditColor : ContentPage
    {
        public AddorEditColor()
        {
            InitializeComponent();
            BindingContext = new AddorEditViewModel();
        }


        private void Save(object sender, EventArgs e)
        {
            ColorInfo coloured = ((AddorEditViewModel)BindingContext).Coloured;
            if (coloured.ColourId == 0) 
                {
                    var rE = coloured.R;
                var Gr = coloured.G;
                    var Br = coloured.B;

                    coloured.Coloring = Color.FromRgb(rE % 255, Gr % 255,  Br % 255);

                }
                MessagingCenter.Send(this, "AddorEdit", coloured);
                Navigation.PopAsync();
            }

        private void Discard(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }
    }
    }


        