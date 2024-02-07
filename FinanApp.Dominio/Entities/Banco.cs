using FinanApp.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Dominio.Entidades
{
    public class Banco
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<CartaoCredito> CartaoCreditoCollection { get; set; }

    }
}
