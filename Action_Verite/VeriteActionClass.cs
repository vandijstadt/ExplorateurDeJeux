using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExplorateurDeJeux
{
    class VeriteActionClass
    {
        /// <summary>
        /// Permet de recuperer un joueur aleatoire.
        /// </summary>
        public static string JoueurAleatoire()
        {
            Random r = new Random();

            return Program.j[r.Next(Program.j.Count)].nomJoueur;
        }
        /// <summary>
        /// choisi une verité aleatoire.
        /// </summary>
        public static string VERITE()
        {
            string[] VERITE = File.ReadAllLines(@"Action_Verite\VERITE.txt");
            Random r = new Random();

            return VERITE[r.Next(VERITE.Length)];

        }
        /// <summary>
        /// Choisi un action aleatoire.
        /// </summary>
        public static string ACTION()
        {
            string[] ACTION = File.ReadAllLines(@"Action_Verite\ACTION.txt");
            Random r = new Random();

            return ACTION[r.Next(ACTION.Length)];

        }
        public static void ajoutDesPoints(string joueurActuel)
        {
            for (int i = 0; i <= Program.j.Count; i++)
            {
                if (joueurActuel == Program.j[i].nomJoueur)
                {
                    Program.j[i].AddPoint(1);
                    break;
                }
            }

        }

    }
}
// URL action et verite : https://psycatgames.com/fr/magazine/party-games/kids-truth-or-dare/