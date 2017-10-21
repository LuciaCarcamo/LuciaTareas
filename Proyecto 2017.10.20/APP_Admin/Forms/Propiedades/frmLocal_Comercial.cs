using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace APP_Admin
{
    public partial class frmLocal_Comercial : Form
    {
        private LocalComercial local = null;
        
        public frmLocal_Comercial()
        {
            InitializeComponent();
        }

        private void frmLocal_Comercial_Load(object sender, EventArgs e)
        {
            txtFuncionario.Enabled = false;
            Limpiar();
        }

        private void DejoAgregar()
        {
            toolStripButton4.Enabled = false;
            tsbEditLocal.Enabled = false;
            tsbCleanLocal.Enabled = true;

            tsbAddLocal.Enabled = true;
            txtPadron.Enabled = false;

            txtAcronimo.Enabled = true;
            txtBaños.Enabled = true;
            txtDireccion.Enabled = true;
            txtHabitaciones.Enabled = true;
            txtM2Ed.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void DejoActualizar()
        {
            toolStripButton4.Enabled = true;
            tsbEditLocal.Enabled = true;
            tsbCleanLocal.Enabled = true;

            tsbAddLocal.Enabled = false;
            txtPadron.Enabled = false;

            txtAcronimo.Enabled = true;
            txtBaños.Enabled = true;
            txtDireccion.Enabled = true;
            txtHabitaciones.Enabled = true;
            txtM2Ed.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void Limpiar()
        {
            toolStripButton4.Enabled = false;
            tsbEditLocal.Enabled = false;
            tsbCleanLocal.Enabled = true;
            tsbAddLocal.Enabled = false;

            txtPadron.Enabled = true;
            txtAcronimo.Enabled = false;
            txtBaños.Enabled = false;
            txtDireccion.Enabled = false;
            txtHabitaciones.Enabled = false;
            txtM2Ed.Enabled = false;
            txtPrecio.Enabled = false;

            cbxAccion.SelectedIndex = 0;
            cbxDepartamento.SelectedIndex = 0;
            txtPadron.Text = "";
            txtAcronimo.Text = "";
            txtBaños.Text = "";
            txtDireccion.Text = "";
            txtHabitaciones.Text = "";
            txtM2Ed.Text = "";
            txtPrecio.Text = "";
            txtFuncionario.Text = "";
            chbHabilitacion.Checked = false;

        }

        private void txtPadron_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Propiedad prop = LFabrica.getLogicaPropiedad().BuscarPropiedad(Convert.ToInt32(txtPadron.Text));
                if (prop != null)
                {
                    if (prop is LocalComercial)
                    {
                        local = (LocalComercial)prop;

                        txtAcronimo.Text = local.Departamento.Acronimo;
                        txtBaños.Text = local.CantBaños.ToString();
                        txtDireccion.Text = local.Direccion;
                        txtHabitaciones.Text = local.CantHabit.ToString();
                        txtM2Ed.Text = local.Mt2Ed.ToString();
                        txtPrecio.Text = local.Precio.ToString();
                        txtFuncionario.Text = local.Usuario.Nombre;

                        chbHabilitacion.Checked = local.Habilitacion;
                        cbxAccion.SelectedItem = local.Accion;
                        cbxDepartamento.SelectedItem = trabajoZona.NombreDepartamento(local.Departamento.IDDepartamento);

                        DejoActualizar();
                    }
                    else
                        lblError.Text = "La propiedad no es un local comercial. ";
                }
                else
                    DejoAgregar();

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbAddLocal_Click(object sender, EventArgs e)
        {
            try
            {
                int padron, precio, cantHabitaciones, mt2Ed, baños;
                bool habilitacion = chbHabilitacion.Checked;
                string accion, departamento, acronimo;

                padron = Convert.ToInt32(txtPadron.Text);
                precio = Convert.ToInt32(txtPrecio.Text);
                cantHabitaciones = Convert.ToInt32(txtHabitaciones.Text);
                baños = Convert.ToInt32(txtBaños.Text);
                mt2Ed = Convert.ToInt32(txtHabitaciones.Text);
                accion = cbxAccion.Text;
                departamento = trabajoZona.IDDepartamento(cbxDepartamento.SelectedItem.ToString());

                if (txtAcronimo.Text.Length == 3)
                    acronimo = txtAcronimo.Text;
                else
                    throw new Exception("El acronimo debe tener tres letras");

                Zona zon = LFabrica.GetInstZona().BuscarZona(departamento, acronimo);
                Funcionario fun = LFabrica.GetLogicaFun().BuscarFuncionario("Usuario 1");

                if (zon != null)
                {
                    if (fun != null)
                    {
                    LocalComercial locNew = new LocalComercial(padron, precio, baños, cantHabitaciones, mt2Ed, txtDireccion.Text, accion, zon, fun, habilitacion);
                    LFabrica.getLogicaPropiedad().AltaPropiedad(locNew);
                    Limpiar();
                    lblError.Text = "Alta con exito";
                    }
                    else
                        throw new Exception("No existe el funcionario");
                }
                else
                    throw new Exception("No se encuentra la zona");
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                LFabrica.getLogicaPropiedad().EliminarPropiedad(local);
                Limpiar();
                lblError.Text = "Baja con exito";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbEditLocal_Click(object sender, EventArgs e)
        {
            try
            {
                local.Accion = cbxAccion.Text;
                local.Habilitacion = chbHabilitacion.Checked;
                local.CantBaños = Convert.ToInt32(txtBaños.Text);
                local.CantHabit = Convert.ToInt32(txtHabitaciones.Text);
                local.Direccion = txtDireccion.Text;
                local.Mt2Ed = Convert.ToInt32(txtM2Ed.Text);
                local.Padron = Convert.ToInt32(txtPadron.Text);
                local.Precio = Convert.ToInt32(txtPrecio.Text);
                string departamento = trabajoZona.IDDepartamento(cbxDepartamento.SelectedItem.ToString());

                Zona zon = LFabrica.GetInstZona().BuscarZona(departamento, txtAcronimo.Text);
                Funcionario fun = LFabrica.GetLogicaFun().BuscarFuncionario("Usuario 1");

                local.Departamento = zon;
                local.Usuario = fun;

                LFabrica.getLogicaPropiedad().ModificarPropiedad(local);
                Limpiar();
                lblError.Text = "Modificacion con exito";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbCleanLocal_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
