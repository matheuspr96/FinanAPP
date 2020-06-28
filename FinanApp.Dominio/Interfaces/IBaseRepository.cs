using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Dominio.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        /// <summary>
        /// Método gênerico para inserir no banco
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Adicionar(TEntity entity);

        /// <summary>
        /// Método gênerico para selecionar uma entidade no banco
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity ObterPorId(int id);

        /// <summary>
        /// Método gênerico para selecionar toda as entidades no banco
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> ObterTodos();

        /// <summary>
        /// Método gênerico para atualizar entidade no banco
        /// </summary>
        /// <param name="entity"></param>
        void Atualizar(TEntity entity);

        /// <summary>
        /// Método gênerico para remover uma entidade no banco
        /// </summary>
        /// <param name="entity"></param>
        void Remover(TEntity entity);
    }
}
