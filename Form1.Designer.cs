namespace OrdenarListasD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonOrdenarNumero = new System.Windows.Forms.Button();
            this.buttonOrdenarFecha = new System.Windows.Forms.Button();
            this.buttonOrdenarTexto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 23);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(496, 209);
            this.dataGridView1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(113, 80);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(185, 23);
            this.numericUpDown1.TabIndex = 4;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(118, 340);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(146, 75);
            this.buttonIngresar.TabIndex = 5;
            this.buttonIngresar.Text = "ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonOrdenarNumero
            // 
            this.buttonOrdenarNumero.Location = new System.Drawing.Point(333, 345);
            this.buttonOrdenarNumero.Name = "buttonOrdenarNumero";
            this.buttonOrdenarNumero.Size = new System.Drawing.Size(138, 70);
            this.buttonOrdenarNumero.TabIndex = 6;
            this.buttonOrdenarNumero.Text = "Ordenar Numerico";
            this.buttonOrdenarNumero.UseVisualStyleBackColor = true;
            this.buttonOrdenarNumero.Click += new System.EventHandler(this.buttonOrdenarNumero_Click);
            // 
            // buttonOrdenarFecha
            // 
            this.buttonOrdenarFecha.Location = new System.Drawing.Point(532, 350);
            this.buttonOrdenarFecha.Name = "buttonOrdenarFecha";
            this.buttonOrdenarFecha.Size = new System.Drawing.Size(148, 65);
            this.buttonOrdenarFecha.TabIndex = 7;
            this.buttonOrdenarFecha.Text = "Orden Fecha";
            this.buttonOrdenarFecha.UseVisualStyleBackColor = true;
            this.buttonOrdenarFecha.Click += new System.EventHandler(this.buttonOrdenarFecha_Click);
            // 
            // buttonOrdenarTexto
            // 
            this.buttonOrdenarTexto.Location = new System.Drawing.Point(730, 356);
            this.buttonOrdenarTexto.Name = "buttonOrdenarTexto";
            this.buttonOrdenarTexto.Size = new System.Drawing.Size(147, 59);
            this.buttonOrdenarTexto.TabIndex = 8;
            this.buttonOrdenarTexto.Text = "Ordenar Texto";
            this.buttonOrdenarTexto.UseVisualStyleBackColor = true;
            this.buttonOrdenarTexto.Click += new System.EventHandler(this.buttonOrdenarTexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 535);
            this.Controls.Add(this.buttonOrdenarTexto);
            this.Controls.Add(this.buttonOrdenarFecha);
            this.Controls.Add(this.buttonOrdenarNumero);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonOrdenarNumero;
        private System.Windows.Forms.Button buttonOrdenarFecha;
        private System.Windows.Forms.Button buttonOrdenarTexto;
    }
}
