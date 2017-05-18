namespace MultiPrograma.Aplicacion2
{
    partial class Aplicacion2
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
            this.BBotonPrimo = new System.Windows.Forms.Button();
            this.TNumero = new System.Windows.Forms.TextBox();
            this.LIntroduceNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calcula si el numero es primo. El numero debe ser mayor a 0.";
            // 
            // BBotonPrimo
            // 
            this.BBotonPrimo.Location = new System.Drawing.Point(251, 160);
            this.BBotonPrimo.Name = "BBotonPrimo";
            this.BBotonPrimo.Size = new System.Drawing.Size(97, 34);
            this.BBotonPrimo.TabIndex = 7;
            this.BBotonPrimo.Text = "Comprobar Numero";
            this.BBotonPrimo.UseVisualStyleBackColor = true;
            this.BBotonPrimo.Click += new System.EventHandler(this.BBotonPrimo_Click);
            // 
            // TNumero
            // 
            this.TNumero.Location = new System.Drawing.Point(230, 113);
            this.TNumero.Name = "TNumero";
            this.TNumero.Size = new System.Drawing.Size(161, 20);
            this.TNumero.TabIndex = 6;
            // 
            // LIntroduceNumero
            // 
            this.LIntroduceNumero.AutoSize = true;
            this.LIntroduceNumero.Location = new System.Drawing.Point(226, 84);
            this.LIntroduceNumero.Name = "LIntroduceNumero";
            this.LIntroduceNumero.Size = new System.Drawing.Size(95, 13);
            this.LIntroduceNumero.TabIndex = 5;
            this.LIntroduceNumero.Text = "Introduce Numero:";
            // 
            // Aplicacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 287);
            this.Controls.Add(this.BBotonPrimo);
            this.Controls.Add(this.TNumero);
            this.Controls.Add(this.LIntroduceNumero);
            this.Controls.Add(this.label1);
            this.Name = "Aplicacion2";
            this.Text = "Aplicacion_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BBotonPrimo;
        private System.Windows.Forms.TextBox TNumero;
        private System.Windows.Forms.Label LIntroduceNumero;
    }
}