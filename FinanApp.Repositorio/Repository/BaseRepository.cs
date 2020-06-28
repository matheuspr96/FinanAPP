using FinanApp.Dominio.Interfaces;
using FinanApp.Repositorio.Context;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinanApp.Repositorio.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly FinanAppContext _finanAppContext;
        public BaseRepository(FinanAppContext finanAppContext)
        {
            _finanAppContext = finanAppContext;
        }

        /// <summary>
        /// Implementação do método gênerico para insert no banco
        /// </summary>
        /// <param name="entity"></param>
        public void Adicionar(TEntity entity)
        {
             _finanAppContext.Set<TEntity>().Add(entity);
            _finanAppContext.SaveChanges();
        }

        /// <summary>
        /// Implementação do método gênerico para update de uma entidade no banco
        /// </summary>
        /// <param name="entity"></param>
        public void Atualizar(TEntity entity)
        {
            _finanAppContext.Set<TEntity>().Update(entity);
            _finanAppContext.SaveChanges();
        }

        /// <summary>
        /// Implementação do método gênerico para obter uma entidade por meio de um id no banco
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity ObterPorId(int id)
        {
            return _finanAppContext.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Implementação do método gênerico para obter todos os registros da entidade no banco
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> ObterTodos()
        {
            return _finanAppContext.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Implementação do método gênerico para delete de uma entidade no banco
        /// </summary>
        /// <param name="entity"></param>
        public void Remover(TEntity entity)
        {
            _finanAppContext.Remove(entity);
            _finanAppContext.SaveChanges();

        }

        /// <summary>
        /// Método dispose do entity
        /// </summary>
        public void Dispose()
        {
            _finanAppContext.Dispose();
        }

    }
}
