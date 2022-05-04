namespace WindowsFormsApp1
{
    partial class Copia_De_Seguridad
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
            this.btngenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Restaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(102, 117);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(135, 32);
            this.btngenerar.TabIndex = 3;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.Btngenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generar copia ";
            // 
            // Restaurar
            // 
            this.Restaurar.Location = new System.Drawing.Point(102, 167);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(135, 32);
            this.Restaurar.TabIndex = 4;
            this.Restaurar.Text = "Restaurar";
            this.Restaurar.UseVisualStyleBackColor = true;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Copia_De_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 231);
            this.Controls.Add(this.Restaurar);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.label1);
            this.Name = "Copia_De_Seguridad";
            this.Text = "Copia_De_Seguridad";
            this.Load += new System.EventHandler(this.Copia_De_Seguridad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Restaurar;
    }
}