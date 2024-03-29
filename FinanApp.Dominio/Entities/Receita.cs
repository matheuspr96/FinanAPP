﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Dominio.Entidades
{
    public class Receita
    {
        public int Id { get; set; }

        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataReceita { get; set; }
        public float? LimiteMensal { get; set; }

        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
