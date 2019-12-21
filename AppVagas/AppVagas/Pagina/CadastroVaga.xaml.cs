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
	public partial class CadastroVaga : ContentPage
	{
		public CadastroVaga ()
		{
			InitializeComponent ();
		}

        public void goSalvar(object sender, EventArgs args)
        {
            var vaga = new Vaga();

            // TODO - validar os dados do cadastro
            vaga.NomeVaga = Vaga.Text;
            vaga.Empresa = Empresa.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Cidade = Cidade.Text;
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = TipoContratacao.IsToggled ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            new Database().Cadastro(vaga);
            Navigation.PopAsync();
        }
    }
}