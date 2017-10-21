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
    public partial class frmCasa : Form
    {
        private Casa casita = null; 

        public frmCasa()
        {
            InitializeComponent();
        }

        private void frmCasa_Load(object sender, EventArgs e)
        {
            txtFuncionario.Enabled = false;
            Limpiar();
        }

        private void DejoAgregar()
        {
            tsbDelCasa.Enabled = false;
            tsbEditCasa.Enabled = false;
            tsbCleanCasa.Enabled = true;

            tsbAddCasa.Enabled = true;
            txtPadron.Enabled = false;

            txtAcronimo.Enabled = true;
            txtBaños.Enabled = true;
            txtDireccion.Enabled = true;
            txtHabitaciones.Enabled = true;
            txtM2Ed.Enabled = true;
            txtM2Terr.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void DejoActualizar()
        {
            tsbDelCasa.Enabled = true;
            tsbEditCasa.Enabled = true;
            tsbCleanCasa.Enabled = true;

            tsbAddCasa.Enabled = false;
            txtPadron.Enabled = false;

            txtAcronimo.Enabled = true;
            txtBaños.Enabled = true;
            txtDireccion.Enabled = true;
            txtHabitaciones.Enabled = true;
            txtM2Ed.Enabled = true;
            txtM2Terr.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void Limpiar()
        {
            tsbDelCasa.Enabled = false;
            tsbEditCasa.Enabled = false;
            tsbCleanCasa.Enabled = true;
            tsbAddCasa.Enabled = false;

            txtPadron.Enabled = true;
            txtAcronimo.Enabled = false;
            txtBaños.Enabled = false;
            txtDireccion.Enabled = false;
            txtHabitaciones.Enabled = false;
            txtM2Ed.Enabled = false;
            txtM2Terr.Enabled = false;
            txtPrecio.Enabled = false;

            cbxAccion.SelectedIndex = 0;
            cbxDepartamento.SelectedIndex = 0;
            txtPadron.Text = "";
            txtAcronimo.Text = "";
            txtBaños.Text = "";
            txtDireccion.Text = "";
            txtHabitaciones.Text = "";
            txtM2Ed.Text = "";
            txtM2Terr.Text = "";
            txtPrecio.Text = "";
            txtFuncionario.Text = "";
            chbPatio.Checked = false;

        }

        private void txtPadron_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Propiedad prop = LFabrica.getLogicaPropiedad().BuscarPropiedad(Convert.ToInt32(txtPadron.Text));
                if (prop != null)
                {
                    if (prop is Casa)
                    {
                        casita = (Casa)prop;

                        txtAcronimo.Text = casita.Departamento.Acronimo;
                        txtBaños.Text = casita.CantBaños.ToString();
                        txtDireccion.Text = casita.Direccion;
                        txtHabitaciones.Text = casita.CantHabit.ToString();
                        txtM2Ed.Text = casita.Mt2Ed.ToString();
                        txtM2Terr.Text = casita.Mt2Terr.ToString();
                        txtPrecio.Text = casita.Precio.ToString();
                        txtFuncionario.Text = casita.Usuario.Nombre;

                        chbPatio.Checked = casita.Patio;
                        cbxAccion.SelectedItem = casita.Accion;
                        cbxDepartamento.SelectedItem = trabajoZona.NombreDepartamento(casita.Departamento.IDDepartamento);

                        DejoActualizar();
                    }
                    else
                        lblError.Text = "La propiedad no es una casa. ";
                }
                else
                    DejoAgregar();

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbAddCasa_Click(object sender, EventArgs e)
        {
            try
            {
                int padron, precio, cantHabitaciones, mt2Ed, baños, mt2terr;
                bool patio = chbPatio.Checked;
                string accion, departamento, acronimo;

                padron = Convert.ToInt32(txtPadron.Text);
                precio = Convert.ToInt32(txtPrecio.Text);
                cantHabitaciones = Convert.ToInt32(txtHabitaciones.Text);
                baños = Convert.ToInt32(txtBaños.Text);
                mt2Ed = Convert.ToInt32(txtHabitaciones.Text);
                mt2terr = Convert.ToInt32(txtM2Terr.Text);
                accion = cbxAccion.Text;
                departamento = trabajoZona.IDDepartamento(cbxDepartamento.SelectedItem.ToString());

                if (txtAcronimo.Text.Length == 3)
                    acronimo = txtAcronimo.Text;
                else
                    throw new Exception("El acronimo debe tener tres letras");

                Zona zon = LFabrica.GetInstZona().BuscarZona(departamento, txtAcronimo.Text);
                string usuario = "Usuario" + " " +"1";
                Funcionario fun = LFabrica.GetLogicaFun().BuscarFuncionario(usuario.Trim());

                if (zon != null)
                {
                    if (fun != null)
                    {
                        Casa casaNew = new Casa(padron, precio, baños, cantHabitaciones, mt2Ed, txtDireccion.Text, accion, zon, fun, mt2terr, patio);
                        LFabrica.getLogicaPropiedad().AltaPropiedad(casaNew);
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

        private void tsbEditCasa_Click(object sender, EventArgs e)
        {
            try
            {
                casita.Accion = cbxAccion.Text;
                casita.Patio = chbPatio.Checked;
                casita.CantBaños = Convert.ToInt32(txtBaños.Text);
                casita.CantHabit = Convert.ToInt32(txtHabitaciones.Text);
                casita.Direccion = txtDireccion.Text;
                casita.Mt2Ed = Convert.ToInt32(txtM2Ed.Text);
                casita.Padron = Convert.ToInt32(txtPadron.Text);
                casita.Mt2Terr = Convert.ToInt32(txtM2Terr.Text);
                casita.Precio = Convert.ToInt32(txtPrecio.Text);
                string departamento = trabajoZona.IDDepartamento(cbxDepartamento.SelectedItem.ToString());

                Zona zon = LFabrica.GetInstZona().BuscarZona(departamento, txtAcronimo.Text);
                Funcionario fun = LFabrica.GetLogicaFun().BuscarFuncionario("Usuario 1");

                casita.Departamento = zon;
                casita.Usuario = fun;

                LFabrica.getLogicaPropiedad().ModificarPropiedad(casita);
                Limpiar();
                lblError.Text = "Modificacion con exito";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbDelCasa_Click(object sender, EventArgs e)
        {
            try
            {
                LFabrica.getLogicaPropiedad().EliminarPropiedad(casita);
                Limpiar();
                lblError.Text = "Baja con exito";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbCleanCasa_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
