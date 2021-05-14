
namespace ExplorateurDeJeux
{
    partial class PileOuFaceForm
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
            this.PileLancé = new System.Windows.Forms.PictureBox();
            this.envoyer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PileLancé)).BeginInit();
            this.SuspendLayout();
            // 
            // PileLancé
            // 
            this.PileLancé.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PileLancé.Image = global::ExplorateurDeJeux.Properties.Resources.pieces_face;
            this.PileLancé.Location = new System.Drawing.Point(12, 12);
            this.PileLancé.Name = "PileLancé";
            this.PileLancé.Size = new System.Drawing.Size(150, 152);
            this.PileLancé.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PileLancé.TabIndex = 0;
            this.PileLancé.TabStop = false;
            // 
            // envoyer
            // 
            this.envoyer.Location = new System.Drawing.Point(12, 307);
            this.envoyer.Name = "envoyer";
            this.envoyer.Size = new System.Drawing.Size(650, 51);
            this.envoyer.TabIndex = 3;
            this.envoyer.Text = "Envoyer";
            this.envoyer.UseVisualStyleBackColor = true;
            this.envoyer.Click += new System.EventHandler(this.envoyer_Click);
            // 
            // PileOuFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 370);
            this.Controls.Add(this.envoyer);
            this.Controls.Add(this.PileLancé);
            this.Name = "PileOuFaceForm";
            this.Text = "PileOuFaceForm";
            ((System.ComponentModel.ISupportInitialize)(this.PileLancé)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PileLancé;
        private System.Windows.Forms.Button envoyer;
    }
}