using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using FinanApp.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Repositorio.Repository
{
    public class MovimentoRepository : BaseRepository<MovimentacaoFinanceira>, IMovimentoRepository
    {
        public MovimentoRepository(FinanAppContext context) : base(context)
        {

        }
    }
}
