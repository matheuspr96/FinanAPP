using FinanApp.Dominio.Interfaces;
using FinanApp.Repositorio.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FinanApp.Repositorio.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegistroServicos(IServiceCollection services)
        {
            ///Repositories
            services.AddScoped<IBancoRepository, BancoRepository>();
            services.AddScoped<IDevedorRepository, DevedorRepository>();
            services.AddScoped<IMovimentoRepository, MovimentoRepository>();
            services.AddScoped<IReceitaRepository, ReceitaRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
