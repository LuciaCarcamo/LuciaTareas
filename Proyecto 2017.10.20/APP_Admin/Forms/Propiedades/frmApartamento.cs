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
    public partial class frmApartamento : Form
    {
        private Apartamento apto = null;

        public frmApartamento()
        {
            InitializeComponent();
        }

        private void lblAccion_Click(object sender, EventArgs e)
        {

        }

        private void frmApartamento_Load(object sender, EventArgs e)
        {
            txtFuncionario.Enabled = false;
            Limpiar();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void DejoAgregar()
        {
            tsbDelApto.Enabled = false;
            tsbEditApto.Enabled = false;
            tsbClean.Enabled = true;

            tsbAddApto.Enabled = true;
            txtPadron.Enabled = false;

            txtAcronimo.Enabled = true;
            txtBaños.Enabled = true;
            txtDireccion.Enabled = true;
            txtHabitaciones.Enabled = true;
            txtM2Ed.Enabled = true;
            txtPiso.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void DejoActualizar()
        {
            tsbDelApto.Enabled = true;
            tsbEditApto.Enabled = true;
            tsbClean.Enabled = true;

            tsbAddApto.Enabled = false;
            txtPadron.Enabled = false;

            txtAcronimo.Enabled = true;
            txtBaños.Enabled = true;
            txtDireccion.Enabled = true;
            txtHabitaciones.Enabled = true;
            txtM2Ed.Enabled = true;
            txtPiso.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void Limpiar()
        {
            tsbDelApto.Enabled = false;
            tsbEditApto.Enabled = false;
            tsbClean.Enabled = true;
            tsbAddApto.Enabled = false;

            txtPadron.Enabled = true;
            txtAcronimo.Enabled = false;
            txtBaños.Enabled = false;
            txtDireccion.Enabled = false;
            txtHabitaciones.Enabled = false;
            txtM2Ed.Enabled = false;
            txtPiso.Enabled = false;
            txtPrecio.Enabled = false;

            cbxAccion.SelectedIndex = 0;
            cbxDepartamento.SelectedIndex = 0;
            txtPadron.Text = "";
            txtAcronimo.Text = "";
            txtBaños.Text = "";
            txtDireccion.Text = "";
            txtHabitaciones.Text = "";
            txtM2Ed.Text = "";
            txtPiso.Text = "";
            txtPrecio.Text = "";
            txtFuncionario.Text = "";
            chbAscensor.Checked = false;
            
        }

        //se ejecuta cuando sale de txtPadron
        private void txtPadron_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Propiedad prop = LFabrica.getLogicaPropiedad().BuscarPropiedad(Convert.ToInt32(txtPadron.Text));
                if (prop != null)
                {
                    if (prop is Apartamento)
                    {
                        apto = (Apartamento)prop;

                        txtAcronimo.Text = apto.Departamento.Acronimo;
                        txtBaños.Text = apto.CantBaños.ToString();
                        txtDireccion.Text = apto.Direccion;
                        txtHabitaciones.Text = apto.CantHabit.ToString();
                        txtM2Ed.Text = apto.Mt2Ed.ToString();
                        txtPiso.Text = apto.Piso.ToString();
                        txtPrecio.Text = apto.Precio.ToString();
                        txtFuncionario.Text = apto.Usuario.Nombre;

                        chbAscensor.Checked = apto.Ascensor;
                        cbxAccion.SelectedItem = apto.Accion;
                        cbxDepartamento.SelectedItem = trabajoZona.NombreDepartamento(apto.Departamento.IDDepartamento);

                        DejoActualizar();
                    }
                    else
                        lblError.Text = "La propiedad no es un apto. ";
                }
                else
                    DejoAgregar();

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbAddApto_Click(object sender, EventArgs e)
        {
            try
            {
                int padron, precio, cantHabitaciones, mt2Ed, baños, piso;
                bool ascensor = chbAscensor.Checked;
                string accion, departamento, acronimo;

                padron = Convert.ToInt32(txtPadron.Text); 
                precio = Convert.ToInt32(txtPrecio.Text);
                cantHabitaciones = Convert.ToInt32(txtHabitaciones.Text);
                baños = Convert.ToInt32(txtBaños.Text);
                mt2Ed = Convert.ToInt32(txtHabitaciones.Text);
                piso = Convert.ToInt32(txtPiso.Text);
                accion = cbxAccion.Text;
                departamento = trabajoZona.IDDepartamento(cbxDepartamento.SelectedIndex.ToString());

                if (txtAcronimo.Text.Length == 3)
                    acronimo = txtAcronimo.Text;
                else
                    throw new Exception("El acronimo debe tener tres letras");

                Zona zon = LFabrica.GetInstZona().BuscarZona(departamento, txtAcronimo.Text);
                Funcionario fun = LFabrica.GetLogicaFun().BuscarFuncionario("Usuario1");

                if (zon != null && fun != null)
                {
                    Apartamento aptoNuevo = new Apartamento(padron, precio, baños, cantHabitaciones, mt2Ed, txtDireccion.Text, accion, zon, fun, piso, ascensor);
                    LFabrica.getLogicaPropiedad().AltaPropiedad(aptoNuevo);
                    Limpiar();
                    lblError.Text = "Alta con exito";
                }
                else
                {
                    lblError.Text = "No se encuentra la zona o el funcionario";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbDelApto_Click(object sender, EventArgs e)
        {
            try
            {
                LFabrica.getLogicaPropiedad().EliminarPropiedad(apto);
                Limpiar();
                lblError.Text = "Baja con exito";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbEditApto_Click(object sender, EventArgs e)
        {
            try
            {
                apto.Accion = cbxAccion.Text;
                apto.Ascensor = chbAscensor.Checked;
                apto.CantBaños = Convert.ToInt32(txtBaños.Text);
                apto.CantHabit = Convert.ToInt32(txtHabitaciones.Text);
                apto.Direccion = txtDireccion.Text;
                apto.Mt2Ed = Convert.ToInt32(txtM2Ed.Text);
                apto.Padron = Convert.ToInt32(txtPadron.Text);
                apto.Piso = Convert.ToInt32(txtPiso.Text);
                apto.Precio = Convert.ToInt32(txtPrecio.Text);
                string departamento = trabajoZona.IDDepartamento(cbxDepartamento.SelectedIndex.ToString());
                
                Zona zon = LFabrica.GetInstZona().BuscarZona(departamento, txtAcronimo.Text);
                Funcionario fun = LFabrica.GetLogicaFun().BuscarFuncionario("Usuario1");

                apto.Departamento = zon;
                apto.Usuario = fun;

                LFabrica.getLogicaPropiedad().ModificarPropiedad(apto);
                Limpiar();
                lblError.Text = "Modificacion con exito";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void tsbClean_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtPadron_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
