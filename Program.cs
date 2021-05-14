using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplorateurDeJeux
{
    class Program
    {

        private static ExplorateurDeJeux explorateurDeJeux;
        public static List<Joueur> j = new List<Joueur>();   // Liste des joueur
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            j.Add(new Joueur("Loïc")); // Creation du premier joueur   
            j.Add(new Joueur("Nicolas")); // Creation du deuxieme joueur

            PhaseDeTest(3,2);

            // Creation de l'explorateur de fichier
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(explorateurDeJeux = new ExplorateurDeJeux());

            //Lancer un jeux specifique
            //Application.Run(new ActionOuVeriteForm());   
            //Application.Run(new PenduForm());
            Application.Run(new PileOuFaceForm());
            //Application.Run(new JeuDeDamePlateauForm());
        }
        private static void PhaseDeTest(int nombreDeJoueur, int pointDuJoueur)
        {
            j.Clear();
            for (int i = 0; i < nombreDeJoueur; i++)
            {
                j.Add(new Joueur("j" + (i+1).ToString()));
            }
            for (int i = 0; i < j.Count; i++)
            {
                Random r = new Random();
                j[i].AddPoint(pointDuJoueur);
            }
        }
    }
}
