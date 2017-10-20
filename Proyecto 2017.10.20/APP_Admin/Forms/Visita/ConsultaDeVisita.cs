using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Linq;

namespace APP_Admin.Forms.Visita
{
    public partial class dgvConsulta : Form
    {
        XmlDocument xmlVisitas = null;

        public dgvConsulta()
        {
            InitializeComponent();
        }

        private void dgvConsulta_Load(object sender, EventArgs e)
        {
            /*
            xmlVisitas = new XmlDocument();
            xmlVisitas.Load(Server.MapPath("~/Forms/Visita/XML/Visita.xml"));
            */
            dataGridView1.DataSource = xmlVisitas;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            
        }
    }
}
