namespace AppCheckBox
{
    partial class Form1
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
            this.chkingles = new System.Windows.Forms.CheckBox();
            this.chkfrances = new System.Windows.Forms.CheckBox();
            this.chkaleman = new System.Windows.Forms.CheckBox();
            this.Boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkingles
            // 
            this.chkingles.AutoSize = true;
            this.chkingles.Location = new System.Drawing.Point(28, 38);
            this.chkingles.Name = "chkingles";
            this.chkingles.Size = new System.Drawing.Size(54, 17);
            this.chkingles.TabIndex = 0;
            this.chkingles.Text = "Ingles";
            this.chkingles.UseVisualStyleBackColor = true;
            // 
            // chkfrances
            // 
            this.chkfrances.AutoSize = true;
            this.chkfrances.Location = new System.Drawing.Point(28, 62);
            this.chkfrances.Name = "chkfrances";
            this.chkfrances.Size = new System.Drawing.Size(64, 17);
            this.chkfrances.TabIndex = 1;
            this.chkfrances.Text = "Frances";
            this.chkfrances.UseVisualStyleBackColor = true;
            // 
            // chkaleman
            // 
            this.chkaleman.AutoSize = true;
            this.chkaleman.Location = new System.Drawing.Point(28, 85);
            this.chkaleman.Name = "chkaleman";
            this.chkaleman.Size = new System.Drawing.Size(61, 17);
            this.chkaleman.TabIndex = 2;
            this.chkaleman.Text = "Aleman";
            this.chkaleman.UseVisualStyleBackColor = true;
            // 
            // Boton
            // 
            this.Boton.Location = new System.Drawing.Point(32, 136);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(161, 23);
            this.Boton.TabIndex = 3;
            this.Boton.Text = "Mostrar Idiomas";
            this.Boton.UseVisualStyleBackColor = true;
            this.Boton.Click += new System.EventHandler(this.Boton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.chkaleman);
            this.Controls.Add(this.chkfrances);
            this.Controls.Add(this.chkingles);
            this.Name = "Form1";
            this.Text = "Mostrar Idiomas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkingles;
        private System.Windows.Forms.CheckBox chkfrances;
        private System.Windows.Forms.CheckBox chkaleman;
        private System.Windows.Forms.Button Boton;
    }
}

