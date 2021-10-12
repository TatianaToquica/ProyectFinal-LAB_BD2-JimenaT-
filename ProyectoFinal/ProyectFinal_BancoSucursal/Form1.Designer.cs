
namespace ProyectFinal_BancoSucursal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.tbpRegistrarBanco = new System.Windows.Forms.TabPage();
            this.btnRegistrarBanco = new System.Windows.Forms.Button();
            this.calFechaBanco = new System.Windows.Forms.MonthCalendar();
            this.txtNomBanco = new System.Windows.Forms.TextBox();
            this.txtNitBanco = new System.Windows.Forms.TextBox();
            this.lbFcreacionBanco = new System.Windows.Forms.Label();
            this.lbNomBanco = new System.Windows.Forms.Label();
            this.lbNitBanco = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbpRegistrarSucursal = new System.Windows.Forms.TabPage();
            this.btnRegistrarSucursal = new System.Windows.Forms.Button();
            this.txtNitBancoSucursal = new System.Windows.Forms.TextBox();
            this.txtAniosSucursal = new System.Windows.Forms.TextBox();
            this.cbxUbicSucursal = new System.Windows.Forms.ComboBox();
            this.txtNempSucursal = new System.Windows.Forms.TextBox();
            this.txtNomSucursal = new System.Windows.Forms.TextBox();
            this.txtCodSucursal = new System.Windows.Forms.TextBox();
            this.lbNitBancSucursal = new System.Windows.Forms.Label();
            this.lbAniosSucursal = new System.Windows.Forms.Label();
            this.lbNempSucursal = new System.Windows.Forms.Label();
            this.lbUbicSucursal = new System.Windows.Forms.Label();
            this.lbNomSucursal = new System.Windows.Forms.Label();
            this.lbCodSucursal = new System.Windows.Forms.Label();
            this.lbTituloSucursal = new System.Windows.Forms.Label();
            this.tbpConsultarSucursal = new System.Windows.Forms.TabPage();
            this.txtNitBancoConsultS = new System.Windows.Forms.TextBox();
            this.lbPedirNitBanco = new System.Windows.Forms.Label();
            this.tbpEliminarSucursal = new System.Windows.Forms.TabPage();
            this.btnEliminarSucursal = new System.Windows.Forms.Button();
            this.txtCodSucursalElim = new System.Windows.Forms.TextBox();
            this.lbPedirCodSucursal = new System.Windows.Forms.Label();
            this.btnConsultarSucursales = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tbcGestion.SuspendLayout();
            this.tbpRegistrarBanco.SuspendLayout();
            this.tbpRegistrarSucursal.SuspendLayout();
            this.tbpConsultarSucursal.SuspendLayout();
            this.tbpEliminarSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tbpRegistrarBanco);
            this.tbcGestion.Controls.Add(this.tbpRegistrarSucursal);
            this.tbcGestion.Controls.Add(this.tbpConsultarSucursal);
            this.tbcGestion.Controls.Add(this.tbpEliminarSucursal);
            this.tbcGestion.Location = new System.Drawing.Point(39, 35);
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(619, 376);
            this.tbcGestion.TabIndex = 0;
            // 
            // tbpRegistrarBanco
            // 
            this.tbpRegistrarBanco.Controls.Add(this.btnRegistrarBanco);
            this.tbpRegistrarBanco.Controls.Add(this.calFechaBanco);
            this.tbpRegistrarBanco.Controls.Add(this.txtNomBanco);
            this.tbpRegistrarBanco.Controls.Add(this.txtNitBanco);
            this.tbpRegistrarBanco.Controls.Add(this.lbFcreacionBanco);
            this.tbpRegistrarBanco.Controls.Add(this.lbNomBanco);
            this.tbpRegistrarBanco.Controls.Add(this.lbNitBanco);
            this.tbpRegistrarBanco.Controls.Add(this.lbTitulo);
            this.tbpRegistrarBanco.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrarBanco.Name = "tbpRegistrarBanco";
            this.tbpRegistrarBanco.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarBanco.Size = new System.Drawing.Size(611, 350);
            this.tbpRegistrarBanco.TabIndex = 0;
            this.tbpRegistrarBanco.Text = "Registrar Banco";
            this.tbpRegistrarBanco.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarBanco
            // 
            this.btnRegistrarBanco.Location = new System.Drawing.Point(491, 314);
            this.btnRegistrarBanco.Name = "btnRegistrarBanco";
            this.btnRegistrarBanco.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarBanco.TabIndex = 7;
            this.btnRegistrarBanco.Text = "Registrar";
            this.btnRegistrarBanco.UseVisualStyleBackColor = true;
            this.btnRegistrarBanco.Click += new System.EventHandler(this.btnRegistrarBanco_Click);
            // 
            // calFechaBanco
            // 
            this.calFechaBanco.Location = new System.Drawing.Point(156, 152);
            this.calFechaBanco.Name = "calFechaBanco";
            this.calFechaBanco.TabIndex = 6;
            // 
            // txtNomBanco
            // 
            this.txtNomBanco.Location = new System.Drawing.Point(156, 104);
            this.txtNomBanco.Name = "txtNomBanco";
            this.txtNomBanco.Size = new System.Drawing.Size(100, 20);
            this.txtNomBanco.TabIndex = 5;
            // 
            // txtNitBanco
            // 
            this.txtNitBanco.Location = new System.Drawing.Point(156, 75);
            this.txtNitBanco.Name = "txtNitBanco";
            this.txtNitBanco.Size = new System.Drawing.Size(100, 20);
            this.txtNitBanco.TabIndex = 4;
            // 
            // lbFcreacionBanco
            // 
            this.lbFcreacionBanco.AutoSize = true;
            this.lbFcreacionBanco.Location = new System.Drawing.Point(27, 152);
            this.lbFcreacionBanco.Name = "lbFcreacionBanco";
            this.lbFcreacionBanco.Size = new System.Drawing.Size(88, 13);
            this.lbFcreacionBanco.TabIndex = 3;
            this.lbFcreacionBanco.Text = "Fecha Creación :";
            // 
            // lbNomBanco
            // 
            this.lbNomBanco.AutoSize = true;
            this.lbNomBanco.Location = new System.Drawing.Point(27, 112);
            this.lbNomBanco.Name = "lbNomBanco";
            this.lbNomBanco.Size = new System.Drawing.Size(50, 13);
            this.lbNomBanco.TabIndex = 2;
            this.lbNomBanco.Text = "Nombre :";
            // 
            // lbNitBanco
            // 
            this.lbNitBanco.AutoSize = true;
            this.lbNitBanco.Location = new System.Drawing.Point(24, 75);
            this.lbNitBanco.Name = "lbNitBanco";
            this.lbNitBanco.Size = new System.Drawing.Size(26, 13);
            this.lbNitBanco.TabIndex = 1;
            this.lbNitBanco.Text = "Nit :";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(106, 33);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(184, 13);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Ingrese la información sobre el Banco";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitulo.UseMnemonic = false;
            // 
            // tbpRegistrarSucursal
            // 
            this.tbpRegistrarSucursal.Controls.Add(this.btnRegistrarSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.txtNitBancoSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.txtAniosSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.cbxUbicSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.txtNempSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.txtNomSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.txtCodSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.lbNitBancSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.lbAniosSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.lbNempSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.lbUbicSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.lbNomSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.lbCodSucursal);
            this.tbpRegistrarSucursal.Controls.Add(this.lbTituloSucursal);
            this.tbpRegistrarSucursal.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrarSucursal.Name = "tbpRegistrarSucursal";
            this.tbpRegistrarSucursal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarSucursal.Size = new System.Drawing.Size(611, 350);
            this.tbpRegistrarSucursal.TabIndex = 1;
            this.tbpRegistrarSucursal.Text = "Registrar Sucursal";
            this.tbpRegistrarSucursal.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarSucursal
            // 
            this.btnRegistrarSucursal.Location = new System.Drawing.Point(467, 316);
            this.btnRegistrarSucursal.Name = "btnRegistrarSucursal";
            this.btnRegistrarSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarSucursal.TabIndex = 13;
            this.btnRegistrarSucursal.Text = "Registrar";
            this.btnRegistrarSucursal.UseVisualStyleBackColor = true;
            this.btnRegistrarSucursal.Click += new System.EventHandler(this.btnRegistrarSucursal_Click);
            // 
            // txtNitBancoSucursal
            // 
            this.txtNitBancoSucursal.Location = new System.Drawing.Point(260, 225);
            this.txtNitBancoSucursal.Name = "txtNitBancoSucursal";
            this.txtNitBancoSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtNitBancoSucursal.TabIndex = 12;
            // 
            // txtAniosSucursal
            // 
            this.txtAniosSucursal.Location = new System.Drawing.Point(260, 196);
            this.txtAniosSucursal.Name = "txtAniosSucursal";
            this.txtAniosSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtAniosSucursal.TabIndex = 11;
            // 
            // cbxUbicSucursal
            // 
            this.cbxUbicSucursal.FormattingEnabled = true;
            this.cbxUbicSucursal.Items.AddRange(new object[] {
            "norte",
            "sur",
            "centro"});
            this.cbxUbicSucursal.Location = new System.Drawing.Point(260, 129);
            this.cbxUbicSucursal.Name = "cbxUbicSucursal";
            this.cbxUbicSucursal.Size = new System.Drawing.Size(121, 21);
            this.cbxUbicSucursal.TabIndex = 10;
            // 
            // txtNempSucursal
            // 
            this.txtNempSucursal.Location = new System.Drawing.Point(260, 165);
            this.txtNempSucursal.Name = "txtNempSucursal";
            this.txtNempSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtNempSucursal.TabIndex = 9;
            // 
            // txtNomSucursal
            // 
            this.txtNomSucursal.Location = new System.Drawing.Point(260, 97);
            this.txtNomSucursal.Name = "txtNomSucursal";
            this.txtNomSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtNomSucursal.TabIndex = 8;
            // 
            // txtCodSucursal
            // 
            this.txtCodSucursal.Location = new System.Drawing.Point(260, 68);
            this.txtCodSucursal.Name = "txtCodSucursal";
            this.txtCodSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtCodSucursal.TabIndex = 7;
            // 
            // lbNitBancSucursal
            // 
            this.lbNitBancSucursal.AutoSize = true;
            this.lbNitBancSucursal.Location = new System.Drawing.Point(110, 225);
            this.lbNitBancSucursal.Name = "lbNitBancSucursal";
            this.lbNitBancSucursal.Size = new System.Drawing.Size(59, 13);
            this.lbNitBancSucursal.TabIndex = 6;
            this.lbNitBancSucursal.Text = "Nit banco :";
            // 
            // lbAniosSucursal
            // 
            this.lbAniosSucursal.AutoSize = true;
            this.lbAniosSucursal.Location = new System.Drawing.Point(110, 196);
            this.lbAniosSucursal.Name = "lbAniosSucursal";
            this.lbAniosSucursal.Size = new System.Drawing.Size(108, 13);
            this.lbAniosSucursal.TabIndex = 5;
            this.lbAniosSucursal.Text = "Años de antiguedad :";
            // 
            // lbNempSucursal
            // 
            this.lbNempSucursal.AutoSize = true;
            this.lbNempSucursal.Location = new System.Drawing.Point(110, 168);
            this.lbNempSucursal.Name = "lbNempSucursal";
            this.lbNempSucursal.Size = new System.Drawing.Size(119, 13);
            this.lbNempSucursal.TabIndex = 4;
            this.lbNempSucursal.Text = "Número de empleados :";
            // 
            // lbUbicSucursal
            // 
            this.lbUbicSucursal.AutoSize = true;
            this.lbUbicSucursal.Location = new System.Drawing.Point(110, 138);
            this.lbUbicSucursal.Name = "lbUbicSucursal";
            this.lbUbicSucursal.Size = new System.Drawing.Size(61, 13);
            this.lbUbicSucursal.TabIndex = 3;
            this.lbUbicSucursal.Text = "Ubicación :";
            // 
            // lbNomSucursal
            // 
            this.lbNomSucursal.AutoSize = true;
            this.lbNomSucursal.Location = new System.Drawing.Point(110, 97);
            this.lbNomSucursal.Name = "lbNomSucursal";
            this.lbNomSucursal.Size = new System.Drawing.Size(50, 13);
            this.lbNomSucursal.TabIndex = 2;
            this.lbNomSucursal.Text = "Nombre :";
            // 
            // lbCodSucursal
            // 
            this.lbCodSucursal.AutoSize = true;
            this.lbCodSucursal.Location = new System.Drawing.Point(110, 68);
            this.lbCodSucursal.Name = "lbCodSucursal";
            this.lbCodSucursal.Size = new System.Drawing.Size(46, 13);
            this.lbCodSucursal.TabIndex = 1;
            this.lbCodSucursal.Text = "Código :";
            // 
            // lbTituloSucursal
            // 
            this.lbTituloSucursal.AutoSize = true;
            this.lbTituloSucursal.Location = new System.Drawing.Point(137, 24);
            this.lbTituloSucursal.Name = "lbTituloSucursal";
            this.lbTituloSucursal.Size = new System.Drawing.Size(194, 13);
            this.lbTituloSucursal.TabIndex = 0;
            this.lbTituloSucursal.Text = "Ingrese la información sobre la Sucursal";
            // 
            // tbpConsultarSucursal
            // 
            this.tbpConsultarSucursal.Controls.Add(this.dgvDatos);
            this.tbpConsultarSucursal.Controls.Add(this.btnConsultarSucursales);
            this.tbpConsultarSucursal.Controls.Add(this.txtNitBancoConsultS);
            this.tbpConsultarSucursal.Controls.Add(this.lbPedirNitBanco);
            this.tbpConsultarSucursal.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultarSucursal.Name = "tbpConsultarSucursal";
            this.tbpConsultarSucursal.Size = new System.Drawing.Size(611, 350);
            this.tbpConsultarSucursal.TabIndex = 2;
            this.tbpConsultarSucursal.Text = "Consultar Sucursal";
            this.tbpConsultarSucursal.UseVisualStyleBackColor = true;
            // 
            // txtNitBancoConsultS
            // 
            this.txtNitBancoConsultS.Location = new System.Drawing.Point(212, 45);
            this.txtNitBancoConsultS.Name = "txtNitBancoConsultS";
            this.txtNitBancoConsultS.Size = new System.Drawing.Size(100, 20);
            this.txtNitBancoConsultS.TabIndex = 1;
            // 
            // lbPedirNitBanco
            // 
            this.lbPedirNitBanco.AutoSize = true;
            this.lbPedirNitBanco.Location = new System.Drawing.Point(85, 45);
            this.lbPedirNitBanco.Name = "lbPedirNitBanco";
            this.lbPedirNitBanco.Size = new System.Drawing.Size(123, 13);
            this.lbPedirNitBanco.TabIndex = 0;
            this.lbPedirNitBanco.Text = "Ingrese el nit del banco :";
            // 
            // tbpEliminarSucursal
            // 
            this.tbpEliminarSucursal.Controls.Add(this.btnEliminarSucursal);
            this.tbpEliminarSucursal.Controls.Add(this.txtCodSucursalElim);
            this.tbpEliminarSucursal.Controls.Add(this.lbPedirCodSucursal);
            this.tbpEliminarSucursal.Location = new System.Drawing.Point(4, 22);
            this.tbpEliminarSucursal.Name = "tbpEliminarSucursal";
            this.tbpEliminarSucursal.Size = new System.Drawing.Size(611, 350);
            this.tbpEliminarSucursal.TabIndex = 3;
            this.tbpEliminarSucursal.Text = "Eliminar Sucursal";
            this.tbpEliminarSucursal.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSucursal
            // 
            this.btnEliminarSucursal.Location = new System.Drawing.Point(179, 124);
            this.btnEliminarSucursal.Name = "btnEliminarSucursal";
            this.btnEliminarSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSucursal.TabIndex = 2;
            this.btnEliminarSucursal.Text = "Eliminar";
            this.btnEliminarSucursal.UseVisualStyleBackColor = true;
            this.btnEliminarSucursal.Click += new System.EventHandler(this.btnEliminarSucursal_Click);
            // 
            // txtCodSucursalElim
            // 
            this.txtCodSucursalElim.Location = new System.Drawing.Point(220, 53);
            this.txtCodSucursalElim.Name = "txtCodSucursalElim";
            this.txtCodSucursalElim.Size = new System.Drawing.Size(100, 20);
            this.txtCodSucursalElim.TabIndex = 1;
            // 
            // lbPedirCodSucursal
            // 
            this.lbPedirCodSucursal.AutoSize = true;
            this.lbPedirCodSucursal.Location = new System.Drawing.Point(51, 53);
            this.lbPedirCodSucursal.Name = "lbPedirCodSucursal";
            this.lbPedirCodSucursal.Size = new System.Drawing.Size(162, 13);
            this.lbPedirCodSucursal.TabIndex = 0;
            this.lbPedirCodSucursal.Text = "Ingrese el código de la sucursal :";
            // 
            // btnConsultarSucursales
            // 
            this.btnConsultarSucursales.Location = new System.Drawing.Point(337, 45);
            this.btnConsultarSucursales.Name = "btnConsultarSucursales";
            this.btnConsultarSucursales.Size = new System.Drawing.Size(127, 23);
            this.btnConsultarSucursales.TabIndex = 2;
            this.btnConsultarSucursales.Text = "Consultar Sucursales";
            this.btnConsultarSucursales.UseVisualStyleBackColor = true;
            this.btnConsultarSucursales.Click += new System.EventHandler(this.btnConsultarSucursales_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(43, 124);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(511, 150);
            this.dgvDatos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.tbcGestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcGestion.ResumeLayout(false);
            this.tbpRegistrarBanco.ResumeLayout(false);
            this.tbpRegistrarBanco.PerformLayout();
            this.tbpRegistrarSucursal.ResumeLayout(false);
            this.tbpRegistrarSucursal.PerformLayout();
            this.tbpConsultarSucursal.ResumeLayout(false);
            this.tbpConsultarSucursal.PerformLayout();
            this.tbpEliminarSucursal.ResumeLayout(false);
            this.tbpEliminarSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestion;
        private System.Windows.Forms.TabPage tbpRegistrarBanco;
        private System.Windows.Forms.TabPage tbpRegistrarSucursal;
        private System.Windows.Forms.TabPage tbpConsultarSucursal;
        private System.Windows.Forms.TabPage tbpEliminarSucursal;
        private System.Windows.Forms.Button btnRegistrarBanco;
        private System.Windows.Forms.MonthCalendar calFechaBanco;
        private System.Windows.Forms.TextBox txtNomBanco;
        private System.Windows.Forms.TextBox txtNitBanco;
        private System.Windows.Forms.Label lbFcreacionBanco;
        private System.Windows.Forms.Label lbNomBanco;
        private System.Windows.Forms.Label lbNitBanco;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnRegistrarSucursal;
        private System.Windows.Forms.TextBox txtNitBancoSucursal;
        private System.Windows.Forms.TextBox txtAniosSucursal;
        private System.Windows.Forms.ComboBox cbxUbicSucursal;
        private System.Windows.Forms.TextBox txtNempSucursal;
        private System.Windows.Forms.TextBox txtNomSucursal;
        private System.Windows.Forms.TextBox txtCodSucursal;
        private System.Windows.Forms.Label lbNitBancSucursal;
        private System.Windows.Forms.Label lbAniosSucursal;
        private System.Windows.Forms.Label lbNempSucursal;
        private System.Windows.Forms.Label lbUbicSucursal;
        private System.Windows.Forms.Label lbNomSucursal;
        private System.Windows.Forms.Label lbCodSucursal;
        private System.Windows.Forms.Label lbTituloSucursal;
        private System.Windows.Forms.TextBox txtCodSucursalElim;
        private System.Windows.Forms.Label lbPedirCodSucursal;
        private System.Windows.Forms.TextBox txtNitBancoConsultS;
        private System.Windows.Forms.Label lbPedirNitBanco;
        private System.Windows.Forms.Button btnEliminarSucursal;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnConsultarSucursales;
    }
}

