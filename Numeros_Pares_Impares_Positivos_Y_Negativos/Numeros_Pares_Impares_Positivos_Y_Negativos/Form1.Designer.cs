namespace Numeros_Pares_Impares_Positivos_Y_Negativos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1textBox1 = new System.Windows.Forms.TextBox();
            this.Ejecutarbutton1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Numero";
            // 
            // Numero1textBox1
            // 
            this.Numero1textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero1textBox1.Location = new System.Drawing.Point(286, 140);
            this.Numero1textBox1.Name = "Numero1textBox1";
            this.Numero1textBox1.Size = new System.Drawing.Size(153, 34);
            this.Numero1textBox1.TabIndex = 1;
            // 
            // Ejecutarbutton1
            // 
            this.Ejecutarbutton1.BackColor = System.Drawing.SystemColors.Window;
            this.Ejecutarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejecutarbutton1.Location = new System.Drawing.Point(286, 204);
            this.Ejecutarbutton1.Name = "Ejecutarbutton1";
            this.Ejecutarbutton1.Size = new System.Drawing.Size(95, 39);
            this.Ejecutarbutton1.TabIndex = 2;
            this.Ejecutarbutton1.Text = "Ejecutar";
            this.Ejecutarbutton1.UseVisualStyleBackColor = false;
            this.Ejecutarbutton1.Click += new System.EventHandler(this.Ejecutarbutton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ejecutarbutton1);
            this.Controls.Add(this.Numero1textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1textBox1;
        private System.Windows.Forms.Button Ejecutarbutton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

