﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppTurmas.BancoSqlite
{
    public interface ICaminho
    {
        string ObterCaminho(string NomeArquivoBanco);
    }
}
