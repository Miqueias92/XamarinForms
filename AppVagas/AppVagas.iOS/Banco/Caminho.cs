﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppVagas.Banco;
using Foundation;
using UIKit;
using Xamarin.Forms;
using System.IO;

[assembly:Dependency(typeof(AppVagas.iOS.Banco.Caminho))]
namespace AppVagas.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string nomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoDaBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");
            string caminhoBanco = Path.Combine(caminhoDaBiblioteca, nomeArquivoBanco);

            return caminhoBanco;
        }
    }
}