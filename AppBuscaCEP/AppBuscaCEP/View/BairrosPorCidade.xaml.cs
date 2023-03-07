using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBuscaCEP.Model;
using AppBuscaCEP.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCEP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BairrosPorCidade : ContentPage
    {
        public BairrosPorCidade()
        {
            InitializeComponent();
        }

        private void pesquisar_cidade_Clicked(object sender, EventArgs e)
        {
            try
            {
                BindingContext = new Cidade()
                {
                    
                };
               
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
    }
