namespace Interprete1
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
            this.txtSoftware = new System.Windows.Forms.TextBox();
            this.lstVTabla = new System.Windows.Forms.ListView();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtErrores = new System.Windows.Forms.TextBox();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TIPO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSoftware = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.lblLstVTabla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoftware
            // 
            this.txtSoftware.Location = new System.Drawing.Point(12, 41);
            this.txtSoftware.Multiline = true;
            this.txtSoftware.Name = "txtSoftware";
            this.txtSoftware.Size = new System.Drawing.Size(503, 245);
            this.txtSoftware.TabIndex = 0;
            this.txtSoftware.Text = "Software";
            // 
            // lstVTabla
            // 
            this.lstVTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TIPO,
            this.Valor});
            this.lstVTabla.HideSelection = false;
            this.lstVTabla.Location = new System.Drawing.Point(521, 41);
            this.lstVTabla.Name = "lstVTabla";
            this.lstVTabla.Size = new System.Drawing.Size(301, 245);
            this.lstVTabla.TabIndex = 2;
            this.lstVTabla.UseCompatibleStateImageBehavior = false;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(440, 12);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 3;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(12, 341);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.Size = new System.Drawing.Size(503, 158);
            this.txtSalida.TabIndex = 4;
            this.txtSalida.Text = "Salida";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(747, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtErrores
            // 
            this.txtErrores.Location = new System.Drawing.Point(521, 341);
            this.txtErrores.Multiline = true;
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.ReadOnly = true;
            this.txtErrores.Size = new System.Drawing.Size(301, 158);
            this.txtErrores.TabIndex = 6;
            this.txtErrores.Text = "Errores";
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Location = new System.Drawing.Point(12, 22);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(49, 13);
            this.lblSoftware.TabIndex = 7;
            this.lblSoftware.Text = "Software";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(12, 325);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(36, 13);
            this.lblSalida.TabIndex = 8;
            this.lblSalida.Text = "Salida";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(524, 325);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(40, 13);
            this.lblErrores.TabIndex = 9;
            this.lblErrores.Text = "Errores";
            // 
            // lblLstVTabla
            // 
            this.lblLstVTabla.AutoSize = true;
            this.lblLstVTabla.Location = new System.Drawing.Point(524, 22);
            this.lblLstVTabla.Name = "lblLstVTabla";
            this.lblLstVTabla.Size = new System.Drawing.Size(96, 13);
            this.lblLstVTabla.TabIndex = 10;
            this.lblLstVTabla.Text = "Tabla de Símbolos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.lblLstVTabla);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblSoftware);
            this.Controls.Add(this.txtErrores);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.lstVTabla);
            this.Controls.Add(this.txtSoftware);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoftware;
        private System.Windows.Forms.ListView lstVTabla;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtErrores;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TIPO;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label lblLstVTabla;
    }
}

