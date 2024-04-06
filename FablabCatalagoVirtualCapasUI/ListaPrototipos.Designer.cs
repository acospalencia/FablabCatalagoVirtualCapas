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
			this.dgvlistaprototipos = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvlistaprototipos)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvlistaprototipos
			// 
			this.dgvlistaprototipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvlistaprototipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvlistaprototipos.Location = new System.Drawing.Point(4, 103);
			this.dgvlistaprototipos.Name = "dgvlistaprototipos";
			this.dgvlistaprototipos.RowHeadersWidth = 51;
			this.dgvlistaprototipos.Size = new System.Drawing.Size(794, 256);
			this.dgvlistaprototipos.TabIndex = 2;
			this.dgvlistaprototipos.SelectionChanged += new System.EventHandler(this.dgvlistaprototipos_SelectionChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(196, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(418, 63);
			this.panel1.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(92, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(254, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Listado de prototipos";
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnSiguiente.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSiguiente.Location = new System.Drawing.Point(551, 382);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(153, 42);
			this.btnSiguiente.TabIndex = 30;
			this.btnSiguiente.Text = "Siguiente";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Visible = false;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.Location = new System.Drawing.Point(4, 3);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(44, 37);
			this.btnRegresar.TabIndex = 31;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btncancelar_Click_1);
			// 
			// ListaPrototipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.IMG2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnSiguiente);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvlistaprototipos);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "ListaPrototipos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ListaPrototipos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaPrototipos_FormClosing);
			this.Load += new System.EventHandler(this.ListaPrototipos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvlistaprototipos)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvlistaprototipos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRegresar;
    }
}