using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ExplorateurDeJeux
{
    public partial class PileOuFaceForm : Form
    {
        private List<Label> nomDuJoueur = new List<Label>();
        private List<NumericUpDown> miseJoueur = new List<NumericUpDown>();
        private List<DomainUpDown> choixJoueur = new List<DomainUpDown>();
        private List<int> DomainUpDownExempleItem = new List<int>();
        public PileOuFaceForm()
        {
            InitializeComponent();
            for (int i = 0; i <= 99; i++)
            {
                DomainUpDownExempleItem.Add(i);
            }
            for (int i = 0; i < Program.j.Count; i++)   // Afficher les points de tous les joueurs
            {
                nomDuJoueur.Add(new Label
                {
                    Text = Program.j[i].nomJoueur + " : " + Program.j[i].GetPoint(),
                    Location = new Point(258, 12 + (20 * i)),
                    AutoSize = true,
                    TabIndex = 10,
                });
                miseJoueur.Add(new NumericUpDown
                {
                    Location = new Point(361, 12 + (20 * i)),
                    AutoSize = true,
                    ReadOnly = true,
                    Size = new Size(10, 10),
                    TabIndex = 10,
                });
                choixJoueur.Add(new DomainUpDown
                {
                    Location = new Point(400, 12 + (20 * i)),
                    AutoSize = true,
                    ReadOnly = true,
                    Size = new Size(10, 10),
                    TabIndex = 10,
                });
                this.miseJoueur[i].Maximum = Program.j[i].GetPoint();
                this.miseJoueur[i].Value = 0;
                this.choixJoueur[i].Items.AddRange(new string[] { "Rien", "Face", "Pile", "Tranche" });
                this.choixJoueur[i].Items.Reverse();
                this.choixJoueur[i].SelectedIndex = 3;
                Controls.Add(nomDuJoueur[i]);
                Controls.Add(miseJoueur[i]);
                Controls.Add(choixJoueur[i]);
            }
        }
        private void envoyer_Click(object sender, EventArgs e)
        {
            bool erreur = false;
            for (int i = 0; i < this.miseJoueur.Count; i++)
            {
                if ((this.miseJoueur[i].Value != 0 && this.choixJoueur[i].Text == "Rien") ||
                    ((this.miseJoueur[i].Value == 0 && this.choixJoueur[i].Text != "Rien")))
                {
                    erreur = true;
                }
            }
            if (erreur == false)
            {
                int valeur = PileOuFaceClass.random();
                tournerLaPieces(valeur);

                PileOuFaceClass pileOuFaceClass = new PileOuFaceClass();
                int[,] tableauDeScore = new int[Program.j.Count, 3];
                for (int i = 0; i < Program.j.Count; i++)
                {
                    try
                    {
                        tableauDeScore[i, 0] = i;
                        tableauDeScore[i, 1] = int.Parse(this.miseJoueur[i].Value.ToString());
                        switch (int.Parse(this.choixJoueur[i].SelectedIndex.ToString()))
                        {
                            case 3:
                                tableauDeScore[i, 2] = 0;
                                break;
                            case 2:
                                tableauDeScore[i, 2] = 1;
                                break;
                            case 1:
                                tableauDeScore[i, 2] = 2;
                                break;
                            case 0:
                                tableauDeScore[i, 2] = 3;
                                break;
                        }
                    }
                    catch (Exception a)
                    {
                        Debug.WriteLine(a.Message);
                    }
                }
                pileOuFaceClass.game(tableauDeScore, valeur);
                AffichageReset();
            }
            else
            {
                MessageBox.Show("Si vous voulez pariez veuillez choisir (pile, face et la tranche) et mettre une mise sinon mettes rien");
            }
        }
        public void AffichageReset()
        {
            for (int i = 0; i < this.miseJoueur.Count; i++)
            {
                this.nomDuJoueur[i].Text = Program.j[i].nomJoueur + " : " + Program.j[i].GetPoint();
                this.miseJoueur[i].Maximum = Program.j[i].GetPoint();
                this.miseJoueur[i].Value = 0;
            }
            this.Refresh();
        }
        public void tournerLaPieces(int faceRectos)
        {

            int temp = 100;
            int nobmreDeTour = 10;
            for (int i = 0; i < nobmreDeTour; i++)
            {
                this.PileLancé.Image = global::ExplorateurDeJeux.Properties.Resources.pieces_piles;
                Thread.Sleep(temp);
                this.Refresh();
                this.PileLancé.Image = global::ExplorateurDeJeux.Properties.Resources.pieces_tranche;
                Thread.Sleep(temp);
                this.Refresh();
                this.PileLancé.Image = global::ExplorateurDeJeux.Properties.Resources.pieces_face;
                Thread.Sleep(temp);
                this.Refresh();
                this.PileLancé.Image = global::ExplorateurDeJeux.Properties.Resources.pieces_tranche;
                Thread.Sleep(temp);
                if (i == nobmreDeTour - 1)
                {
                    if (faceRectos == 1)
                    {
                        this.PileLancé.Image = global::ExplorateurDeJeux.Properties.Resources.pieces_face;
                    }
                    else if (faceRectos == 2)
                    {
                        this.PileLancé.Image = global::ExplorateurDeJeux.Properties.Resources.pieces_piles;
                    }
                }
                this.Refresh();
            }
        }
    }
}