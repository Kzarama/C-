namespace Cap4_Fundamentos_Lenguaje
{
    partial class FrmCap4
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbxOperacion = new System.Windows.Forms.ComboBox();
            this.TxtOp1 = new System.Windows.Forms.TextBox();
            this.TxtOp2 = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnCalcula = new System.Windows.Forms.Button();
            this.TxtOperacion = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // CbxOperacion
            // 
            this.CbxOperacion.FormattingEnabled = true;
            this.CbxOperacion.Items.AddRange(new object[] {
            "+ Suma",
            "- Resta",
            "x Multiplica",
            "/ Divide"});
            this.CbxOperacion.Location = new System.Drawing.Point(116, 36);
            this.CbxOperacion.Name = "CbxOperacion";
            this.CbxOperacion.Size = new System.Drawing.Size(121, 21);
            this.CbxOperacion.TabIndex = 0;
            // 
            // TxtOp1
            // 
            this.TxtOp1.Location = new System.Drawing.Point(10, 36);
            this.TxtOp1.Name = "TxtOp1";
            this.TxtOp1.Size = new System.Drawing.Size(100, 20);
            this.TxtOp1.TabIndex = 1;
            // 
            // TxtOp2
            // 
            this.TxtOp2.Location = new System.Drawing.Point(243, 37);
            this.TxtOp2.Name = "TxtOp2";
            this.TxtOp2.Size = new System.Drawing.Size(100, 20);
            this.TxtOp2.TabIndex = 2;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(535, 36);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(100, 20);
            this.TxtResultado.TabIndex = 3;
            // 
            // BtnCalcula
            // 
            this.BtnCalcula.Location = new System.Drawing.Point(641, 35);
            this.BtnCalcula.Name = "BtnCalcula";
            this.BtnCalcula.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcula.TabIndex = 4;
            this.BtnCalcula.Text = "Calcular";
            this.BtnCalcula.UseVisualStyleBackColor = true;
            this.BtnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // TxtOperacion
            // 
            this.TxtOperacion.Location = new System.Drawing.Point(362, 36);
            this.TxtOperacion.Name = "TxtOperacion";
            this.TxtOperacion.ReadOnly = true;
            this.TxtOperacion.Size = new System.Drawing.Size(167, 20);
            this.TxtOperacion.TabIndex = 5;
            this.TxtOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(733, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmCap4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 311);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TxtOperacion);
            this.Controls.Add(this.BtnCalcula);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtOp2);
            this.Controls.Add(this.TxtOp1);
            this.Controls.Add(this.CbxOperacion);
            this.Name = "FrmCap4";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxOperacion;
        private System.Windows.Forms.TextBox TxtOp1;
        private System.Windows.Forms.TextBox TxtOp2;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnCalcula;
        private System.Windows.Forms.TextBox TxtOperacion;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

