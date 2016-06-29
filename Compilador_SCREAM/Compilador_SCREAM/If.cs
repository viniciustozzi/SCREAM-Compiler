﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador_SCREAM
{
    public class If : Instrucao
    {
        public Expressao expressao { get; set; }
        public Bloco bloco { get; set; }

        public override string ToCode()
        {
            return "if (" + expressao.ToCode() + ")" + bloco.ToCode();
        }
    }
}