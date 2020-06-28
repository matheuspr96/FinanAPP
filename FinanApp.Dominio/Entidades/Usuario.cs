using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Dominio.Entidades
{
    public class Usuario
    {
        /// <summary>
        /// Identificador do usuário
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do usuário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Email do usuário
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// Salário recebido pelo usuario
        /// </summary>
        public decimal Salario { get; set; }

        /// <summary>
        /// Lista de receitas do usuário
        /// </summary>
        public virtual ICollection<Receita> Receitas { get; set; }

        /// <summary>
        /// Lista de bancos do usuário
        /// </summary>
        public virtual ICollection<Banco> Bancos { get; set; }

        /// <summary>
        /// Lista de devedores que o usuário possui
        /// </summary>
        public virtual ICollection<Devedor> Devedores { get; set; }
    }
}
