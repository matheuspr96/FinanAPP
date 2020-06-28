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
        /// Data que foi feito o movimento
        /// </summary>
        public DateTime DataMovimento { get; set; }

        /// <summary>
        /// Identificador da chava estrangeira do devedor
        /// </summary>
        public int DevedorId { get; set; }

        /// <summary>
        /// Pessoa que realizou o movimento financeiro
        /// </summary>
        public virtual Devedor Devedor { get; set; }

        /// <summary>
        /// Identificador da chava estrangeira do banco que o devedor deve
        /// </summary>
        public int BancoId { get; set; }

        /// <summary>
        /// Banco utilizado para fazer o movimento financeiro
        /// </summary>
        public virtual Banco Banco { get; set; }
    }
}
