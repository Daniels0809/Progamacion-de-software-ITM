namespace appPractica1
{
    partial class frmUniversidad
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
            this.titulo = new System.Windows.Forms.Label();
            this.cmbTipoEst = new System.Windows.Forms.ComboBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.gpbRpta = new System.Windows.Forms.GroupBox();
            this.titVrPagar = new System.Windows.Forms.Label();
            this.titVrDscto = new System.Windows.Forms.Label();
            this.titDscto = new System.Windows.Forms.Label();
            this.titVrCred = new System.Windows.Forms.Label();
            this.titNroCred = new System.Windows.Forms.Label();
            this.txtVrCred = new System.Windows.Forms.TextBox();
            this.txtVrDscto = new System.Windows.Forms.TextBox();
            this.txtVrPagar = new System.Windows.Forms.TextBox();
            this.txtPorcDscto = new System.Windows.Forms.TextBox();
            this.txtNroCred = new System.Windows.Forms.TextBox();
            this.txtMsj = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.titTipoEst = new System.Windows.Forms.Label();
            this.titCarne = new System.Windows.Forms.Label();
            this.titNombre = new System.Windows.Forms.Label();
            this.titPromedio = new System.Windows.Forms.Label();
            this.gpbRpta.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(161, 21);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(147, 16);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "REGLAS DE NEGOCIO";
            // 
            // cmbTipoEst
            // 
            this.cmbTipoEst.FormattingEnabled = true;
            this.cmbTipoEst.Location = new System.Drawing.Point(294, 58);
            this.cmbTipoEst.Name = "cmbTipoEst";
            this.cmbTipoEst.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoEst.TabIndex = 1;
            // 
            // txtCarne
            // 
            this.txtCarne.Location = new System.Drawing.Point(294, 99);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(100, 22);
            this.txtCarne.TabIndex = 2;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(294, 155);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 22);
            this.txtPromedio.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(266, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(101, 208);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(319, 208);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            // 
            // gpbRpta
            // 
            this.gpbRpta.Controls.Add(this.titVrPagar);
            this.gpbRpta.Controls.Add(this.titVrDscto);
            this.gpbRpta.Controls.Add(this.titDscto);
            this.gpbRpta.Controls.Add(this.titVrCred);
            this.gpbRpta.Controls.Add(this.titNroCred);
            this.gpbRpta.Controls.Add(this.txtVrCred);
            this.gpbRpta.Controls.Add(this.txtVrDscto);
            this.gpbRpta.Controls.Add(this.txtVrPagar);
            this.gpbRpta.Controls.Add(this.txtPorcDscto);
            this.gpbRpta.Controls.Add(this.txtNroCred);
            this.gpbRpta.Location = new System.Drawing.Point(12, 277);
            this.gpbRpta.Name = "gpbRpta";
            this.gpbRpta.Size = new System.Drawing.Size(462, 100);
            this.gpbRpta.TabIndex = 7;
            this.gpbRpta.TabStop = false;
            this.gpbRpta.Visible = false;
            // 
            // titVrPagar
            // 
            this.titVrPagar.AutoSize = true;
            this.titVrPagar.Location = new System.Drawing.Point(264, 73);
            this.titVrPagar.Name = "titVrPagar";
            this.titVrPagar.Size = new System.Drawing.Size(77, 16);
            this.titVrPagar.TabIndex = 19;
            this.titVrPagar.Text = "Vr. a Pagar:";
            // 
            // titVrDscto
            // 
            this.titVrDscto.AutoSize = true;
            this.titVrDscto.Location = new System.Drawing.Point(264, 42);
            this.titVrDscto.Name = "titVrDscto";
            this.titVrDscto.Size = new System.Drawing.Size(64, 16);
            this.titVrDscto.TabIndex = 18;
            this.titVrDscto.Text = "Vr. Dscto:";
            // 
            // titDscto
            // 
            this.titDscto.AutoSize = true;
            this.titDscto.Location = new System.Drawing.Point(25, 45);
            this.titDscto.Name = "titDscto";
            this.titDscto.Size = new System.Drawing.Size(60, 16);
            this.titDscto.TabIndex = 17;
            this.titDscto.Text = "% Dscto:";
            // 
            // titVrCred
            // 
            this.titVrCred.AutoSize = true;
            this.titVrCred.Location = new System.Drawing.Point(264, 18);
            this.titVrCred.Name = "titVrCred";
            this.titVrCred.Size = new System.Drawing.Size(72, 16);
            this.titVrCred.TabIndex = 16;
            this.titVrCred.Text = "Vr. Crédito:";
            // 
            // titNroCred
            // 
            this.titNroCred.AutoSize = true;
            this.titNroCred.Location = new System.Drawing.Point(25, 18);
            this.titNroCred.Name = "titNroCred";
            this.titNroCred.Size = new System.Drawing.Size(88, 16);
            this.titNroCred.TabIndex = 15;
            this.titNroCred.Text = "Nro. Créditos:";
            // 
            // txtVrCred
            // 
            this.txtVrCred.Location = new System.Drawing.Point(324, 11);
            this.txtVrCred.Name = "txtVrCred";
            this.txtVrCred.ReadOnly = true;
            this.txtVrCred.Size = new System.Drawing.Size(100, 22);
            this.txtVrCred.TabIndex = 9;
            // 
            // txtVrDscto
            // 
            this.txtVrDscto.Location = new System.Drawing.Point(324, 39);
            this.txtVrDscto.Name = "txtVrDscto";
            this.txtVrDscto.ReadOnly = true;
            this.txtVrDscto.Size = new System.Drawing.Size(100, 22);
            this.txtVrDscto.TabIndex = 10;
            // 
            // txtVrPagar
            // 
            this.txtVrPagar.Location = new System.Drawing.Point(324, 67);
            this.txtVrPagar.Name = "txtVrPagar";
            this.txtVrPagar.ReadOnly = true;
            this.txtVrPagar.Size = new System.Drawing.Size(100, 22);
            this.txtVrPagar.TabIndex = 11;
            // 
            // txtPorcDscto
            // 
            this.txtPorcDscto.Location = new System.Drawing.Point(114, 39);
            this.txtPorcDscto.Name = "txtPorcDscto";
            this.txtPorcDscto.ReadOnly = true;
            this.txtPorcDscto.Size = new System.Drawing.Size(100, 22);
            this.txtPorcDscto.TabIndex = 12;
            // 
            // txtNroCred
            // 
            this.txtNroCred.Location = new System.Drawing.Point(114, 11);
            this.txtNroCred.Name = "txtNroCred";
            this.txtNroCred.ReadOnly = true;
            this.txtNroCred.Size = new System.Drawing.Size(100, 22);
            this.txtNroCred.TabIndex = 8;
            // 
            // txtMsj
            // 
            this.txtMsj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsj.Location = new System.Drawing.Point(29, 425);
            this.txtMsj.Multiline = true;
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsj.Size = new System.Drawing.Size(445, 22);
            this.txtMsj.TabIndex = 9;
            this.txtMsj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(361, 501);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 10;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            // 
            // titTipoEst
            // 
            this.titTipoEst.AutoSize = true;
            this.titTipoEst.Location = new System.Drawing.Point(123, 61);
            this.titTipoEst.Name = "titTipoEst";
            this.titTipoEst.Size = new System.Drawing.Size(123, 16);
            this.titTipoEst.TabIndex = 11;
            this.titTipoEst.Text = "Tipo de Estudiante:";
            // 
            // titCarne
            // 
            this.titCarne.AutoSize = true;
            this.titCarne.Location = new System.Drawing.Point(123, 102);
            this.titCarne.Name = "titCarne";
            this.titCarne.Size = new System.Drawing.Size(46, 16);
            this.titCarne.TabIndex = 12;
            this.titCarne.Text = "Carné:";
            // 
            // titNombre
            // 
            this.titNombre.AutoSize = true;
            this.titNombre.Location = new System.Drawing.Point(123, 133);
            this.titNombre.Name = "titNombre";
            this.titNombre.Size = new System.Drawing.Size(59, 16);
            this.titNombre.TabIndex = 13;
            this.titNombre.Text = "Nombre:";
            // 
            // titPromedio
            // 
            this.titPromedio.AutoSize = true;
            this.titPromedio.Location = new System.Drawing.Point(123, 161);
            this.titPromedio.Name = "titPromedio";
            this.titPromedio.Size = new System.Drawing.Size(69, 16);
            this.titPromedio.TabIndex = 14;
            this.titPromedio.Text = "Promedio:";
            // 
            // frmUniversidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 599);
            this.Controls.Add(this.titPromedio);
            this.Controls.Add(this.titNombre);
            this.Controls.Add(this.titCarne);
            this.Controls.Add(this.titTipoEst);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.txtMsj);
            this.Controls.Add(this.gpbRpta);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.cmbTipoEst);
            this.Controls.Add(this.titulo);
            this.Name = "frmUniversidad";
            this.Text = "Práctica # 1 - Reglas de Negocio";
            this.Load += new System.EventHandler(this.frmUniversidad_Load);
            this.gpbRpta.ResumeLayout(false);
            this.gpbRpta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ComboBox cmbTipoEst;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox gpbRpta;
        private System.Windows.Forms.TextBox txtVrCred;
        private System.Windows.Forms.TextBox txtVrDscto;
        private System.Windows.Forms.TextBox txtVrPagar;
        private System.Windows.Forms.TextBox txtPorcDscto;
        private System.Windows.Forms.TextBox txtNroCred;
        private System.Windows.Forms.TextBox txtMsj;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label titTipoEst;
        private System.Windows.Forms.Label titVrPagar;
        private System.Windows.Forms.Label titVrDscto;
        private System.Windows.Forms.Label titDscto;
        private System.Windows.Forms.Label titVrCred;
        private System.Windows.Forms.Label titNroCred;
        private System.Windows.Forms.Label titCarne;
        private System.Windows.Forms.Label titNombre;
        private System.Windows.Forms.Label titPromedio;
    }
}

