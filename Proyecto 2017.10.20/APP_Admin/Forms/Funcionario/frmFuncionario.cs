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
    public partial class frmFuncionario : Form
    {
        private Entidades.Funcionario _Fun = null;
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void ActivoAgregar()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtPsw.Text = "";
        }
        private void ActivoModificar() 
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            txtUsu.Enabled = false;
            txtUsu.Text = _Fun.Nombre;
            txtPsw.Text = _Fun.Password;
        }
        private void ActivoDefault()
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtUsu.Enabled = true;

            txtUsu.Text = "";
            txtPsw.Text = "";
        }
        private void User_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                _Fun = Logica.LFabrica.GetLogicaFun().BuscarFuncionario(txtUsu.Text.Trim());

                if (_Fun == null)
                {
                    this.ActivoAgregar();
                }
                else 
                {
                    this.ActivoModificar();
                }
                    
            }
            catch(Exception ex)
            {
                lblError.Text=ex.Message;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Funcionario _fun = new Entidades.Funcionario(txtUsu.Text.Trim(), txtPsw.Text.Trim());

                Logica.LFabrica.GetLogicaFun().AgregarFuncionario(_fun);
                lblError.Text = "Alta con exito";

                this.ActivoDefault();

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Funcionario _fun = new Entidades.Funcionario(txtUsu.Text.Trim(), txtPsw.Text.Trim());

                Logica.LFabrica.GetLogicaFun().EliminarFuncionario(_fun);
                lblError.Text = "Baja con exito";

                this.ActivoDefault();

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                _Fun.Nombre = txtUsu.Text.Trim();
                _Fun.Password = txtPsw.Text.Trim();

                Logica.LFabrica.GetLogicaFun().ModificarFuncionario(_Fun);
                lblError.Text = "Modificacion exitosa";

                this.ActivoDefault();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            this.ActivoDefault();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            ActivoDefault();
        }
    }
}
