namespace FablabCatalagoVirtualCapasUI
{
    partial class EliminarRegistro
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(16, 134);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(584, 295);
			this.dataGridView1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(92, 82);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(361, 22);
			this.textBox1.TabIndex = 1;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.btnElimnar2;
			this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(625, 222);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(127, 118);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
			this.btnBuscar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.lupa2;
			this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Location = new System.Drawing.Point(463, 75);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(39, 38);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.FlechaAtras;
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.ForeColor = System.Drawing.Color.Transparent;
			this.btnRegresar.Location = new System.Drawing.Point(3, 4);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(45, 39);
			this.btnRegresar.TabIndex = 4;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// EliminarRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.BackgroundIngresar;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(768, 517);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "EliminarRegistro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EliminarRegistro";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegresar;
    }
}