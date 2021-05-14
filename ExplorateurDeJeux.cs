using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplorateurDeJeux
{
    public partial class ExplorateurDeJeux : Form
    {
        public ExplorateurDeJeux()
        {
            InitializeComponent();
        }

        private void ActionOuVerite_Click(object sender, EventArgs e)
        {
            ActionOuVeriteForm actionOuVerite = new ActionOuVeriteForm();
            actionOuVerite.ShowDialog();
            this.SuspendLayout();
        }

        private void pendu_Click(object sender, EventArgs e)
        {
            PenduForm pendu = new PenduForm();
            pendu.ShowDialog();
            this.SuspendLayout();
        }

        private void parametre_Click(object sender, EventArgs e)
        {
            parametre parametre = new parametre();
            parametre.ShowDialog();
            this.SuspendLayout();
        }

    }
}
