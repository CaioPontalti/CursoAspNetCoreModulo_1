﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjecaoDependencia.Services
{
    public class EmailService : IEmailService
    {
        public string EnviarEmail()
        {
            return "Email enviado com sucesso.";
        }
    }
}
