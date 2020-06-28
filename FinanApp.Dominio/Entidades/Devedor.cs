using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Dominio.Entidades
{
    public class Devedor
    {
        /// <summary>
        /// Identificador do devedor
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do devedor
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Lista de movimentos financeiros do devedor
        /// </summary>
        public List<Movimento> Movimentos { get; set; }

        /// <summary>
        /// Lista de bancos que o Devedor utizou
        /// </summary>
        public List<Banco> Bancos { get; set; }
    }
}
