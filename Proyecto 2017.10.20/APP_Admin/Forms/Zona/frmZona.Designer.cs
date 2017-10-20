namespace APP_Admin
{
    partial class frmZona
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZona));
            this.tstZona = new System.Windows.Forms.ToolStrip();
            this.tsbAddZona = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbZUpd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbZDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRollBackZona = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tslServ = new System.Windows.Forms.ToolStripLabel();
            this.tsbServADD = new System.Windows.Forms.ToolStripButton();
            this.tsbServDel = new System.Windows.Forms.ToolStripButton();
            this.tslZona = new System.Windows.Forms.ToolStripLabel();
            this.gbDatoZona = new System.Windows.Forms.GroupBox();
            this.cmbDpto = new System.Windows.Forms.ComboBox();
            this.txtServ = new System.Windows.Forms.TextBox();
            this.lblServ = new System.Windows.Forms.Label();
            this.txtHab = new System.Windows.Forms.TextBox();
            this.lblCantHab = new System.Windows.Forms.Label();
            this.txtNomOficial = new System.Windows.Forms.TextBox();
            this.lblNomOficial = new System.Windows.Forms.Label();
            this.lbl3letras = new System.Windows.Forms.Label();
            this.lblLetra = new System.Windows.Forms.Label();
            this.txtAcron = new System.Windows.Forms.TextBox();
            this.lblAcron = new System.Windows.Forms.Label();
            this.lblDpto = new System.Windows.Forms.Label();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.errorZ = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbServ = new System.Windows.Forms.GroupBox();
            this.ssZona = new System.Windows.Forms.StatusStrip();
            this.tsslError = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstZona.SuspendLayout();
            this.gbDatoZona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorZ)).BeginInit();
            this.gbServ.SuspendLayout();
            this.ssZona.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstZona
            // 
            this.tstZona.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tstZona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddZona,
            this.toolStripSeparator1,
            this.tsbZUpd,
            this.toolStripSeparator3,
            this.tsbZDel,
            this.toolStripSeparator4,
            this.tsbRollBackZona,
            this.toolStripSeparator2,
            this.tsbCancelar,
            this.toolStripSeparator5,
            this.tsbSave,
            this.toolStripSeparator6,
            this.tslServ,
            this.tsbServADD,
            this.tsbServDel,
            this.tslZona});
            this.tstZona.Location = new System.Drawing.Point(0, 0);
            this.tstZona.Name = "tstZona";
            this.tstZona.Size = new System.Drawing.Size(1351, 37);
            this.tstZona.TabIndex = 0;
            // 
            // tsbAddZona
            // 
            this.tsbAddZona.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddZona.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddZona.Image")));
            this.tsbAddZona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddZona.Name = "tsbAddZona";
            this.tsbAddZona.Size = new System.Drawing.Size(34, 34);
            this.tsbAddZona.Text = "Agregar una Zona al Sistema";
            this.tsbAddZona.Click += new System.EventHandler(this.tsbAddZona_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbZUpd
            // 
            this.tsbZUpd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZUpd.Image = ((System.Drawing.Image)(resources.GetObject("tsbZUpd.Image")));
            this.tsbZUpd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZUpd.Name = "tsbZUpd";
            this.tsbZUpd.Size = new System.Drawing.Size(34, 34);
            this.tsbZUpd.Text = "Actualizar Zona";
            this.tsbZUpd.ToolTipText = "Utilice este botón para actualizar los datos de una Zona";
            this.tsbZUpd.Click += new System.EventHandler(this.tsbZUpd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbZDel
            // 
            this.tsbZDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbZDel.Image")));
            this.tsbZDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZDel.Name = "tsbZDel";
            this.tsbZDel.Size = new System.Drawing.Size(34, 34);
            this.tsbZDel.Text = "Eliminar una Zona";
            this.tsbZDel.ToolTipText = "Utilice este botón para eliminar una Zona del Sistema ";
            this.tsbZDel.Click += new System.EventHandler(this.tsbZDel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbRollBackZona
            // 
            this.tsbRollBackZona.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRollBackZona.Image = ((System.Drawing.Image)(resources.GetObject("tsbRollBackZona.Image")));
            this.tsbRollBackZona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRollBackZona.Name = "tsbRollBackZona";
            this.tsbRollBackZona.Size = new System.Drawing.Size(34, 34);
            this.tsbRollBackZona.Text = "Limpar Campos";
            this.tsbRollBackZona.ToolTipText = "Utilice para Limpiar todos los campos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(34, 34);
            this.tsbCancelar.Text = "Cancela y limpia todos los campos para  volver a comenzar";
            this.tsbCancelar.ToolTipText = "Cancela las acciones y limpia todos los campos para  volver a comenzar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(34, 34);
            this.tsbSave.Text = "Guardar Cambios";
            this.tsbSave.ToolTipText = "Utilizar para confirmar los cambios y guardarlos en el Sistema";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 37);
            // 
            // tslServ
            // 
            this.tslServ.AutoToolTip = true;
            this.tslServ.Name = "tslServ";
            this.tslServ.Size = new System.Drawing.Size(212, 34);
            this.tslServ.Text = "Gestión de Servicios »»»»";
            this.tslServ.ToolTipText = "Utilice los siguientes botones para agregar o eliminar un Servicio";
            // 
            // tsbServADD
            // 
            this.tsbServADD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbServADD.Image = ((System.Drawing.Image)(resources.GetObject("tsbServADD.Image")));
            this.tsbServADD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServADD.Name = "tsbServADD";
            this.tsbServADD.Size = new System.Drawing.Size(34, 34);
            this.tsbServADD.Text = "Agregar Servicio a la Zona";
            this.tsbServADD.ToolTipText = "Agrega un Servicio a la Zona";
            this.tsbServADD.Click += new System.EventHandler(this.tsbServADD_Click);
            // 
            // tsbServDel
            // 
            this.tsbServDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbServDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbServDel.Image")));
            this.tsbServDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServDel.Name = "tsbServDel";
            this.tsbServDel.Size = new System.Drawing.Size(34, 34);
            this.tsbServDel.Text = "Eliminar un servicio ";
            this.tsbServDel.ToolTipText = "Selecione el servicio previo a la eliminación";
            this.tsbServDel.Click += new System.EventHandler(this.tsbServDel_Click);
            // 
            // tslZona
            // 
            this.tslZona.Name = "tslZona";
            this.tslZona.Size = new System.Drawing.Size(0, 34);
            // 
            // gbDatoZona
            // 
            this.gbDatoZona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDatoZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.gbDatoZona.Controls.Add(this.cmbDpto);
            this.gbDatoZona.Controls.Add(this.txtServ);
            this.gbDatoZona.Controls.Add(this.lblServ);
            this.gbDatoZona.Controls.Add(this.txtHab);
            this.gbDatoZona.Controls.Add(this.lblCantHab);
            this.gbDatoZona.Controls.Add(this.txtNomOficial);
            this.gbDatoZona.Controls.Add(this.lblNomOficial);
            this.gbDatoZona.Controls.Add(this.lbl3letras);
            this.gbDatoZona.Controls.Add(this.lblLetra);
            this.gbDatoZona.Controls.Add(this.txtAcron);
            this.gbDatoZona.Controls.Add(this.lblAcron);
            this.gbDatoZona.Controls.Add(this.lblDpto);
            this.gbDatoZona.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatoZona.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDatoZona.Location = new System.Drawing.Point(15, 102);
            this.gbDatoZona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatoZona.Name = "gbDatoZona";
            this.gbDatoZona.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatoZona.Size = new System.Drawing.Size(798, 569);
            this.gbDatoZona.TabIndex = 1;
            this.gbDatoZona.TabStop = false;
            this.gbDatoZona.Text = "Identificación de Zona";
            this.gbDatoZona.Enter += new System.EventHandler(this.gbDatoZona_Enter);
            // 
            // cmbDpto
            // 
            this.cmbDpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.cmbDpto.FormattingEnabled = true;
            this.cmbDpto.Items.AddRange(new object[] {
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
            this.cmbDpto.Location = new System.Drawing.Point(405, 71);
            this.cmbDpto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDpto.MaxLength = 1;
            this.cmbDpto.Name = "cmbDpto";
            this.cmbDpto.Size = new System.Drawing.Size(322, 36);
            this.cmbDpto.TabIndex = 0;
            this.cmbDpto.SelectedIndexChanged += new System.EventHandler(this.cmbDpto_SelectedIndexChanged);
            this.cmbDpto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDpto_KeyPress);
            this.cmbDpto.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDpto_Validating);
            this.cmbDpto.Validated += new System.EventHandler(this.cmbDpto_Validated);
            // 
            // txtServ
            // 
            this.txtServ.Location = new System.Drawing.Point(405, 491);
            this.txtServ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServ.Name = "txtServ";
            this.txtServ.Size = new System.Drawing.Size(322, 36);
            this.txtServ.TabIndex = 4;
            this.txtServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServ_KeyPress);
            // 
            // lblServ
            // 
            this.lblServ.AutoSize = true;
            this.lblServ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServ.Location = new System.Drawing.Point(21, 501);
            this.lblServ.Name = "lblServ";
            this.lblServ.Size = new System.Drawing.Size(363, 28);
            this.lblServ.TabIndex = 11;
            this.lblServ.Text = "Agregar o Eliminar Servicio";
            // 
            // txtHab
            // 
            this.txtHab.Location = new System.Drawing.Point(405, 381);
            this.txtHab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHab.Name = "txtHab";
            this.txtHab.Size = new System.Drawing.Size(322, 36);
            this.txtHab.TabIndex = 3;
            this.txtHab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHab_KeyPress);
            this.txtHab.Validated += new System.EventHandler(this.txtHab_Validated);
            // 
            // lblCantHab
            // 
            this.lblCantHab.AutoSize = true;
            this.lblCantHab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantHab.Location = new System.Drawing.Point(21, 392);
            this.lblCantHab.Name = "lblCantHab";
            this.lblCantHab.Size = new System.Drawing.Size(298, 28);
            this.lblCantHab.TabIndex = 9;
            this.lblCantHab.Text = "Cantidad de Habitantes";
            // 
            // txtNomOficial
            // 
            this.txtNomOficial.Location = new System.Drawing.Point(405, 281);
            this.txtNomOficial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomOficial.Name = "txtNomOficial";
            this.txtNomOficial.Size = new System.Drawing.Size(322, 36);
            this.txtNomOficial.TabIndex = 2;
            this.txtNomOficial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomOficial
            // 
            this.lblNomOficial.AutoSize = true;
            this.lblNomOficial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomOficial.Location = new System.Drawing.Point(21, 292);
            this.lblNomOficial.Name = "lblNomOficial";
            this.lblNomOficial.Size = new System.Drawing.Size(337, 28);
            this.lblNomOficial.TabIndex = 6;
            this.lblNomOficial.Text = "Nombre Oficial de la Zona";
            // 
            // lbl3letras
            // 
            this.lbl3letras.AutoSize = true;
            this.lbl3letras.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3letras.Location = new System.Drawing.Point(400, 209);
            this.lbl3letras.Name = "lbl3letras";
            this.lbl3letras.Size = new System.Drawing.Size(300, 22);
            this.lbl3letras.TabIndex = 5;
            this.lbl3letras.Text = "Se identifica con tres letras";
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetra.Location = new System.Drawing.Point(402, 114);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(0, 24);
            this.lblLetra.TabIndex = 4;
            // 
            // txtAcron
            // 
            this.txtAcron.Location = new System.Drawing.Point(405, 166);
            this.txtAcron.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAcron.Name = "txtAcron";
            this.txtAcron.Size = new System.Drawing.Size(322, 36);
            this.txtAcron.TabIndex = 1;
            this.txtAcron.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAcron.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcron_KeyPress);
            this.txtAcron.Validating += new System.ComponentModel.CancelEventHandler(this.txtAcron_Validating);
            this.txtAcron.Validated += new System.EventHandler(this.txtAcron_Validated);
            // 
            // lblAcron
            // 
            this.lblAcron.AutoSize = true;
            this.lblAcron.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcron.Location = new System.Drawing.Point(21, 178);
            this.lblAcron.Name = "lblAcron";
            this.lblAcron.Size = new System.Drawing.Size(285, 28);
            this.lblAcron.TabIndex = 2;
            this.lblAcron.Text = "Acrónimo para la Zona";
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDpto.Location = new System.Drawing.Point(21, 71);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(363, 28);
            this.lblDpto.TabIndex = 1;
            this.lblDpto.Text = "Identificador Departamento.";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AllowUserToOrderColumns = true;
            this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(6, 42);
            this.dgvServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.Size = new System.Drawing.Size(501, 519);
            this.dgvServicios.TabIndex = 0;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            // 
            // errorZ
            // 
            this.errorZ.ContainerControl = this;
            this.errorZ.Icon = ((System.Drawing.Icon)(resources.GetObject("errorZ.Icon")));
            // 
            // gbServ
            // 
            this.gbServ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.gbServ.Controls.Add(this.dgvServicios);
            this.gbServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbServ.Location = new System.Drawing.Point(819, 102);
            this.gbServ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbServ.Name = "gbServ";
            this.gbServ.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbServ.Size = new System.Drawing.Size(515, 569);
            this.gbServ.TabIndex = 3;
            this.gbServ.TabStop = false;
            this.gbServ.Text = "Servicios Asociados";
            // 
            // ssZona
            // 
            this.ssZona.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ssZona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslError});
            this.ssZona.Location = new System.Drawing.Point(0, 687);
            this.ssZona.Name = "ssZona";
            this.ssZona.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.ssZona.Size = new System.Drawing.Size(1351, 22);
            this.ssZona.TabIndex = 4;
            this.ssZona.Text = "statusStripZona";
            // 
            // tsslError
            // 
            this.tsslError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tsslError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslError.ForeColor = System.Drawing.Color.Crimson;
            this.tsslError.Name = "tsslError";
            this.tsslError.Size = new System.Drawing.Size(0, 17);
            // 
            // frmZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1351, 709);
            this.Controls.Add(this.ssZona);
            this.Controls.Add(this.gbServ);
            this.Controls.Add(this.gbDatoZona);
            this.Controls.Add(this.tstZona);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmZona";
            this.Text = "Sistema Gestión de Zonas";
            this.Load += new System.EventHandler(this.frmZona_Load);
            this.tstZona.ResumeLayout(false);
            this.tstZona.PerformLayout();
            this.gbDatoZona.ResumeLayout(false);
            this.gbDatoZona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorZ)).EndInit();
            this.gbServ.ResumeLayout(false);
            this.ssZona.ResumeLayout(false);
            this.ssZona.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstZona;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbZDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbZUpd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox gbDatoZona;
        private System.Windows.Forms.TextBox txtAcron;
        private System.Windows.Forms.Label lblAcron;
        private System.Windows.Forms.Label lblDpto;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.ErrorProvider errorZ;
        private System.Windows.Forms.GroupBox gbServ;
        private System.Windows.Forms.Label lbl3letras;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.TextBox txtHab;
        private System.Windows.Forms.Label lblCantHab;
        private System.Windows.Forms.TextBox txtNomOficial;
        private System.Windows.Forms.Label lblNomOficial;
        private System.Windows.Forms.ToolStripButton tsbRollBackZona;
        private System.Windows.Forms.StatusStrip ssZona;
        private System.Windows.Forms.ToolStripStatusLabel tsslError;
        private System.Windows.Forms.ToolStripLabel tslServ;
        private System.Windows.Forms.ToolStripButton tsbServADD;
        private System.Windows.Forms.ToolStripButton tsbServDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel tslZona;
        private System.Windows.Forms.TextBox txtServ;
        private System.Windows.Forms.Label lblServ;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbAddZona;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ComboBox cmbDpto;
       
    }
}