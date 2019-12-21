using System;
using System.Collections.Generic;
using System.Text;

namespace AppVagas.Banco
{
    public interface ICaminho
    {
        string ObterCaminho(string nomeArquivoBanco);
    }
}
