namespace APP_Admin
{
    partial class frmLocal_Comercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocal_Comercial));
            this.tsbLocales = new System.Windows.Forms.ToolStrip();
            this.tsbAddLocal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsbEditLocal = new System.Windows.Forms.ToolStripButton();
            this.tsbCleanLocal = new System.Windows.Forms.ToolStripButton();
            this.chbHabilitacion = new System.Windows.Forms.CheckBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.cbxAccion = new System.Windows.Forms.ComboBox();
            this.txtAcronimo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtM2Ed = new System.Windows.Forms.TextBox();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPadron = new System.Windows.Forms.TextBox();
            this.lblAcronimo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblHabilitacion = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblM2Ed = new System.Windows.Forms.Label();
            this.lblCantHab = new System.Windows.Forms.Label();
            this.lblCantBaños = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPadron = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.tsbLocales.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbLocales
            // 
            this.tsbLocales.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tsbLocales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddLocal,
            this.toolStripButton4,
            this.tsbEditLocal,
            this.tsbCleanLocal});
            this.tsbLocales.Location = new System.Drawing.Point(0, 0);
            this.tsbLocales.Name = "tsbLocales";
            this.tsbLocales.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsbLocales.Size = new System.Drawing.Size(1132, 37);
            this.tsbLocales.TabIndex = 0;
            // 
            // tsbAddLocal
            // 
            this.tsbAddLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddLocal.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddLocal.Image")));
            this.tsbAddLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddLocal.Name = "tsbAddLocal";
            this.tsbAddLocal.Size = new System.Drawing.Size(34, 34);
            this.tsbAddLocal.Text = "Agregar un Local Comercial";
            this.tsbAddLocal.ToolTipText = "Utilice para agregar un Local Comercial";
            this.tsbAddLocal.Click += new System.EventHandler(this.tsbAddLocal_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton4.Text = "Eliminar un Local Comercial";
            this.toolStripButton4.ToolTipText = "Utilice para eliminar un Local Comercial";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsbEditLocal
            // 
            this.tsbEditLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditLocal.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditLocal.Image")));
            this.tsbEditLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditLocal.Name = "tsbEditLocal";
            this.tsbEditLocal.Size = new System.Drawing.Size(34, 34);
            this.tsbEditLocal.Text = "Editar Local Comercial";
            this.tsbEditLocal.ToolTipText = "Utilice para editar un Local Comercial";
            this.tsbEditLocal.Click += new System.EventHandler(this.tsbEditLocal_Click);
            // 
            // tsbCleanLocal
            // 
            this.tsbCleanLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCleanLocal.Image = ((System.Drawing.Image)(resources.GetObject("tsbCleanLocal.Image")));
            this.tsbCleanLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCleanLocal.Name = "tsbCleanLocal";
            this.tsbCleanLocal.Size = new System.Drawing.Size(34, 34);
            this.tsbCleanLocal.Text = "Limpiar Campos";
            this.tsbCleanLocal.ToolTipText = "Utilice para limpiar todos los campos";
            this.tsbCleanLocal.Click += new System.EventHandler(this.tsbCleanLocal_Click);
            // 
            // chbHabilitacion
            // 
            this.chbHabilitacion.AutoSize = true;
            this.chbHabilitacion.Location = new System.Drawing.Point(580, 530);
            this.chbHabilitacion.Name = "chbHabilitacion";
            this.chbHabilitacion.Size = new System.Drawing.Size(117, 24);
            this.chbHabilitacion.TabIndex = 28;
            this.chbHabilitacion.Text = "Habilitacion";
            this.chbHabilitacion.UseVisualStyleBackColor = true;
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Items.AddRange(new object[] {
            "Canelones",
            "Maldonado",
            "Rocha",
            "Treinta y Tres",
            "Cerro Largo",
            "Rivera",
            "Artigas",
            "Salto",
            "Paysandú",
            "Río Negro",
            "Soriano",
            "Colonia",
            "San José",
            "Flores",
            "Florida",
            "Lavalleja",
            "Durazno",
            "Tacuarembó",
            "Montevideo"});
            this.cbxDepartamento.Location = new System.Drawing.Point(580, 587);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(121, 28);
            this.cbxDepartamento.TabIndex = 27;
            // 
            // cbxAccion
            // 
            this.cbxAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccion.FormattingEnabled = true;
            this.cbxAccion.Items.AddRange(new object[] {
            "Alquiler",
            "Permuta",
            "Venta"});
            this.cbxAccion.Location = new System.Drawing.Point(580, 461);
            this.cbxAccion.Name = "cbxAccion";
            this.cbxAccion.Size = new System.Drawing.Size(121, 28);
            this.cbxAccion.TabIndex = 26;
            // 
            // txtAcronimo
            // 
            this.txtAcronimo.Location = new System.Drawing.Point(580, 655);
            this.txtAcronimo.Name = "txtAcronimo";
            this.txtAcronimo.Size = new System.Drawing.Size(232, 26);
            this.txtAcronimo.TabIndex = 20;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(580, 406);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(232, 26);
            this.txtDireccion.TabIndex = 18;
            // 
            // txtM2Ed
            // 
            this.txtM2Ed.Location = new System.Drawing.Point(580, 344);
            this.txtM2Ed.Name = "txtM2Ed";
            this.txtM2Ed.Size = new System.Drawing.Size(232, 26);
            this.txtM2Ed.TabIndex = 19;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(580, 281);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(232, 26);
            this.txtHabitaciones.TabIndex = 24;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(580, 231);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(232, 26);
            this.txtBaños.TabIndex = 25;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(580, 181);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(232, 26);
            this.txtPrecio.TabIndex = 22;
            // 
            // txtPadron
            // 
            this.txtPadron.Location = new System.Drawing.Point(580, 132);
            this.txtPadron.Name = "txtPadron";
            this.txtPadron.Size = new System.Drawing.Size(232, 26);
            this.txtPadron.TabIndex = 23;
            this.txtPadron.Validating += new System.ComponentModel.CancelEventHandler(this.txtPadron_Validating);
            // 
            // lblAcronimo
            // 
            this.lblAcronimo.AutoSize = true;
            this.lblAcronimo.Location = new System.Drawing.Point(254, 661);
            this.lblAcronimo.Name = "lblAcronimo";
            this.lblAcronimo.Size = new System.Drawing.Size(153, 20);
            this.lblAcronimo.TabIndex = 15;
            this.lblAcronimo.Text = "Acronimo de la zona";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(254, 596);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(112, 20);
            this.lblDepartamento.TabIndex = 14;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblHabilitacion
            // 
            this.lblHabilitacion.AutoSize = true;
            this.lblHabilitacion.Location = new System.Drawing.Point(254, 535);
            this.lblHabilitacion.Name = "lblHabilitacion";
            this.lblHabilitacion.Size = new System.Drawing.Size(91, 20);
            this.lblHabilitacion.TabIndex = 17;
            this.lblHabilitacion.Text = "Habilitacion";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(254, 470);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(57, 20);
            this.lblAccion.TabIndex = 9;
            this.lblAccion.Text = "Accion";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(254, 412);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblM2Ed
            // 
            this.lblM2Ed.AutoSize = true;
            this.lblM2Ed.Location = new System.Drawing.Point(254, 350);
            this.lblM2Ed.Name = "lblM2Ed";
            this.lblM2Ed.Size = new System.Drawing.Size(213, 20);
            this.lblM2Ed.TabIndex = 7;
            this.lblM2Ed.Text = "Metros cuadrados edificados";
            // 
            // lblCantHab
            // 
            this.lblCantHab.AutoSize = true;
            this.lblCantHab.Location = new System.Drawing.Point(254, 287);
            this.lblCantHab.Name = "lblCantHab";
            this.lblCantHab.Size = new System.Drawing.Size(193, 20);
            this.lblCantHab.TabIndex = 10;
            this.lblCantHab.Text = "Cantidad de habitaciones:";
            // 
            // lblCantBaños
            // 
            this.lblCantBaños.AutoSize = true;
            this.lblCantBaños.Location = new System.Drawing.Point(254, 237);
            this.lblCantBaños.Name = "lblCantBaños";
            this.lblCantBaños.Size = new System.Drawing.Size(147, 20);
            this.lblCantBaños.TabIndex = 13;
            this.lblCantBaños.Text = "Cantidad de baños:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(254, 187);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // lblPadron
            // 
            this.lblPadron.AutoSize = true;
            this.lblPadron.Location = new System.Drawing.Point(254, 138);
            this.lblPadron.Name = "lblPadron";
            this.lblPadron.Size = new System.Drawing.Size(60, 20);
            this.lblPadron.TabIndex = 11;
            this.lblPadron.Text = "Padron";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(434, 69);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 20);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "ABM Local Comercial";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 798);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1132, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblError
            // 
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(580, 724);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(232, 26);
            this.txtFuncionario.TabIndex = 31;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(254, 730);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(226, 20);
            this.lblFuncionario.TabIndex = 32;
            this.lblFuncionario.Text = "Ultimo funcionario en modificar";
            // 
            // frmLocal_Comercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1132, 820);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.chbHabilitacion);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.cbxAccion);
            this.Controls.Add(this.txtAcronimo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtM2Ed);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPadron);
            this.Controls.Add(this.lblAcronimo);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblHabilitacion);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblM2Ed);
            this.Controls.Add(this.lblCantHab);
            this.Controls.Add(this.lblCantBaños);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPadron);
            this.Controls.Add(this.tsbLocales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLocal_Comercial";
            this.Text = "Gestión de Locales Comerciales";
            this.Load += new System.EventHandler(this.frmLocal_Comercial_Load);
            this.tsbLocales.ResumeLayout(false);
            this.tsbLocales.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsbLocales;
        private System.Windows.Forms.ToolStripButton tsbAddLocal;
        private System.Windows.Forms.ToolStripButton tsbEditLocal;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbCleanLocal;
        private System.Windows.Forms.CheckBox chbHabilitacion;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.ComboBox cbxAccion;
        private System.Windows.Forms.TextBox txtAcronimo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtM2Ed;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPadron;
        private System.Windows.Forms.Label lblAcronimo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblHabilitacion;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblM2Ed;
        private System.Windows.Forms.Label lblCantHab;
        private System.Windows.Forms.Label lblCantBaños;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPadron;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblError;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
    }
}