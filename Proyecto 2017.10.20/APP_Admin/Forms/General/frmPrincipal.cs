using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APP_Admin
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void zonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZona fz = new frmZona();
            fz.MdiParent = this;
            fz.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario ff = new frmFuncionario();
            ff.MdiParent = this;
            ff.Show();
        }

        private void casaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCasa fc = new frmCasa();
            fc.MdiParent = this;
            fc.Show();
        }

        private void apartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApartamento fa = new frmApartamento();
            fa.MdiParent = this;
            fa.Show();
        }

        private void localComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocal_Comercial flc = new frmLocal_Comercial();
            flc.MdiParent = this;
            flc.Show();
        }
    }
}
