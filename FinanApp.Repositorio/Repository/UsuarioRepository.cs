using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using FinanApp.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinanApp.Repositorio.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly FinanAppContext _finanappContext;
        public UsuarioRepository(FinanAppContext context) : base(context)
        {
            _finanappContext = context;
        }

        public Usuario Obter(string email, string senha)
        {
            return _finanappContext.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
