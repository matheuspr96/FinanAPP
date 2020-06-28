using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FinanApp.Dominio.Entidades
{
    public class Movimento
    {
        /// <summary>
        /// Identificador do movimento financeiro
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descrição do movimento financeiro
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Valor em R$ do movimento financeiro
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Pessoa que realizou o movimento financeiro
        /// </summary>
        public Devedor Devedor { get; set; }

        /// <summary>
        /// Banco utilizado para fazer o movimento financeiro
        /// </summary>
        public Banco Banco { get; set; }
    }
}
