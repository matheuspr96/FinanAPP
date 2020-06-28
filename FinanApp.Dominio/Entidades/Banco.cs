using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Dominio.Entidades
{
    public class Banco
    {
        /// <summary>
        /// Identificador do banco do usuário
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do banco do usuário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Valor atual da fatura do banco
        /// </summary>
        public decimal ValorFatura { get; set; }

        /// <summary>
        /// Data em (DD/MM/AAAA) do vencimento da fatura
        /// </summary>
        public DateTime VencimentoFatura { get; set; }

        /// <summary>
        /// Usuário ao qual pertence este banco
        /// </summary>
        public Usuario Usuario { get; set; }
    }
}
