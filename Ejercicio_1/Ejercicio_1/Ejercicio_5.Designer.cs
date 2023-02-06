namespace Ejercicio_1
{
    partial class Ejercicio_5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hornearbutton = new System.Windows.Forms.Button();
            this.HornearAsincronobutton = new System.Windows.Forms.Button();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hornearbutton
            // 
            this.Hornearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hornearbutton.Location = new System.Drawing.Point(126, 82);
            this.Hornearbutton.Name = "Hornearbutton";
            this.Hornearbutton.Size = new System.Drawing.Size(313, 74);
            this.Hornearbutton.TabIndex = 0;
            this.Hornearbutton.Text = "Hornear Pizza";
            this.Hornearbutton.UseVisualStyleBackColor = true;
            this.Hornearbutton.Click += new System.EventHandler(this.Hornearbutton_Click);
            // 
            // HornearAsincronobutton
            // 
            this.HornearAsincronobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HornearAsincronobutton.Location = new System.Drawing.Point(530, 82);
            this.HornearAsincronobutton.Name = "HornearAsincronobutton";
            this.HornearAsincronobutton.Size = new System.Drawing.Size(313, 74);
            this.HornearAsincronobutton.TabIndex = 1;
            this.HornearAsincronobutton.Text = "Hornear Pizza Asincrona";
            this.HornearAsincronobutton.UseVisualStyleBackColor = true;
            this.HornearAsincronobutton.Click += new System.EventHandler(this.HornearAsincronobutton_Click);
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularbutton.Location = new System.Drawing.Point(530, 260);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(121, 61);
            this.Calcularbutton.TabIndex = 2;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero1textBox.Location = new System.Drawing.Point(250, 243);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(215, 30);
            this.Numero1textBox.TabIndex = 3;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero2textBox.Location = new System.Drawing.Point(250, 314);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(215, 30);
            this.Numero2textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero2";
            // 
            // Ejercicio_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.HornearAsincronobutton);
            this.Controls.Add(this.Hornearbutton);
            this.Name = "Ejercicio_5";
            this.Text = "Ejercicio_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hornearbutton;
        private System.Windows.Forms.Button HornearAsincronobutton;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}