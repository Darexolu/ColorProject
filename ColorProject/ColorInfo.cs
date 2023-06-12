using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace ColorProject
{
   public class ColorInfo : INotifyPropertyChanged
    {
        public int ColourId { get; set; }
        public string ColorName { get; set; }
        public Color Coloring { get; set; }
        private double r;
                public double R { get => r; 
                    set { if (value == R) return;
                       r = value;
                       NotifyPropertyChanged();
                    }
                }
                private double g;
               public double G { get => g; set {
                        if (value == G) return;
                       g = value;
                      NotifyPropertyChanged();
                  }
                }
                private double b;
                public double B { get => b; set {
                       if (value == B) return;
                        b = value;
                        NotifyPropertyChanged();
                    } 
               }


              public event PropertyChangedEventHandler PropertyChanged;
               private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
               {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                }

        //        //public ICommand Save { get => value; set; }

    }
}
