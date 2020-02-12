using Greatt.DAL.Entities;
using Greatt.DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greatt.DAL.Repository
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// DbContext du repository
        /// </summary>
        protected readonly GreattContext _dbContext;

        public EfRepository(GreattContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Retourne une entité par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(Guid id) => await _dbContext.Set<T>().FindAsync(id);

        /// <summary>
        /// Retourne la liste des entités
        /// </summary>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync() => await _dbContext.Set<T>().ToListAsync();

        /// <summary>
        /// Retourne la liste des entités correspondant aux ids
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync(List<Guid> ids) => await _dbContext.Set<T>().Where(e => ids.Any(i => e.Id == i)).ToListAsync();

        /// <summary>
        /// Ajoute une entité
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        /// <summary>
        /// Ajoute une liste d'entité
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task<List<T>> AddRangeAsync(List<T> entities)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();

            return entities;
        }

        /// <summary>
        /// Supprime une entité
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Supprime une liste d'entité
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task DeleteRangeAsync(List<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Met à jour une entité
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Met à jour une liste d'entité
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task UpdateRangeAsync(List<T> entities)
        {
            _dbContext.Entry(entities).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Retourne le nombre d'entité existante
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> CountAsync() => await _dbContext.Set<T>().CountAsync();

        /// <summary>
        /// Retourne si au moins une entité existe
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> AnyAsync() => await _dbContext.Set<T>().AnyAsync();
    }
}
