using AppBuscaCEP.Model;
using AppBuscaCEP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCEP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnderecoByCep : ContentPage
    {
        public EnderecoByCep()
        {
            InitializeComponent();
        }

        private async void busca_Clicked(object sender, EventArgs e)
        {

            try
            {
                carregando.IsRunning = true;
                carregando.IsVisible = true;

                string end = await DataService.GetEnderecoByCep(txt_cep.Text);

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            finally
            {
                carregando.IsRunning = false;
                carregando.IsVisible = false;
            }
        }

    }
    }
