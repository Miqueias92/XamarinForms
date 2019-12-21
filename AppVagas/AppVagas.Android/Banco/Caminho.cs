using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;

using AppVagas.Banco;
using System.IO;
using AppVagas.Droid.Banco;

[assembly:Dependency(typeof(Caminho))]
namespace AppVagas.Droid.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string nomeArquivoBanco)
        {
            var caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoBanco = Path.Combine(caminhoDaPasta, nomeArquivoBanco);
            return caminhoBanco;
        }
    }
}