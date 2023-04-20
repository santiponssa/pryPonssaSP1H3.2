namespace pryPonssaSP1H3._2
{
    partial class frmCadenas
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
            this.lblTextoA = new System.Windows.Forms.Label();
            this.lblTextoB = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtTextoA = new System.Windows.Forms.TextBox();
            this.txtTextoB = new System.Windows.Forms.TextBox();
            this.lstFecha = new System.Windows.Forms.ComboBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.mrcResultado = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblCantidadA = new System.Windows.Forms.Label();
            this.lblCantidadB = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.mrcResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTextoA
            // 
            this.lblTextoA.AutoSize = true;
            this.lblTextoA.Location = new System.Drawing.Point(42, 34);
            this.lblTextoA.Name = "lblTextoA";
            this.lblTextoA.Size = new System.Drawing.Size(44, 13);
            this.lblTextoA.TabIndex = 0;
            this.lblTextoA.Text = "Texto A";
            // 
            // lblTextoB
            // 
            this.lblTextoB.AutoSize = true;
            this.lblTextoB.Location = new System.Drawing.Point(42, 72);
            this.lblTextoB.Name = "lblTextoB";
            this.lblTextoB.Size = new System.Drawing.Size(44, 13);
            this.lblTextoB.TabIndex = 1;
            this.lblTextoB.Text = "Texto B";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(42, 114);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // txtTextoA
            // 
            this.txtTextoA.Location = new System.Drawing.Point(92, 31);
            this.txtTextoA.Name = "txtTextoA";
            this.txtTextoA.Size = new System.Drawing.Size(100, 20);
            this.txtTextoA.TabIndex = 3;
            this.txtTextoA.TextChanged += new System.EventHandler(this.txtTextoA_TextChanged);
            // 
            // txtTextoB
            // 
            this.txtTextoB.Location = new System.Drawing.Point(92, 69);
            this.txtTextoB.Name = "txtTextoB";
            this.txtTextoB.Size = new System.Drawing.Size(100, 20);
            this.txtTextoB.TabIndex = 4;
            this.txtTextoB.TextChanged += new System.EventHandler(this.txtTextoB_TextChanged);
            // 
            // lstFecha
            // 
            this.lstFecha.FormattingEnabled = true;
            this.lstFecha.Location = new System.Drawing.Point(92, 111);
            this.lstFecha.Name = "lstFecha";
            this.lstFecha.Size = new System.Drawing.Size(100, 21);
            this.lstFecha.TabIndex = 5;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(74, 153);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 6;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(74, 194);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // mrcResultado
            // 
            this.mrcResultado.Controls.Add(this.txtResultado);
            this.mrcResultado.Location = new System.Drawing.Point(42, 232);
            this.mrcResultado.Name = "mrcResultado";
            this.mrcResultado.Size = new System.Drawing.Size(150, 58);
            this.mrcResultado.TabIndex = 8;
            this.mrcResultado.TabStop = false;
            this.mrcResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(20, 19);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 0;
            // 
            // lblCantidadA
            // 
            this.lblCantidadA.AutoSize = true;
            this.lblCantidadA.Location = new System.Drawing.Point(204, 36);
            this.lblCantidadA.Name = "lblCantidadA";
            this.lblCantidadA.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadA.TabIndex = 9;
            // 
            // lblCantidadB
            // 
            this.lblCantidadB.AutoSize = true;
            this.lblCantidadB.Location = new System.Drawing.Point(203, 72);
            this.lblCantidadB.Name = "lblCantidadB";
            this.lblCantidadB.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadB.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(174, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(174, 194);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(75, 23);
            this.btnReemplazar.TabIndex = 12;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            // 
            // frmCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 307);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCantidadB);
            this.Controls.Add(this.lblCantidadA);
            this.Controls.Add(this.mrcResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.lstFecha);
            this.Controls.Add(this.txtTextoB);
            this.Controls.Add(this.txtTextoA);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTextoB);
            this.Controls.Add(this.lblTextoA);
            this.Name = "frmCadenas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadenas";
            this.mrcResultado.ResumeLayout(false);
            this.mrcResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoA;
        private System.Windows.Forms.Label lblTextoB;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtTextoA;
        private System.Windows.Forms.TextBox txtTextoB;
        private System.Windows.Forms.ComboBox lstFecha;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.GroupBox mrcResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblCantidadA;
        private System.Windows.Forms.Label lblCantidadB;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReemplazar;
    }
}

