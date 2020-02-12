using Greatt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Greatt.DAL.Interface
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Retourne une entité par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(Guid id);

        /// <summary>
        /// Retourne la liste des entités
        /// </summary>
        /// <returns></returns>
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// Retourne la liste des entités correspondant aux ids
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<List<T>> GetAllAsync(List<Guid> ids);

        /// <summary>
        /// Ajoute une entité
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// Ajoute une liste d'entité
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<List<T>> AddRangeAsync(List<T> entities);

        /// <summary>
        /// Supprime une entité
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task DeleteAsync(T entity);

        /// <summary>
        /// Supprime une liste d'entité
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task DeleteRangeAsync(List<T> entities);

        /// <summary>
        /// Met à jour une entité
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task UpdateAsync(T entity);

        /// <summary>
        /// Met à jour une liste d'entité
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task UpdateRangeAsync(List<T> entities);

        /// <summary>
        /// Retourne le nombre d'entité existante
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> CountAsync();

        /// <summary>
        /// Retourne si au moins une entité existe
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AnyAsync();
    }
}
