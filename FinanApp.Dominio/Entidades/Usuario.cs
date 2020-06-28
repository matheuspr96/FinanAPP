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
        /// Salário recebido pelo usuario
        /// </summary>
        public decimal Salario { get; set; }

        /// <summary>
        /// Lista de receitas do usuário
        /// </summary>
        public List<Receita> Receitas { get; set; }
    }
}
