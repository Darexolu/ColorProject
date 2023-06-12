using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ColorProject
{
    public class ColorCustomViewModel : BaseMVVM
    {
        public ObservableCollection<ColorInfo> Colours { get; set; }
        //public string Colorname { get; set; } = "First Color";
        public Color RgCOLOR { get; set; }
        public ICommand AddNew { get; set; }
        public ColorCustomViewModel()
        {
            var Red = Color.Red;
            Colours = new ObservableCollection<ColorInfo>();
            Colours.Add(new ColorInfo() {ColourId = 1, ColorName = "R", Coloring = Red });
            Colours.Add(new ColorInfo() { ColourId = 2, ColorName = "G", Coloring = Color.Green });
            Colours.Add(new ColorInfo() {  ColourId =3, ColorName = "B", Coloring = Color.Blue });
            Colours.Add(new ColorInfo() { ColourId = 4, ColorName = "A(First Color)", Coloring = Color.Aqua });

            MessagingCenter.Subscribe<AddorEditColor, ColorInfo>(this, "AddorEdit",(page,coloured)=> {
                if(coloured.ColourId == 0)
                {
                    coloured.ColourId = Colours.Count + 1;
                    Colours.Add(coloured);
                    NotifyPropertyChanged();
                }
                

            });

            //Colours = new List<Color> { Color.R,}

        }
    }
}
