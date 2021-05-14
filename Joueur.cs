using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurDeJeux
{
    class Joueur
    {
        public Joueur(string nomJoueur) // creation du joueur de base
        {
            point = 0;
            this.nomJoueur = nomJoueur;
        }
        private int point;   // Son score                
        /// <summary>
        /// Le nom du joueur
        /// </summary>
        public string nomJoueur;
        /// <summary>
        /// Recuperer les point du joueurs
        /// </summary>
        /// <returns>point</returns>
        public int GetPoint() { return this.point; }
        /// <summary>
        /// Ajoutez un points.
        /// </summary>                                                 
        public void AddPoint(int count) { this.point += count; }
        public void RemovePoint(int count) { this.point -= count; }
    }
}
