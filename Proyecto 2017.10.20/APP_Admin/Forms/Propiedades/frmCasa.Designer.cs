namespace APP_Admin
{
    partial class frmCasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCasa));
            this.tsCasa = new System.Windows.Forms.ToolStrip();
            this.tsbAddCasa = new System.Windows.Forms.ToolStripButton();
            this.tsbDelCasa = new System.Windows.Forms.ToolStripButton();
            this.tsbEditCasa = new System.Windows.Forms.ToolStripButton();
            this.tsbCleanCasa = new System.Windows.Forms.ToolStripButton();
            this.chbPatio = new System.Windows.Forms.CheckBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.cbxAccion = new System.Windows.Forms.ComboBox();
            this.txtAcronimo = new System.Windows.Forms.TextBox();
            this.txtM2Terr = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtM2Ed = new System.Windows.Forms.TextBox();
            this.txtHabitaciones = new System.Windows.Forms.TextBox();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPadron = new System.Windows.Forms.TextBox();
            this.lblAcronimo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblPatio = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
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
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.tsCasa.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCasa
            // 
            this.tsCasa.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tsCasa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddCasa,
            this.tsbDelCasa,
            this.tsbEditCasa,
            this.tsbCleanCasa});
            this.tsCasa.Location = new System.Drawing.Point(0, 0);
            this.tsCasa.Name = "tsCasa";
            this.tsCasa.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsCasa.Size = new System.Drawing.Size(1146, 37);
            this.tsCasa.TabIndex = 0;
            // 
            // tsbAddCasa
            // 
            this.tsbAddCasa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddCasa.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddCasa.Image")));
            this.tsbAddCasa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddCasa.Name = "tsbAddCasa";
            this.tsbAddCasa.Size = new System.Drawing.Size(34, 34);
            this.tsbAddCasa.Text = "Agregar Casa";
            this.tsbAddCasa.ToolTipText = "Utilice para agregar una Casa en el Sistema";
            this.tsbAddCasa.Click += new System.EventHandler(this.tsbAddCasa_Click);
            // 
            // tsbDelCasa
            // 
            this.tsbDelCasa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelCasa.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelCasa.Image")));
            this.tsbDelCasa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelCasa.Name = "tsbDelCasa";
            this.tsbDelCasa.Size = new System.Drawing.Size(34, 34);
            this.tsbDelCasa.Text = "Eliminar Casa";
            this.tsbDelCasa.ToolTipText = "Utilice para eliminar una Casa del Sistema";
            this.tsbDelCasa.Click += new System.EventHandler(this.tsbDelCasa_Click);
            // 
            // tsbEditCasa
            // 
            this.tsbEditCasa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditCasa.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditCasa.Image")));
            this.tsbEditCasa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditCasa.Name = "tsbEditCasa";
            this.tsbEditCasa.Size = new System.Drawing.Size(34, 34);
            this.tsbEditCasa.Text = "Editar Casa";
            this.tsbEditCasa.ToolTipText = "Utilice para editar una Casa";
            this.tsbEditCasa.Click += new System.EventHandler(this.tsbEditCasa_Click);
            // 
            // tsbCleanCasa
            // 
            this.tsbCleanCasa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCleanCasa.Image = ((System.Drawing.Image)(resources.GetObject("tsbCleanCasa.Image")));
            this.tsbCleanCasa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCleanCasa.Name = "tsbCleanCasa";
            this.tsbCleanCasa.Size = new System.Drawing.Size(34, 34);
            this.tsbCleanCasa.Text = "Limpiar Campos";
            this.tsbCleanCasa.ToolTipText = "Utilice para limpiar todos los campos";
            this.tsbCleanCasa.Click += new System.EventHandler(this.tsbCleanCasa_Click);
            // 
            // chbPatio
            // 
            this.chbPatio.AutoSize = true;
            this.chbPatio.Location = new System.Drawing.Point(609, 587);
            this.chbPatio.Name = "chbPatio";
            this.chbPatio.Size = new System.Drawing.Size(131, 24);
            this.chbPatio.TabIndex = 8;
            this.chbPatio.Text = "Patio o Jardin";
            this.chbPatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbPatio.UseVisualStyleBackColor = true;
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
            this.cbxDepartamento.Location = new System.Drawing.Point(609, 644);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(121, 28);
            this.cbxDepartamento.TabIndex = 9;
            // 
            // cbxAccion
            // 
            this.cbxAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccion.FormattingEnabled = true;
            this.cbxAccion.Items.AddRange(new object[] {
            "Alquiler",
            "Permuta",
            "Venta"});
            this.cbxAccion.Location = new System.Drawing.Point(609, 457);
            this.cbxAccion.Name = "cbxAccion";
            this.cbxAccion.Size = new System.Drawing.Size(121, 28);
            this.cbxAccion.TabIndex = 6;
            // 
            // txtAcronimo
            // 
            this.txtAcronimo.Location = new System.Drawing.Point(609, 712);
            this.txtAcronimo.Name = "txtAcronimo";
            this.txtAcronimo.Size = new System.Drawing.Size(232, 26);
            this.txtAcronimo.TabIndex = 10;
            // 
            // txtM2Terr
            // 
            this.txtM2Terr.Location = new System.Drawing.Point(609, 518);
            this.txtM2Terr.Name = "txtM2Terr";
            this.txtM2Terr.Size = new System.Drawing.Size(232, 26);
            this.txtM2Terr.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(609, 402);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(232, 26);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtM2Ed
            // 
            this.txtM2Ed.Location = new System.Drawing.Point(609, 340);
            this.txtM2Ed.Name = "txtM2Ed";
            this.txtM2Ed.Size = new System.Drawing.Size(232, 26);
            this.txtM2Ed.TabIndex = 4;
            // 
            // txtHabitaciones
            // 
            this.txtHabitaciones.Location = new System.Drawing.Point(609, 277);
            this.txtHabitaciones.Name = "txtHabitaciones";
            this.txtHabitaciones.Size = new System.Drawing.Size(232, 26);
            this.txtHabitaciones.TabIndex = 3;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(609, 227);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(232, 26);
            this.txtBaños.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(609, 177);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(232, 26);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtPadron
            // 
            this.txtPadron.Location = new System.Drawing.Point(609, 128);
            this.txtPadron.Name = "txtPadron";
            this.txtPadron.Size = new System.Drawing.Size(232, 26);
            this.txtPadron.TabIndex = 0;
            this.txtPadron.Validating += new System.ComponentModel.CancelEventHandler(this.txtPadron_Validating);
            // 
            // lblAcronimo
            // 
            this.lblAcronimo.AutoSize = true;
            this.lblAcronimo.Location = new System.Drawing.Point(283, 718);
            this.lblAcronimo.Name = "lblAcronimo";
            this.lblAcronimo.Size = new System.Drawing.Size(153, 20);
            this.lblAcronimo.TabIndex = 15;
            this.lblAcronimo.Text = "Acronimo de la zona";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(283, 653);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(112, 20);
            this.lblDepartamento.TabIndex = 14;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblPatio
            // 
            this.lblPatio.AutoSize = true;
            this.lblPatio.Location = new System.Drawing.Point(283, 592);
            this.lblPatio.Name = "lblPatio";
            this.lblPatio.Size = new System.Drawing.Size(109, 20);
            this.lblPatio.TabIndex = 17;
            this.lblPatio.Text = "Patio o Jardin:";
            this.lblPatio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(283, 524);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(214, 20);
            this.lblPiso.TabIndex = 16;
            this.lblPiso.Text = "Metros cuadrados de terreno";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(283, 466);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(57, 20);
            this.lblAccion.TabIndex = 9;
            this.lblAccion.Text = "Accion";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(283, 408);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblM2Ed
            // 
            this.lblM2Ed.AutoSize = true;
            this.lblM2Ed.Location = new System.Drawing.Point(283, 346);
            this.lblM2Ed.Name = "lblM2Ed";
            this.lblM2Ed.Size = new System.Drawing.Size(213, 20);
            this.lblM2Ed.TabIndex = 7;
            this.lblM2Ed.Text = "Metros cuadrados edificados";
            // 
            // lblCantHab
            // 
            this.lblCantHab.AutoSize = true;
            this.lblCantHab.Location = new System.Drawing.Point(283, 283);
            this.lblCantHab.Name = "lblCantHab";
            this.lblCantHab.Size = new System.Drawing.Size(193, 20);
            this.lblCantHab.TabIndex = 10;
            this.lblCantHab.Text = "Cantidad de habitaciones:";
            // 
            // lblCantBaños
            // 
            this.lblCantBaños.AutoSize = true;
            this.lblCantBaños.Location = new System.Drawing.Point(283, 233);
            this.lblCantBaños.Name = "lblCantBaños";
            this.lblCantBaños.Size = new System.Drawing.Size(147, 20);
            this.lblCantBaños.TabIndex = 13;
            this.lblCantBaños.Text = "Cantidad de baños:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(283, 183);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // lblPadron
            // 
            this.lblPadron.AutoSize = true;
            this.lblPadron.Location = new System.Drawing.Point(283, 134);
            this.lblPadron.Name = "lblPadron";
            this.lblPadron.Size = new System.Drawing.Size(60, 20);
            this.lblPadron.TabIndex = 11;
            this.lblPadron.Text = "Padron";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(497, 61);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(93, 20);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "ABM Casas";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 821);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1146, 22);
            this.statusStrip1.TabIndex = 30;
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
            this.lblFuncionario.Location = new System.Drawing.Point(283, 777);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(226, 20);
            this.lblFuncionario.TabIndex = 34;
            this.lblFuncionario.Text = "Ultimo funcionario en modificar";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(609, 771);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(232, 26);
            this.txtFuncionario.TabIndex = 33;
            // 
            // frmCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1146, 843);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.chbPatio);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.cbxAccion);
            this.Controls.Add(this.txtAcronimo);
            this.Controls.Add(this.txtM2Terr);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtM2Ed);
            this.Controls.Add(this.txtHabitaciones);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPadron);
            this.Controls.Add(this.lblAcronimo);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblPatio);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblM2Ed);
            this.Controls.Add(this.lblCantHab);
            this.Controls.Add(this.lblCantBaños);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPadron);
            this.Controls.Add(this.tsCasa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCasa";
            this.Text = "Gestión de Casas";
            this.Load += new System.EventHandler(this.frmCasa_Load);
            this.tsCasa.ResumeLayout(false);
            this.tsCasa.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCasa;
        private System.Windows.Forms.ToolStripButton tsbAddCasa;
        private System.Windows.Forms.ToolStripButton tsbEditCasa;
        private System.Windows.Forms.ToolStripButton tsbDelCasa;
        private System.Windows.Forms.ToolStripButton tsbCleanCasa;
        private System.Windows.Forms.CheckBox chbPatio;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.ComboBox cbxAccion;
        private System.Windows.Forms.TextBox txtAcronimo;
        private System.Windows.Forms.TextBox txtM2Terr;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtM2Ed;
        private System.Windows.Forms.TextBox txtHabitaciones;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPadron;
        private System.Windows.Forms.Label lblAcronimo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPatio;
        private System.Windows.Forms.Label lblPiso;
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
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
    }
}