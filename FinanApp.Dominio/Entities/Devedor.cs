﻿using System;
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
        /// Email do devedor
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Lista de movimentos financeiros do devedor
        /// </summary>
        public virtual ICollection<Movimento> Movimentos { get; set; }

        /// <summary>
        /// Identificador da chave estrangeira do usuario
        /// </summary>
        public int UsuarioId { get; set; }

        /// <summary>
        /// Usuario  do devedor
        /// </summary>
        public virtual Usuario Usuario { get; set; }
    }
}
