using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ExplorateurDeJeux
{
    public partial class ActionOuVeriteForm : Form
    {
        private string joueurActuel;   // conaitre le nom du joueur qui joue
        private int actionVeriteFaitNonFaitEtats;   // savoir a quelle etats on est (demarrage = 0, jeux = 1 , fait ou pas fait = 2)
        private List<Label> AffichageJoueur = new List<Label>();   // pour ajouter label des scores
        public ActionOuVeriteForm()   // initaliser lors du demarrage de action ou verité
        {
            InitializeComponent();


            this.ActionOuVerite.Text = "";
            this.Utilisateur.Text = "";
            this.Phrase.Text = "";
            this.Bouton1.Text = "Lancer";
            this.Bouton2.Text = "Paramètre";

            mettreAJourLesScores();

        }
        private void Bouton1_Click_1(object sender, EventArgs e)   // Appuyer sur le 1er bouton en haut a gauche
        {
            if (actionVeriteFaitNonFaitEtats == 0)   // aux demarage
            {
                this.joueurActuel = VeriteActionClass.JoueurAleatoire();   // Chercher un joueur
                this.Utilisateur.Text = this.joueurActuel + " : ";   // Afficher le joueur actuelle
                this.Bouton1.Text = "Action";   // Modifier les bouton pour demander si on choisi action
                this.Bouton2.Text = "Vérité";   // Modifier les bouton pour demander si on choisi vérité
                actionVeriteFaitNonFaitEtats = 1;   //dire qu'on passe a l'etape 2
            }
            else if (actionVeriteFaitNonFaitEtats == 1)   // en plein game
            {
                this.ActionOuVerite.Text = "Action";    // on dit qu'il a choisi Vérité
                this.Phrase.Text = VeriteActionClass.ACTION();   // on cherche une verité aleatoire

                this.Bouton1.Text = "Fait";  // Modifier les bouton pour demander si c'est Fait
                this.Bouton2.Text = "Non-fait";   // Modifier les bouton pour demander si c'est pas fait
                actionVeriteFaitNonFaitEtats = 2;   //dire qu'on passe a l'etape 3
            }
            else if (actionVeriteFaitNonFaitEtats == 2)   // fin de game
            {
                VeriteActionClass.ajoutDesPoints(joueurActuel);
                this.Bouton1.Text = "Suivant";   // Modifier les bouton pour demander si on continue
                this.Bouton2.Text = "Paramètre";   // Modifier les bouton pour demander d'accerd aux parametre
                actionVeriteFaitNonFaitEtats = 0;   // Dire qu'on passe a l'etape 1
                this.Phrase.Text = "";
            }

            mettreAJourLesScores();
        }

        private void Bouton2_Click(object sender, EventArgs e)
        {
            if (actionVeriteFaitNonFaitEtats == 0)
            {
                this.SuspendLayout();
                parametre p = new parametre();
                p.ShowDialog();
            }
            else if (actionVeriteFaitNonFaitEtats == 1)
            {
                this.ActionOuVerite.Text = "Vérité";
                this.Phrase.Text = VeriteActionClass.VERITE();

                this.Bouton1.Text = "Fait";
                this.Bouton2.Text = "Non-fait";
                actionVeriteFaitNonFaitEtats = 2; // Dire qu'on passe a l'etape 3
            }
            else if (actionVeriteFaitNonFaitEtats == 2)
            {
                this.Bouton1.Text = "Suivant";
                this.Bouton2.Text = "Paramètre";
                actionVeriteFaitNonFaitEtats = 0;   // Dire qu'on passe a l'etape 1
            }

            mettreAJourLesScores();
        }
        private void mettreAJourLesScores()
        {
            for (int i = 0; i < AffichageJoueur.Count; i++)
            {
                Controls.Remove(AffichageJoueur[i]);
            }
            AffichageJoueur.Clear();
            for (int i = 0; i <= Program.j.Count; i++)   // Afficher les points de tous les joueurs
            {
                try
                {
                    AffichageJoueur.Add(new Label
                    {
                        Text = Program.j[i].nomJoueur + " : " + Program.j[i].GetPoint(),
                        Location = new Point(30, 100 + (20 * i)),
                        AutoSize = true,
                    });
                    Controls.Add(AffichageJoueur[i]);

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);

                }

            }
        }

    }
}
