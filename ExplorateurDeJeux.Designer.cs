
namespace ExplorateurDeJeux
{
    partial class ExplorateurDeJeux
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
            this.ActionOuVeriteButtom = new System.Windows.Forms.Button();
            this.parametre = new System.Windows.Forms.Button();
            this.pendu = new System.Windows.Forms.Button();
            this.JeuxDeDame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActionOuVeriteButtom
            // 
            this.ActionOuVeriteButtom.Location = new System.Drawing.Point(12, 12);
            this.ActionOuVeriteButtom.Name = "ActionOuVeriteButtom";
            this.ActionOuVeriteButtom.Size = new System.Drawing.Size(150, 50);
            this.ActionOuVeriteButtom.TabIndex = 0;
            this.ActionOuVeriteButtom.Text = "Action ou vérite";
            this.ActionOuVeriteButtom.UseVisualStyleBackColor = true;
            this.ActionOuVeriteButtom.Click += new System.EventHandler(this.ActionOuVerite_Click);
            // 
            // parametre
            // 
            this.parametre.Location = new System.Drawing.Point(168, 12);
            this.parametre.Name = "parametre";
            this.parametre.Size = new System.Drawing.Size(150, 50);
            this.parametre.TabIndex = 1;
            this.parametre.Text = "Paramètre";
            this.parametre.UseVisualStyleBackColor = true;
            this.parametre.Click += new System.EventHandler(this.parametre_Click);
            // 
            // pendu
            // 
            this.pendu.Location = new System.Drawing.Point(12, 68);
            this.pendu.Name = "pendu";
            this.pendu.Size = new System.Drawing.Size(150, 50);
            this.pendu.TabIndex = 2;
            this.pendu.Text = "Pendu";
            this.pendu.UseVisualStyleBackColor = true;
            this.pendu.Click += new System.EventHandler(this.pendu_Click);
            // 
            // JeuxDeDame
            // 
            this.JeuxDeDame.Location = new System.Drawing.Point(168, 68);
            this.JeuxDeDame.Name = "JeuxDeDame";
            this.JeuxDeDame.Size = new System.Drawing.Size(150, 50);
            this.JeuxDeDame.TabIndex = 3;
            this.JeuxDeDame.Text = "JeuxDeDame";
            this.JeuxDeDame.UseVisualStyleBackColor = true;
            this.JeuxDeDame.Visible = false;
            // 
            // ExplorateurDeJeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 146);
            this.Controls.Add(this.JeuxDeDame);
            this.Controls.Add(this.pendu);
            this.Controls.Add(this.parametre);
            this.Controls.Add(this.ActionOuVeriteButtom);
            this.Name = "ExplorateurDeJeux";
            this.Text = "ExplorateurDeJeux";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActionOuVeriteButtom;
        private System.Windows.Forms.Button parametre;
        private System.Windows.Forms.Button pendu;
        private System.Windows.Forms.Button JeuxDeDame;
    }
}