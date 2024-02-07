using FinanApp.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanApp.Dominio.Entities
{
    public  class CartaoCredito
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int MelhorDiaCompra { get; set; }
        public int VencimentoFatura { get; set; }
        public float? LimiteGasto { get; set; }

        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public int BancoId { get; set; }
        public virtual Banco Banco { get; set; }
    }
}
