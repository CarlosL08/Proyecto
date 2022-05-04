namespace WindowsFormsApp1
{
    partial class Articulos
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
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.TxtC_Producto = new System.Windows.Forms.TextBox();
            this.TxtN_Departamento = new System.Windows.Forms.TextBox();
            this.TxtN_Producto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LlbUsuario = new System.Windows.Forms.Label();
            this.LblCargo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Caducidad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Txt_ID_Articulo = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnguardarbarra = new System.Windows.Forms.Button();
            this.imgbarra = new System.Windows.Forms.PictureBox();
            this.btnbarra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(133, 250);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(177, 20);
            this.Txt_Cantidad.TabIndex = 49;
            // 
            // TxtC_Producto
            // 
            this.TxtC_Producto.Location = new System.Drawing.Point(133, 211);
            this.TxtC_Producto.Name = "TxtC_Producto";
            this.TxtC_Producto.Size = new System.Drawing.Size(177, 20);
            this.TxtC_Producto.TabIndex = 48;
            // 
            // TxtN_Departamento
            // 
            this.TxtN_Departamento.Location = new System.Drawing.Point(420, 329);
            this.TxtN_Departamento.Name = "TxtN_Departamento";
            this.TxtN_Departamento.Size = new System.Drawing.Size(194, 20);
            this.TxtN_Departamento.TabIndex = 46;
            // 
            // TxtN_Producto
            // 
            this.TxtN_Producto.Location = new System.Drawing.Point(133, 94);
            this.TxtN_Producto.Name = "TxtN_Producto";
            this.TxtN_Producto.Size = new System.Drawing.Size(177, 20);
            this.TxtN_Producto.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(16, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Caducidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(16, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(16, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Costo Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(16, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Provedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Codigo producto";
            // 
            // LlbUsuario
            // 
            this.LlbUsuario.AutoSize = true;
            this.LlbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LlbUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LlbUsuario.Location = new System.Drawing.Point(80, 29);
            this.LlbUsuario.Name = "LlbUsuario";
            this.LlbUsuario.Size = new System.Drawing.Size(16, 13);
            this.LlbUsuario.TabIndex = 37;
            this.LlbUsuario.Text = "...";
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.BackColor = System.Drawing.Color.Transparent;
            this.LblCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCargo.Location = new System.Drawing.Point(244, 29);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(16, 13);
            this.LblCargo.TabIndex = 36;
            this.LblCargo.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(186, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cargo";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(16, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 13);
            this.label.TabIndex = 31;
            this.label.Text = "Usuario";
            this.label.Click += new System.EventHandler(this.LblUs_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(16, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(95, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(16, 536);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Caducidad";
            // 
            // Caducidad
            // 
            this.Caducidad.AutoSize = true;
            this.Caducidad.BackColor = System.Drawing.Color.Transparent;
            this.Caducidad.ForeColor = System.Drawing.SystemColors.Info;
            this.Caducidad.Location = new System.Drawing.Point(95, 536);
            this.Caducidad.Name = "Caducidad";
            this.Caducidad.Size = new System.Drawing.Size(16, 13);
            this.Caducidad.TabIndex = 56;
            this.Caducidad.Text = "...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(364, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminiarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminiarToolStripMenuItem
            // 
            this.eliminiarToolStripMenuItem.Name = "eliminiarToolStripMenuItem";
            this.eliminiarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.eliminiarToolStripMenuItem.Text = "Eliminiar";
            this.eliminiarToolStripMenuItem.Click += new System.EventHandler(this.eliminiarToolStripMenuItem_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 58;
            // 
            // Txt_ID_Articulo
            // 
            this.Txt_ID_Articulo.Enabled = false;
            this.Txt_ID_Articulo.Location = new System.Drawing.Point(133, 364);
            this.Txt_ID_Articulo.Name = "Txt_ID_Articulo";
            this.Txt_ID_Articulo.Size = new System.Drawing.Size(176, 20);
            this.Txt_ID_Articulo.TabIndex = 59;
            // 
            // btnguardarbarra
            // 
            this.btnguardarbarra.Location = new System.Drawing.Point(193, 459);
            this.btnguardarbarra.Name = "btnguardarbarra";
            this.btnguardarbarra.Size = new System.Drawing.Size(67, 26);
            this.btnguardarbarra.TabIndex = 3;
            this.btnguardarbarra.Text = "Guardar";
            this.btnguardarbarra.UseVisualStyleBackColor = true;
            this.btnguardarbarra.Click += new System.EventHandler(this.btnguardarbarra_Click);
            // 
            // imgbarra
            // 
            this.imgbarra.Location = new System.Drawing.Point(16, 421);
            this.imgbarra.Name = "imgbarra";
            this.imgbarra.Size = new System.Drawing.Size(106, 64);
            this.imgbarra.TabIndex = 2;
            this.imgbarra.TabStop = false;
            // 
            // btnbarra
            // 
            this.btnbarra.Location = new System.Drawing.Point(193, 421);
            this.btnbarra.Name = "btnbarra";
            this.btnbarra.Size = new System.Drawing.Size(67, 29);
            this.btnbarra.TabIndex = 1;
            this.btnbarra.Text = "Generar";
            this.btnbarra.UseVisualStyleBackColor = true;
            this.btnbarra.Click += new System.EventHandler(this.btnbarra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.Caducidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnguardarbarra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblCargo);
            this.groupBox1.Controls.Add(this.LlbUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.imgbarra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnbarra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Txt_ID_Articulo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.TxtN_Producto);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.TxtC_Producto);
            this.groupBox1.Controls.Add(this.Txt_Cantidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 568);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(982, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtN_Departamento);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox TxtC_Producto;
        private System.Windows.Forms.TextBox TxtN_Departamento;
        private System.Windows.Forms.TextBox TxtN_Producto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LlbUsuario;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Caducidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminiarToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox Txt_ID_Articulo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnguardarbarra;
        private System.Windows.Forms.PictureBox imgbarra;
        private System.Windows.Forms.Button btnbarra;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}