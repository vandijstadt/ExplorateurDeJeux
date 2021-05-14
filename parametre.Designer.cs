
namespace ExplorateurDeJeux
{
    partial class parametre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.valider = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valider
            // 
            this.valider.CausesValidation = false;
            this.valider.Location = new System.Drawing.Point(195, 12);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(109, 30);
            this.valider.TabIndex = 105;
            this.valider.Text = "Valider";
            this.valider.Click += new System.EventHandler(this.validate_Click);
            // 
            // ajouter
            // 
            this.ajouter.CausesValidation = false;
            this.ajouter.Location = new System.Drawing.Point(195, 48);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(109, 30);
            this.ajouter.TabIndex = 106;
            this.ajouter.Text = "Ajouter";
            this.ajouter.Click += new System.EventHandler(this.Add_Click);
            // 
            // supprimer
            // 
            this.supprimer.CausesValidation = false;
            this.supprimer.Location = new System.Drawing.Point(194, 84);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(109, 30);
            this.supprimer.TabIndex = 107;
            this.supprimer.Text = "Supprimer";
            this.supprimer.Click += new System.EventHandler(this.Supp_Click);
            // 
            // parametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 351);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.valider);
            this.Name = "parametre";
            this.Text = "Paramètre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button supprimer;
    }
}