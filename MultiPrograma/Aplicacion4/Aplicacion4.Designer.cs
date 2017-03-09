namespace MultiPrograma.Aplicacion4
{
    partial class Aplicacion4
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
            this.label1 = new System.Windows.Forms.Label();
            this.BBotonTabla = new System.Windows.Forms.Button();
            this.TNumTabla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Introduce un número que sea > 0 y <=100 para mostrar su tabla de multiplicar";
            // 
            // BBotonTabla
            // 
            this.BBotonTabla.Location = new System.Drawing.Point(172, 156);
            this.BBotonTabla.Name = "BBotonTabla";
            this.BBotonTabla.Size = new System.Drawing.Size(99, 50);
            this.BBotonTabla.TabIndex = 9;
            this.BBotonTabla.Text = "Mostrar tabla";
            this.BBotonTabla.UseVisualStyleBackColor = true;
            this.BBotonTabla.Click += new System.EventHandler(this.BBotonTabla_Click);
            // 
            // TNumTabla
            // 
            this.TNumTabla.Location = new System.Drawing.Point(179, 77);
            this.TNumTabla.Name = "TNumTabla";
            this.TNumTabla.Size = new System.Drawing.Size(136, 20);
            this.TNumTabla.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número:";
            // 
            // Aplicacion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 303);
            this.Controls.Add(this.BBotonTabla);
            this.Controls.Add(this.TNumTabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Aplicacion4";
            this.Text = "Aplicacion4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BBotonTabla;
        private System.Windows.Forms.TextBox TNumTabla;
        private System.Windows.Forms.Label label2;
    }
}