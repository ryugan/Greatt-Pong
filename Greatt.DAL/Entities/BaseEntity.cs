using System;

namespace Greatt.DAL.Entities
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Identifiant unique pour toutes les entités
        /// </summary>
        public virtual Guid Id { get; protected set; }
    }
}
