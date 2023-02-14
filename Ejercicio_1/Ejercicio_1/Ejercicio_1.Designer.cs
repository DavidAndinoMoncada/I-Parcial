namespace Ejercicio_1
{
    partial class Ejercicio_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1textBox1 = new System.Windows.Forms.TextBox();
            this.Numero2textBox2 = new System.Windows.Forms.TextBox();
            this.Sumarbutton1 = new System.Windows.Forms.Button();
            this.Resultadolabel = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // Numero1textBox1
            // 
            this.Numero1textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.Numero1textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Numero1textBox1.Location = new System.Drawing.Point(202, 96);
            this.Numero1textBox1.Name = "Numero1textBox1";
            this.Numero1textBox1.Size = new System.Drawing.Size(170, 22);
            this.Numero1textBox1.TabIndex = 2;
            // 
            // Numero2textBox2
            // 
            this.Numero2textBox2.Location = new System.Drawing.Point(202, 159);
            this.Numero2textBox2.Name = "Numero2textBox2";
            this.Numero2textBox2.Size = new System.Drawing.Size(170, 22);
            this.Numero2textBox2.TabIndex = 3;
            // 
            // Sumarbutton1
            // 
            this.Sumarbutton1.Location = new System.Drawing.Point(219, 212);
            this.Sumarbutton1.Name = "Sumarbutton1";
            this.Sumarbutton1.Size = new System.Drawing.Size(129, 41);
            this.Sumarbutton1.TabIndex = 4;
            this.Sumarbutton1.Text = "Sumar";
            this.Sumarbutton1.UseVisualStyleBackColor = true;
            this.Sumarbutton1.Click += new System.EventHandler(this.Sumarbutton1_Click);
            // 
            // Resultadolabel
            // 
            this.Resultadolabel.AutoSize = true;
            this.Resultadolabel.Location = new System.Drawing.Point(102, 288);
            this.Resultadolabel.Name = "Resultadolabel";
            this.Resultadolabel.Size = new System.Drawing.Size(69, 16);
            this.Resultadolabel.TabIndex = 5;
            this.Resultadolabel.Text = "Resultado";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(202, 285);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(167, 22);
            this.ResultadotextBox.TabIndex = 6;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.Sumarbutton1);
            this.Controls.Add(this.Numero2textBox2);
            this.Controls.Add(this.Numero1textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1textBox1;
        private System.Windows.Forms.TextBox Numero2textBox2;
        private System.Windows.Forms.Button Sumarbutton1;
        private System.Windows.Forms.Label Resultadolabel;
        private System.Windows.Forms.TextBox ResultadotextBox;
    }
}

