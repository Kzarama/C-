namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ACEPTAR = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Label();
            this.NOMBRE = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ACEPTAR
            // 
            this.ACEPTAR.Location = new System.Drawing.Point(122, 73);
            this.ACEPTAR.Name = "ACEPTAR";
            this.ACEPTAR.Size = new System.Drawing.Size(75, 23);
            this.ACEPTAR.TabIndex = 0;
            this.ACEPTAR.Text = "ACEPTAR";
            this.ACEPTAR.UseVisualStyleBackColor = true;
            this.ACEPTAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(36, 16);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(102, 43);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "INGRESE EL PESO DEL LIBRO";
            this.ADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Location = new System.Drawing.Point(167, 28);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.NOMBRE.TabIndex = 2;
            // 
            // TOTAL
            // 
            this.TOTAL.Location = new System.Drawing.Point(136, 137);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(90, 38);
            this.TOTAL.TabIndex = 3;
            this.TOTAL.Text = "MOSTRAR PESO TOTAL";
            this.TOTAL.UseVisualStyleBackColor = true;
            this.TOTAL.Click += new System.EventHandler(this.TOTAL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 202);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.ACEPTAR);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LIBRERIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ACEPTAR;
        private System.Windows.Forms.Label ADD;
        private System.Windows.Forms.TextBox NOMBRE;
        private System.Windows.Forms.Button TOTAL;
    }
}

