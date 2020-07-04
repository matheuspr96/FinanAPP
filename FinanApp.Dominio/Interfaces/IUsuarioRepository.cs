using FinanApp.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Dominio.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario Obter(string email, string senha);
    }
}
