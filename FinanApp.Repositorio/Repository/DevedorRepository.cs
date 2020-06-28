using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using FinanApp.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Repositorio.Repository
{
    public class DevedorRepository : BaseRepository<Devedor>, IDevedorRepository
    {
        public DevedorRepository(FinanAppContext context) : base(context)
        {

        }
    }
}
