using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBuscaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BairroByCidade_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new View.BairrosPorCidade());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
