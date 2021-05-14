
namespace ExplorateurDeJeux
{
    partial class ActionOuVeriteForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Utilisateur = new System.Windows.Forms.Label();
            this.Phrase = new System.Windows.Forms.Label();
            this.ActionOuVerite = new System.Windows.Forms.Label();
            this.Bouton1 = new System.Windows.Forms.Button();
            this.Bouton2 = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Utilisateur
            // 
            this.Utilisateur.AutoSize = true;
            this.Utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilisateur.Location = new System.Drawing.Point(12, 9);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(82, 17);
            this.Utilisateur.TabIndex = 3;
            this.Utilisateur.Text = "Utilisateur";
            // 
            // Phrase
            // 
            this.Phrase.AutoSize = true;
            this.Phrase.Location = new System.Drawing.Point(41, 26);
            this.Phrase.Name = "Phrase";
            this.Phrase.Size = new System.Drawing.Size(53, 17);
            this.Phrase.TabIndex = 4;
            this.Phrase.Text = "Phrase";
            // 
            // ActionOuVerite
            // 
            this.ActionOuVerite.AutoSize = true;
            this.ActionOuVerite.Location = new System.Drawing.Point(255, 9);
            this.ActionOuVerite.Name = "ActionOuVerite";
            this.ActionOuVerite.Size = new System.Drawing.Size(106, 17);
            this.ActionOuVerite.TabIndex = 7;
            this.ActionOuVerite.Text = "Action ou vérite";
            this.ActionOuVerite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bouton1
            // 
            this.Bouton1.Location = new System.Drawing.Point(382, 12);
            this.Bouton1.Name = "Bouton1";
            this.Bouton1.Size = new System.Drawing.Size(188, 60);
            this.Bouton1.TabIndex = 9;
            this.Bouton1.Text = "Bouton1";
            this.Bouton1.UseVisualStyleBackColor = true;
            this.Bouton1.Click += new System.EventHandler(this.Bouton1_Click_1);
            // 
            // Bouton2
            // 
            this.Bouton2.Location = new System.Drawing.Point(382, 78);
            this.Bouton2.Name = "Bouton2";
            this.Bouton2.Size = new System.Drawing.Size(188, 60);
            this.Bouton2.TabIndex = 10;
            this.Bouton2.Text = "Bouton2";
            this.Bouton2.UseVisualStyleBackColor = true;
            this.Bouton2.Click += new System.EventHandler(this.Bouton2_Click);
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.Location = new System.Drawing.Point(12, 71);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(52, 17);
            this.scores.TabIndex = 13;
            this.scores.Text = "Scores";
            // 
            // ActionOuVeriteForm
            // 
            this.ClientSize = new System.Drawing.Size(582, 333);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.Bouton2);
            this.Controls.Add(this.Bouton1);
            this.Controls.Add(this.ActionOuVerite);
            this.Controls.Add(this.Phrase);
            this.Controls.Add(this.Utilisateur);
            this.Name = "ActionOuVeriteForm";
            this.Text = "Action ou vérité";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Utilisateur;
        private System.Windows.Forms.Label Phrase;
        private System.Windows.Forms.Label ActionOuVerite;
        private System.Windows.Forms.Button Bouton1;
        private System.Windows.Forms.Button Bouton2;
        private System.Windows.Forms.Label scores;
    }
}

