using AppVagas.Banco;
using AppVagas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVagas.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultarVagas : ContentPage
	{
		public ConsultarVagas ()
		{
			InitializeComponent ();

            listaVagas.ItemsSource = new Database().Consultar();
		}

        public void goCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVaga());
        }

        public void goMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        public void goMaisDetalheAction(object sender, EventArgs args)
        {
            Label label = (Label)sender;
            var vaga = ((TapGestureRecognizer)label.GestureRecognizers.First()).CommandParameter as Vaga;
           
            Navigation.PushAsync(new DetalheVaga(vaga));
        }
    }
}