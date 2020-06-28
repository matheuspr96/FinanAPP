using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Dominio.Entidades
{
    public class Receita
    {
        /// <summary>
        /// Identificador da receita
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descrição da receita
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Valor da receita
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Usaurio ao qual pertence esta receita
        /// </summary>
        public Usuario Usuario { get; set; }
    }
}
