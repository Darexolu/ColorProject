using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProjectColor : ContentPage
	{
		public ProjectColor ()
		{
			InitializeComponent ();
			BindingContext =  new ColorCustomViewModel();
		}

        private async void Add_New(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new AddorEditColor());
        }
        private async void Navigate_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdateorDelete());
        }
    }
}