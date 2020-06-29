using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using FinanApp.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Repositorio.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(FinanAppContext context) : base(context)
        {

        }
    }
}
