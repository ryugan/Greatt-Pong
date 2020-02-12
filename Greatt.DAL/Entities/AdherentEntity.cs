
using System;

namespace Greatt.DAL.Entities
{
    public abstract class AdherentEntity : BaseEntity
    {
        /// <summary>
        /// Numéro de licence de l'adhérent dans la FFTT
        /// </summary>
        public int NumeroLicenceFFTT { get; set; }

        /// <summary>
        /// Nom de l'adhérent
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom de l'adhérent
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Points de l'adhérent
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Numéro du club de l'adhérent dans la FFTT
        /// </summary>
        public Guid ClubId { get; set; }

        /// <summary>
        /// Club de l'adhérent dans la FFTT
        /// </summary>
        public ClubEntity Club { get; set; }
    }
}
