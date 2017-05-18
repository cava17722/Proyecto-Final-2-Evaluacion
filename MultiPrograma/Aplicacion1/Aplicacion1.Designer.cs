namespace MultiPrograma.Aplicacion1
{
    partial class Aplicacion1
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
            this.BBotonMulti = new System.Windows.Forms.Button();
            this.TNumero2 = new System.Windows.Forms.TextBox();
            this.LIntroduceNumeroDos = new System.Windows.Forms.Label();
            this.TNumero = new System.Windows.Forms.TextBox();
            this.LIntroduceNumero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calcula el producto de un numero usando sumas sucesivas. ";
            // 
            // BBotonMulti
            // 
            this.BBotonMulti.Location = new System.Drawing.Point(156, 251);
            this.BBotonMulti.Name = "BBotonMulti";
            this.BBotonMulti.Size = new System.Drawing.Size(127, 25);
            this.BBotonMulti.TabIndex = 9;
            this.BBotonMulti.Text = "Calcular ";
            this.BBotonMulti.UseVisualStyleBackColor = true;
            this.BBotonMulti.Click += new System.EventHandler(this.BBotonMulti_Click);
            // 
            // TNumero2
            // 
            this.TNumero2.Location = new System.Drawing.Point(155, 195);
            this.TNumero2.Name = "TNumero2";
            this.TNumero2.Size = new System.Drawing.Size(128, 20);
            this.TNumero2.TabIndex = 8;
            // 
            // LIntroduceNumeroDos
            // 
            this.LIntroduceNumeroDos.AutoSize = true;
            this.LIntroduceNumeroDos.Location = new System.Drawing.Point(153, 150);
            this.LIntroduceNumeroDos.Name = "LIntroduceNumeroDos";
            this.LIntroduceNumeroDos.Size = new System.Drawing.Size(135, 13);
            this.LIntroduceNumeroDos.TabIndex = 7;
            this.LIntroduceNumeroDos.Text = "Intoduce Segundo Numero";
            // 
            // TNumero
            // 
            this.TNumero.Location = new System.Drawing.Point(148, 104);
            this.TNumero.Name = "TNumero";
            this.TNumero.Size = new System.Drawing.Size(136, 20);
            this.TNumero.TabIndex = 6;
            // 
            // LIntroduceNumero
            // 
            this.LIntroduceNumero.AutoSize = true;
            this.LIntroduceNumero.Location = new System.Drawing.Point(142, 78);
            this.LIntroduceNumero.Name = "LIntroduceNumero";
            this.LIntroduceNumero.Size = new System.Drawing.Size(92, 13);
            this.LIntroduceNumero.TabIndex = 5;
            this.LIntroduceNumero.Text = "Introduce Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Los valores introducidos pueden ser positivos o negativos";
            // 
            // Aplicacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BBotonMulti);
            this.Controls.Add(this.TNumero2);
            this.Controls.Add(this.LIntroduceNumeroDos);
            this.Controls.Add(this.TNumero);
            this.Controls.Add(this.LIntroduceNumero);
            this.Controls.Add(this.label1);
            this.Name = "Aplicacion1";
            this.Text = "Aplicacion1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BBotonMulti;
        private System.Windows.Forms.TextBox TNumero2;
        private System.Windows.Forms.Label LIntroduceNumeroDos;
        private System.Windows.Forms.TextBox TNumero;
        private System.Windows.Forms.Label LIntroduceNumero;
        private System.Windows.Forms.Label label2;
    }
}