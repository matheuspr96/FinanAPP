using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Receita> Receitas { get; set; }
        public virtual ICollection<MovimentacaoFinanceira> MovimentacaoFinanceira { get; set; }
        public virtual ICollection<Banco> Bancos { get; set; }

    }
}
