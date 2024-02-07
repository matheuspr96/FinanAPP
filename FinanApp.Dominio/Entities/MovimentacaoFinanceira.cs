using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FinanApp.Dominio.Entidades
{
    public class MovimentacaoFinanceira
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public decimal Valor { get; set; }
        public bool Efetivada { get; set; }
        public DateTime DataMovimento { get; set; }

        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public string Data { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
