namespace AppNumerosEnteros
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.BotonSumar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ingrese Primer Valor";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 67);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(118, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Ingrese Segundo Valor:";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(136, 26);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 2;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(136, 60);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 3;
            // 
            // BotonSumar
            // 
            this.BotonSumar.Location = new System.Drawing.Point(98, 112);
            this.BotonSumar.Name = "BotonSumar";
            this.BotonSumar.Size = new System.Drawing.Size(75, 23);
            this.BotonSumar.TabIndex = 4;
            this.BotonSumar.Text = "Sumar";
            this.BotonSumar.UseVisualStyleBackColor = true;
            this.BotonSumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(192, 112);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 262);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.BotonSumar);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Programa Suma de Enteros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Button BotonSumar;
        private System.Windows.Forms.Label lblresultado;
    }
}

