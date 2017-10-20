namespace APP_Admin
{
    partial class frmApartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApartamento));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPadron = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantBaños = new System.Windows.Forms.Label();
            this.lblCantHab = new System.Windows.Forms.Label();
            this.lblM2Ed = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblAscensor = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblAcronimo = new System.Windows.Forms.Label();
            this.txtPadron = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.txtM2Ed = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtAcronimo = new System.Windows.Forms.TextBox();
            this.cbxAccion = new System.Windows.Forms.ComboBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.chbAscensor = new System.Windows.Forms.CheckBox();
            this.tsbAddApto = new System.Windows.Forms.ToolStripButton();
            this.tsbEditApto = new System.Windows.Forms.ToolStripButton();
            this.tsbDelApto = new System.Windows.Forms.ToolStripButton();
            this.tsbClean = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(478, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ABM de Apartamentos";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblPadron
            // 
            this.lblPadron.AutoSize = true;
            this.lblPadron.Location = new System.Drawing.Point(317, 124);
            this.lblPadron.Name = "lblPadron";
            this.lblPadron.Size = new System.Drawing.Size(60, 20);
            this.lblPadron.TabIndex = 1;
            this.lblPadron.Text = "Padron";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(317, 173);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantBaños
            // 
            this.lblCantBaños.AutoSize = true;
            this.lblCantBaños.Location = new System.Drawing.Point(317, 223);
            this.lblCantBaños.Name = "lblCantBaños";
            this.lblCantBaños.Size = new System.Drawing.Size(147, 20);
            this.lblCantBaños.TabIndex = 1;
            this.lblCantBaños.Text = "Cantidad de baños:";
            // 
            // lblCantHab
            // 
            this.lblCantHab.AutoSize = true;
            this.lblCantHab.Location = new System.Drawing.Point(317, 273);
            this.lblCantHab.Name = "lblCantHab";
            this.lblCantHab.Size = new System.Drawing.Size(193, 20);
            this.lblCantHab.TabIndex = 1;
            this.lblCantHab.Text = "Cantidad de habitaciones:";
            // 
            // lblM2Ed
            // 
            this.lblM2Ed.AutoSize = true;
            this.lblM2Ed.Location = new System.Drawing.Point(317, 336);
            this.lblM2Ed.Name = "lblM2Ed";
            this.lblM2Ed.Size = new System.Drawing.Size(213, 20);
            this.lblM2Ed.TabIndex = 1;
            this.lblM2Ed.Text = "Metros cuadrados edificados";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(317, 398);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(317, 456);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(57, 20);
            this.lblAccion.TabIndex = 1;
            this.lblAccion.Text = "Accion";
            this.lblAccion.Click += new System.EventHandler(this.lblAccion_Click);
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(317, 514);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(39, 20);
            this.lblPiso.TabIndex = 2;
            this.lblPiso.Text = "Piso";
            // 
            // lblAscensor
            // 
            this.lblAscensor.AutoSize = true;
            this.lblAscensor.Location = new System.Drawing.Point(317, 582);
            this.lblAscensor.Name = "lblAscensor";
            this.lblAscensor.Size = new System.Drawing.Size(76, 20);
            this.lblAscensor.TabIndex = 2;
            this.lblAscensor.Text = "Ascensor";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(317, 643);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(112, 20);
            this.lblDepartamento.TabIndex = 2;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblAcronimo
            // 
            this.lblAcronimo.AutoSize = true;
            this.lblAcronimo.Location = new System.Drawing.Point(317, 708);
            this.lblAcronimo.Name = "lblAcronimo";
            this.lblAcronimo.Size = new System.Drawing.Size(153, 20);
            this.lblAcronimo.TabIndex = 2;
            this.lblAcronimo.Text = "Acronimo de la zona";
            // 
            // txtPadron
            // 
            this.txtPadron.Location = new System.Drawing.Point(643, 118);
            this.txtPadron.Name = "txtPadron";
            this.txtPadron.Size = new System.Drawing.Size(232, 26);
            this.txtPadron.TabIndex = 0;
            this.txtPadron.TextChanged += new System.EventHandler(this.txtPadron_TextChanged);
            this.txtPadron.Validating += new System.ComponentModel.CancelEventHandler(this.txtPadron_Validating);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(643, 167);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(232, 26);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(643, 217);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(232, 26);
            this.txtBaños.TabIndex = 2;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(643, 267);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(232, 26);
            this.txtHabitaciones.TabIndex = 3;
            // 
            // txtM2Ed
            // 
            this.txtM2Ed.Location = new System.Drawing.Point(643, 330);
            this.txtM2Ed.Name = "txtM2Ed";
            this.txtM2Ed.Size = new System.Drawing.Size(232, 26);
            this.txtM2Ed.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(643, 392);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(232, 26);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(643, 508);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(232, 26);
            this.txtPiso.TabIndex = 7;
            // 
            // txtAcronimo
            // 
            this.txtAcronimo.Location = new System.Drawing.Point(643, 702);
            this.txtAcronimo.Name = "txtAcronimo";
            this.txtAcronimo.Size = new System.Drawing.Size(232, 26);
            this.txtAcronimo.TabIndex = 10;
            // 
            // cbxAccion
            // 
            this.cbxAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccion.FormattingEnabled = true;
            this.cbxAccion.Items.AddRange(new object[] {
            "Alquiler",
            "Permuta",
            "Venta"});
            this.cbxAccion.Location = new System.Drawing.Point(643, 447);
            this.cbxAccion.Name = "cbxAccion";
            this.cbxAccion.Size = new System.Drawing.Size(121, 28);
            this.cbxAccion.TabIndex = 6;
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
            this.cbxDepartamento.Location = new System.Drawing.Point(643, 634);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(121, 28);
            this.cbxDepartamento.TabIndex = 9;
            // 
            // chbAscensor
            // 
            this.chbAscensor.AutoSize = true;
            this.chbAscensor.Location = new System.Drawing.Point(643, 577);
            this.chbAscensor.Name = "chbAscensor";
            this.chbAscensor.Size = new System.Drawing.Size(102, 24);
            this.chbAscensor.TabIndex = 8;
            this.chbAscensor.Text = "Ascensor";
            this.chbAscensor.UseVisualStyleBackColor = true;
            // 
            // tsbAddApto
            // 
            this.tsbAddApto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddApto.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddApto.Image")));
            this.tsbAddApto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddApto.Name = "tsbAddApto";
            this.tsbAddApto.Size = new System.Drawing.Size(34, 34);
            this.tsbAddApto.Text = "Agrega Apartamento";
            this.tsbAddApto.ToolTipText = "Utilice para agregar un Apartamento al Sistema";
            this.tsbAddApto.Click += new System.EventHandler(this.tsbAddApto_Click);
            // 
            // tsbEditApto
            // 
            this.tsbEditApto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditApto.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditApto.Image")));
            this.tsbEditApto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditApto.Name = "tsbEditApto";
            this.tsbEditApto.Size = new System.Drawing.Size(34, 34);
            this.tsbEditApto.Text = "Editar Apartamento";
            this.tsbEditApto.ToolTipText = "Utilice para Actualizar un apartamento";
            this.tsbEditApto.Click += new System.EventHandler(this.tsbEditApto_Click);
            // 
            // tsbDelApto
            // 
            this.tsbDelApto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelApto.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelApto.Image")));
            this.tsbDelApto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelApto.Name = "tsbDelApto";
            this.tsbDelApto.Size = new System.Drawing.Size(34, 34);
            this.tsbDelApto.Text = "Eliminar un Apartamento";
            this.tsbDelApto.ToolTipText = "Utilice para eliminar un apartamento";
            this.tsbDelApto.Click += new System.EventHandler(this.tsbDelApto_Click);
            // 
            // tsbClean
            // 
            this.tsbClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClean.Image = ((System.Drawing.Image)(resources.GetObject("tsbClean.Image")));
            this.tsbClean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClean.Name = "tsbClean";
            this.tsbClean.Size = new System.Drawing.Size(34, 34);
            this.tsbClean.Text = "Limpiar Campos";
            this.tsbClean.ToolTipText = "Utilice para limpiar todos los campos";
            this.tsbClean.Click += new System.EventHandler(this.tsbClean_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddApto,
            this.tsbDelApto,
            this.tsbEditApto,
            this.tsbClean});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1134, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 851);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1134, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblError
            // 
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(317, 771);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(226, 20);
            this.lblFuncionario.TabIndex = 34;
            this.lblFuncionario.Text = "Ultimo funcionario en modificar";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(643, 765);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(232, 26);
            this.txtFuncionario.TabIndex = 33;
            // 
            // frmApartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1134, 873);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chbAscensor);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.cbxAccion);
            this.Controls.Add(this.txtAcronimo);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtM2Ed);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPadron);
            this.Controls.Add(this.lblAcronimo);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblAscensor);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblM2Ed);
            this.Controls.Add(this.lblCantHab);
            this.Controls.Add(this.lblCantBaños);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPadron);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmApartamento";
            this.Text = "Gestión Apartamento";
            this.Load += new System.EventHandler(this.frmApartamento_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPadron;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantBaños;
        private System.Windows.Forms.Label lblCantHab;
        private System.Windows.Forms.Label lblM2Ed;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblAscensor;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblAcronimo;
        private System.Windows.Forms.TextBox txtPadron;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.TextBox txtM2Ed;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtAcronimo;
        private System.Windows.Forms.ComboBox cbxAccion;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.CheckBox chbAscensor;
        private System.Windows.Forms.ToolStripButton tsbAddApto;
        private System.Windows.Forms.ToolStripButton tsbEditApto;
        private System.Windows.Forms.ToolStripButton tsbDelApto;
        private System.Windows.Forms.ToolStripButton tsbClean;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblError;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
    }
}