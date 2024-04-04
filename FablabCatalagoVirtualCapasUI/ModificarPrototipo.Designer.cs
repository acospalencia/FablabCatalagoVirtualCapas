namespace FablabCatalagoVirtualCapasUI
{
    partial class ModificarPrototipo
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblMaterial = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblTiempo = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnRegresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(41, 211);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(661, 180);
			this.dataGridView1.TabIndex = 0;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(119, 147);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(128, 17);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre del Prototipo";
			// 
			// lblMaterial
			// 
			this.lblMaterial.AutoSize = true;
			this.lblMaterial.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaterial.Location = new System.Drawing.Point(119, 176);
			this.lblMaterial.Name = "lblMaterial";
			this.lblMaterial.Size = new System.Drawing.Size(136, 17);
			this.lblMaterial.TabIndex = 2;
			this.lblMaterial.Text = "Tipo de material usado";
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecio.Location = new System.Drawing.Point(119, 84);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(43, 17);
			this.lblPrecio.TabIndex = 3;
			this.lblPrecio.Text = "Precio";
			this.lblPrecio.Click += new System.EventHandler(this.label3_Click);
			// 
			// lblTiempo
			// 
			this.lblTiempo.AutoSize = true;
			this.lblTiempo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTiempo.Location = new System.Drawing.Point(119, 119);
			this.lblTiempo.Name = "lblTiempo";
			this.lblTiempo.Size = new System.Drawing.Size(103, 17);
			this.lblTiempo.TabIndex = 4;
			this.lblTiempo.Text = "Tiempo invertido";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(298, 173);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(298, 147);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(298, 84);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(298, 116);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Location = new System.Drawing.Point(-1, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(747, 71);
			this.panel1.TabIndex = 8;
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(12, 412);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(127, 26);
			this.btnRegresar.TabIndex = 9;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// ModificarPrototipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(741, 450);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.lblTiempo);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblMaterial);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ModificarPrototipo";
			this.Text = "ModificarPrototipo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarPrototipo_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnRegresar;
	}
}