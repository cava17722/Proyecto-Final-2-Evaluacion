namespace MultiPrograma.Aplicacion3
{
    partial class Aplicacion3
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
            this.label2 = new System.Windows.Forms.Label();
            this.BBotonSerie = new System.Windows.Forms.Button();
            this.TNumero = new System.Windows.Forms.TextBox();
            this.LIntroduceNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calcule el valor de la suma de la siguiente serie para un numero n leído por tecl" +
    "ado y mayor que 0.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Serie: 1 - 1/2 + 1/3 - 1/4........(+ -) 1/n";
            // 
            // BBotonSerie
            // 
            this.BBotonSerie.Location = new System.Drawing.Point(200, 183);
            this.BBotonSerie.Name = "BBotonSerie";
            this.BBotonSerie.Size = new System.Drawing.Size(114, 40);
            this.BBotonSerie.TabIndex = 9;
            this.BBotonSerie.Text = "Calcular Serie";
            this.BBotonSerie.UseVisualStyleBackColor = true;
            this.BBotonSerie.Click += new System.EventHandler(this.BBotonSerie_Click);
            // 
            // TNumero
            // 
            this.TNumero.Location = new System.Drawing.Point(200, 133);
            this.TNumero.Name = "TNumero";
            this.TNumero.Size = new System.Drawing.Size(113, 20);
            this.TNumero.TabIndex = 8;
            // 
            // LIntroduceNumero
            // 
            this.LIntroduceNumero.AutoSize = true;
            this.LIntroduceNumero.Location = new System.Drawing.Point(197, 105);
            this.LIntroduceNumero.Name = "LIntroduceNumero";
            this.LIntroduceNumero.Size = new System.Drawing.Size(95, 13);
            this.LIntroduceNumero.TabIndex = 7;
            this.LIntroduceNumero.Text = "Introduce Numero:";
            // 
            // Aplicacion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 308);
            this.Controls.Add(this.BBotonSerie);
            this.Controls.Add(this.TNumero);
            this.Controls.Add(this.LIntroduceNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Aplicacion3";
            this.Text = "Aplicacion3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BBotonSerie;
        private System.Windows.Forms.TextBox TNumero;
        private System.Windows.Forms.Label LIntroduceNumero;
    }
}