namespace FablabCatalagoVirtualCapasUI
{
    partial class ListaPrototipos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPrototipos));
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.dgvlistaprototipos = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvlistaprototipos)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
			this.btnSiguiente.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.Botonsubmit;
			this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSiguiente.FlatAppearance.BorderSize = 0;
			this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSiguiente.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSiguiente.Location = new System.Drawing.Point(350, 366);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(132, 48);
			this.btnSiguiente.TabIndex = 30;
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Visible = false;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnRegresar
			// 
			this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.FlechaAtras;
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRegresar.Location = new System.Drawing.Point(-2, 6);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(48, 37);
			this.btnRegresar.TabIndex = 32;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btncancelar_Click_1);
			// 
			// dgvlistaprototipos
			// 
			this.dgvlistaprototipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvlistaprototipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvlistaprototipos.Location = new System.Drawing.Point(-1, 103);
			this.dgvlistaprototipos.Name = "dgvlistaprototipos";
			this.dgvlistaprototipos.ReadOnly = true;
			this.dgvlistaprototipos.RowHeadersWidth = 51;
			this.dgvlistaprototipos.Size = new System.Drawing.Size(801, 256);
			this.dgvlistaprototipos.TabIndex = 2;
			this.dgvlistaprototipos.SelectionChanged += new System.EventHandler(this.dgvlistaprototipos_SelectionChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.AliceBlue;
			this.label2.Location = new System.Drawing.Point(279, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(254, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Listado de prototipos";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(688, 23);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 33;
			// 
			// ListaPrototipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.BackgroundMain;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 440);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnSiguiente);
			this.Controls.Add(this.dgvlistaprototipos);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ListaPrototipos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ListaPrototipos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaPrototipos_FormClosing);
			this.Load += new System.EventHandler(this.ListaPrototipos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvlistaprototipos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.DataGridView dgvlistaprototipos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
	}
}