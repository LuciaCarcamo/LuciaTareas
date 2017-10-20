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
    public partial class frmZona : Form
    {
        private int servicioSeleccionado = 0;
        private bool nuevaZona;
        private Zona z = null;
        private Servicio servicio = null;
        private List<Servicio> listaServicios = new List<Servicio>();

        public frmZona()
        {            
            InitializeComponent();
        }
       
        private void frmZona_Load(object sender, EventArgs e)
        {
            Deshabbotones();
        }

        //Funciones
        private void Deshabbotones()
        {
           
            tsbZDel.Enabled = false;
            tsbZUpd.Enabled = false;
            tsbSave.Enabled = false;
            tsbRollBackZona.Enabled = false;
            GestionServicio(false);
        }
        private void GestionServicio(bool estado)
        {
            txtServ.Enabled = estado;
            tsbServDel.Enabled = estado;
            tsbServADD.Enabled = estado;
            tslServ.Enabled = estado;
            txtServ.Enabled = estado;
        }
        private bool Validar()
        {
            if ((cmbDpto.SelectedIndex <= -1) || (cmbDpto.SelectedIndex > 19))
            {
                errorZ.SetError(cmbDpto, "Debe seleccionar un Departamento. ");
                return false;
            }
            errorZ.SetError(cmbDpto, string.Empty);
            if(string.IsNullOrEmpty(txtAcron.Text) || (txtAcron.Text.Length != 3))
            {
                errorZ.SetError(txtAcron, "Identificador para la Zona, su ingreso es obligatorio (TRES LETRAS). ");
                return false;
            }
            errorZ.SetError(txtAcron, string.Empty);
            return true;
        }
        private bool ValidarAlta()
        {
            if ((cmbDpto.SelectedIndex == -1) || (cmbDpto.SelectedIndex > 19))
            {
                errorZ.SetError(cmbDpto, "Debe seleccionar un identificador para el Departamento, despliegue el combo por favor. ");
                return false;
            }
            errorZ.SetError(cmbDpto, string.Empty);
            if (string.IsNullOrEmpty(txtAcron.Text) || (txtAcron.Text.Length != 3))
            {
                errorZ.SetError(txtAcron, "Identificador para la Zona, su ingreso es obligatorio (TRES LETRAS). ");
                return false;
            }
            errorZ.SetError(txtAcron, string.Empty);
            if (string.IsNullOrEmpty(txtNomOficial.Text))
            {
                errorZ.SetError(txtNomOficial, "Nombre Oficial es de uso obligatorio para ingresar una nueva Zona. ");
                return false;
            }
            errorZ.SetError(txtNomOficial, string.Empty);
            if (string.IsNullOrEmpty(txtHab.Text))
            {
                errorZ.SetError(txtHab, "Cantidad de Habitantes es de uso obligatorio . ");
                return false;
            }
            errorZ.SetError(txtHab, string.Empty);
            return true;
        }
       
        private void BuscaZona()
        {
            if (!Validar())return;
            string idDpto = trabajoZona.IDDepartamento(cmbDpto.SelectedItem.ToString());
            ILogicaZona lz = LFabrica.GetInstZona();
            z = lz.BuscarZona(idDpto, txtAcron.Text.Trim());

            if (z != null)
            {
                nuevaZona = false;
                tsbCancelar.Enabled = true;
                tsbZUpd.Enabled = true;
                tsbZDel.Enabled = true;
                MostrarZona(z);
            }
            else
            {
                nuevaZona = true;
                dgvServicios.DataSource = null;
                tsslError.ForeColor = Color.Blue;
                tsslError.BackColor = Color.Yellow;
                tsbCancelar.Enabled = true;
                HabilitarAlta();
                tsbAddZona.Enabled = false;
                tsbSave.Enabled = true;
                txtAcron.Enabled = false;
                cmbDpto.Enabled = false;
                tsslError.Text = "No se encontró la Zona en el sistema con los datos ingresados, cargue la información restante para darle de Alta ";
            }
        }
        private void ActivaCampos(bool estado)
        {
            cmbDpto.Enabled = estado;
            txtAcron.Enabled = estado;
            txtNomOficial.Enabled = estado;
            txtHab.Enabled = estado;
        }
        private void MostrarZona(Zona z)
        {
            ActivaCampos(false);
            cmbDpto.SelectedItem = z.IDDepartamento;
            txtAcron.Text = z.Acronimo;
            txtNomOficial.Text = z.NombreOficial;
            txtHab.Text = z.Habitantes.ToString();
            listaServicios = z.Servicios;
            dgvServicios.DataSource = null;
            dgvServicios.DataSource = listaServicios;
            GestionServicio(false);
            lbl3letras.Text = string.Empty;
            tsslError.Text = "Clic en el botón editar para modificar la información";
        }
        private void LimpiarCampos()
        {
            txtAcron.Text = "";
            cmbDpto.SelectedIndex = -1;
            txtHab.Text = "";
            txtNomOficial.Text = "";
            dgvServicios.DataSource = "";
        }
        private void LimpiarMensajes()
        {
            errorZ.SetError(cmbDpto, string.Empty);
            errorZ.SetError(txtAcron, string.Empty);
            errorZ.SetError(txtNomOficial, string.Empty);
            errorZ.SetError(txtHab, string.Empty);
            errorZ.SetError(txtServ, string.Empty);
            txtServ.Text = string.Empty;
            tsslError.Text = string.Empty;
        }
        private void Reload()
        {
            z = null;
            listaServicios.Clear();
            dgvServicios.DataSource = null;
            ActivaCampos(true);
            GestionServicio(true);
            LimpiarCampos();
            LimpiarMensajes();
            Deshabbotones();
        }
        private void HabilitarAlta()
        {
            nuevaZona = true;
            ActivaCampos(true);
            GestionServicio(true);
            LimpiarMensajes();
            tsbCancelar.Enabled = true;
        }
        private void HabilitarEdicion()
        {
            tsslError.Text = string.Empty;
            tsbZUpd.Enabled = false;
            GestionServicio(true);
            ActivaCampos(true);
            txtAcron.Enabled = false;
            cmbDpto.Enabled = false;
        }
       
        private void AgregarUnServicio()
        {
            tsslError.Text = "";
            errorZ.SetError(txtServ, "");
            if (string.IsNullOrEmpty(txtServ.Text))
            {
                errorZ.SetError(txtServ, "Para poder ingresar un Servicio, complete el campo con el nombre del mismo. ");
                txtServ.Focus();
                return;
            }
            errorZ.SetError(txtServ, "");
            try
            {
                servicio = new Servicio(txtServ.Text.Trim().ToUpper());
                for (int i = 0; i < listaServicios.Count; i++)
                {
                    if (listaServicios[i].Nombre == txtServ.Text.Trim().ToUpper()) return;
                    errorZ.SetError(txtServ, "El servicio que desea agregar ya se encuentra en la lista para esta Zona con ese nombre. ");
                    txtServ.Focus();
                }
                errorZ.SetError(txtServ, string.Empty);
                listaServicios.Add(servicio);
                dgvServicios.DataSource = null;
                dgvServicios.DataSource = listaServicios;
                txtServ.Text = "";
                txtServ.Focus();
            }
            catch (Exception er)
            {
                tsslError.Text = er.Message;
            }
        }
        



        private void cmbDpto_Validating(object sender, CancelEventArgs e)
        {
            if (!Validar()) e.Cancel = true;
            if (cmbDpto.SelectedIndex > -1) e.Cancel = false;
        }
        private void cmbDpto_Validated(object sender, EventArgs e)
        {
            txtAcron.Focus();
        }
        private void cmbDpto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbDpto.SelectedIndex > -1) && (cmbDpto.SelectedIndex <= 19))
                lblLetra.Text = "Identificador: " +trabajoZona.IDDepartamento(cmbDpto.SelectedItem.ToString());
            else
                lblLetra.Text = string.Empty;
        }
        private void cmbDpto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtAcron.Focus();
            }
            
        }
      

        private void txtAcron_Validating(object sender, CancelEventArgs e)
        {
            if (!Validar()) e.Cancel = true;
            if (txtAcron.TextLength == 3) e.Cancel = false;
        }
        private void txtAcron_Validated(object sender, EventArgs e)
        {
            BuscaZona();
            if(nuevaZona == false)
            tsbSave.Enabled = true;
        }
        private void txtAcron_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar)) && (!Char.IsControl(e.KeyChar))) e.Handled = true;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscaZona();
                if (nuevaZona == false)
                tsbSave.Enabled = true;
            }
        }


        private void txtHab_Validated(object sender, EventArgs e)
        {
            if(nuevaZona == true)
            tsbSave.Enabled = true;
        }
        private void txtHab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar))) e.Handled = true;
        }
        


        //BOTONES 

        //AGREGAR
        private void tsbAddZona_Click(object sender, EventArgs e)
        {
            HabilitarAlta();
            LimpiarCampos();
        }

        //ACTUALIZAR
        private void tsbZUpd_Click(object sender, EventArgs e)
        {
            HabilitarEdicion();
        }

        //CANCELAR
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbAddZona.Enabled = true;
            Reload();
          
        }

        //GUARDAR
        private void tsbSave_Click(object sender, EventArgs e)
        {
            tsbSave.Enabled = false;
           if(!ValidarAlta()) return;
           ILogicaZona lz = LFabrica.GetInstZona();
           string iddpto = trabajoZona.IDDepartamento(cmbDpto.SelectedItem.ToString());
           int habitantes = Convert.ToInt32(txtHab.Text.Trim());
           z = new Zona(iddpto, txtAcron.Text.Trim().ToUpper(),
               txtNomOficial.Text.Trim().ToUpper(), habitantes, listaServicios);
           
            if (nuevaZona == true)
           {
               tsslError.Text = string.Empty;
               try
               {
                   if (!ValidarAlta()) return;
                   lz.AltaZona(z);
                   z = lz.BuscarZona(z.IDDepartamento, z.Acronimo);
                   MostrarZona(z);
                   tsbAddZona.Enabled = true;
                   tsslError.Text = "Se guardó la información de la Zona en el sistema. ";
               }
               catch (Exception er)
               {
                   tsslError.Text = er.Message;
               }
           }
           else if (nuevaZona == false)
           {
               if (!ValidarAlta()) return;
               z.NombreOficial = txtNomOficial.Text.Trim();
               z.Habitantes = Convert.ToInt32(txtHab.Text.Trim());
               try
               {
                   lz.ModificaZona(z);
                   z = lz.BuscarZona(z.IDDepartamento, z.Acronimo);
                   MostrarZona(z);
                   tsbZUpd.Enabled = true;
                   tsslError.Text = "Se actualizó la información de la Zona " + z.NombreOficial + " en el sistema. ";
               }
               catch (Exception er)
               {
                   tsslError.Text = er.Message;
               }
           }
        }

       



        /*««« SERVICIOS »»»******************************************************************/

        private void tsbServADD_Click(object sender, EventArgs e)
        {
            AgregarUnServicio();
        }

       
        private void tsbServDel_Click(object sender, EventArgs e)
        {
            errorZ.SetError(txtServ, "");
            if (string.IsNullOrEmpty(txtServ.Text) || (dgvServicios.Rows.Count <= 0))
            {
                errorZ.SetError(txtServ, "Para poder eliminar un Servicio, seleccione una celda de la lista de Servicios de la derecha. Tiene que existir al menos uno. ");
                txtServ.Focus();
                return;
            }
            errorZ.SetError(txtServ, "");
            if (dgvServicios.Rows.Count == 0) return;
            try
            {
                for (int i = 0; i < listaServicios.Count; i++)
                {
                    if (listaServicios[i].Nombre == txtServ.Text.Trim())
                    {
                        listaServicios.RemoveAt(i);
                        dgvServicios.DataSource = null;
                        dgvServicios.DataSource = listaServicios;
                        txtServ.Text = "";
                    }
                }
            }
            catch (Exception er)
            {
                tsslError.Text = er.Message;
            }
        }
        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            servicioSeleccionado = e.RowIndex;

            try
            {
                if (servicioSeleccionado != -1)
                    txtServ.Text = (string)dgvServicios.Rows[servicioSeleccionado].Cells[0].Value;
            }
            catch (Exception er)
            {
                tsslError.Text = er.Message;
            }
        }

        private void tsbZDel_Click(object sender, EventArgs e)
        {
            string iddpto = trabajoZona.IDDepartamento(cmbDpto.SelectedItem.ToString());
            z = new Zona(iddpto, txtAcron.Text.Trim(), txtNomOficial.Text.Trim(), Convert.ToInt32(txtHab.Text.Trim()), listaServicios);
            DialogResult confirmacion = MessageBox.Show(" ¿Desea eliminar toda la información de la Zona " + z.NombreOficial + " existente en el Sistema? ", "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            try
            {
                if (confirmacion == DialogResult.No) return;
                else if (confirmacion == DialogResult.Yes)
                {
                    ILogicaZona lz = LFabrica.GetInstZona();
                    lz.BajaZona(z);
                    HabilitarAlta();
                    LimpiarCampos();
                    LimpiarMensajes();
                    tsslError.Text = "Baja de la Zona con éxito";
                }
            }
            catch (Exception er)
            {
                tsslError.Text = er.Message;
            }
        }

        private void txtServ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AgregarUnServicio();
            }
        }

        private void gbDatoZona_Enter(object sender, EventArgs e)
        {

        }

       
      
    }    
}
