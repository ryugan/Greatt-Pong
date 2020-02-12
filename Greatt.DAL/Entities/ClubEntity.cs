
using System.Collections.Generic;

namespace Greatt.DAL.Entities
{
    public class ClubEntity : BaseEntity
    {
        /// <summary>
        /// Numéro du club dans la FFTT
        /// </summary>
        public int NumeroClubFFTT { get; set; }

        /// <summary>
        /// Nom du club
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Liste des adhérents du club
        /// </summary>
        public List<AdherentEntity> Adherents { get; }
    }
}
