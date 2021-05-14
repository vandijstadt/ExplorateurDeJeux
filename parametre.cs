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
    public partial class parametre : Form
    {
        private List<TextBox> joueurTextBox = new List<TextBox>();
        private List<Label> joueurLabel = new List<Label>();
        private int nombreDeJoueur;

        public parametre()
        {
            InitializeComponent();
            for (int i = 0; i < Program.j.Count; i++)
            {
                joueurTextBox.Add(new TextBox
                {
                    Visible = true,
                    Text = Program.j[i].nomJoueur,
                    Location = new Point(10, 10 + (25 * i)),
                    AutoSize = true,
                });
                this.Controls.Add(joueurTextBox[i]);
                joueurLabel.Add(new Label
                {
                    Visible = true,
                    Text = Program.j[i].GetPoint()+"",
                    Location = new Point(120, 15 + (25 * i)),
                    AutoSize = true,
                });
                this.Controls.Add(joueurLabel[i]);
            }
            nombreDeJoueur = Program.j.Count;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (this.nombreDeJoueur <= 9)
            {
                joueurTextBox.Add(new TextBox
                {
                    Visible = true,
                    Location = new Point(10, 10 + (25 * this.nombreDeJoueur)),
                    AutoSize = true,
                });
                this.Controls.Add(joueurTextBox[this.nombreDeJoueur]);
                this.nombreDeJoueur += 1;
            }
            else
            {
                MessageBox.Show("Vous avez dépassé votre cotât.");
            }
        }

        private void Supp_Click(object sender, EventArgs e)
        {
            if (this.nombreDeJoueur > 2)
            {
                this.nombreDeJoueur -= 1;
                this.Controls.Remove(joueurTextBox[this.nombreDeJoueur]);
                joueurTextBox.RemoveAt(this.nombreDeJoueur);
            }
            else
            {
                MessageBox.Show("Vous devez être au moins deux joueurs");
            }
        }

        private void validate_Click(object sender, EventArgs e)
        {
            string error = "";
            Program.j.Clear();
            for (int i = 0; i < this.nombreDeJoueur; i++)   // on fait une boucle du nombre de label crée
            {
                if (joueurTextBox[i].Text == "") // si le joueur n'est pas encoder 
                {
                    error = "Vide";   // On ecrit l'erreur
                    break;   // on quitte la boucle
                }
                else   // si le nom du joueur est encoder
                {
                    Program.j.Add(new Joueur(joueurTextBox[i].Text));   // on ajoute le joueur a la liste de joueur
                }

            }
            if (error == "Vide")   // il a un joueur qui n'a pas de pseudo
            {
                MessageBox.Show("Il a un joueur sans nom");
            }
            else   // Si n'a pas d'erreur on ferme la page
            {
                this.Close();
            }

        }
    }
}
