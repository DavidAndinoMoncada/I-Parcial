namespace Ejercicio_1
{
    partial class Ejercicio_7
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
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TamañoMatriztextBox = new System.Windows.Forms.TextBox();
            this.FilatextBox = new System.Windows.Forms.TextBox();
            this.ColumnatextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejecutarbutton.Location = new System.Drawing.Point(298, 46);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(122, 43);
            this.Ejecutarbutton.TabIndex = 0;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(58, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 436);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño Matríz";
            // 
            // TamañoMatriztextBox
            // 
            this.TamañoMatriztextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamañoMatriztextBox.Location = new System.Drawing.Point(450, 283);
            this.TamañoMatriztextBox.Name = "TamañoMatriztextBox";
            this.TamañoMatriztextBox.Size = new System.Drawing.Size(170, 30);
            this.TamañoMatriztextBox.TabIndex = 3;
            // 
            // FilatextBox
            // 
            this.FilatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilatextBox.Location = new System.Drawing.Point(450, 130);
            this.FilatextBox.Name = "FilatextBox";
            this.FilatextBox.Size = new System.Drawing.Size(170, 30);
            this.FilatextBox.TabIndex = 4;
            // 
            // ColumnatextBox
            // 
            this.ColumnatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnatextBox.Location = new System.Drawing.Point(450, 181);
            this.ColumnatextBox.Name = "ColumnatextBox";
            this.ColumnatextBox.Size = new System.Drawing.Size(170, 30);
            this.ColumnatextBox.TabIndex = 5;
            // 
            // Ejercicio_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 479);
            this.Controls.Add(this.ColumnatextBox);
            this.Controls.Add(this.FilatextBox);
            this.Controls.Add(this.TamañoMatriztextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Ejecutarbutton);
            this.Name = "Ejercicio_7";
            this.Text = "Ejercicio_7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TamañoMatriztextBox;
        private System.Windows.Forms.TextBox FilatextBox;
        private System.Windows.Forms.TextBox ColumnatextBox;
    }
}