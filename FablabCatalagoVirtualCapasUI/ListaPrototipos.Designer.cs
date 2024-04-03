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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvlistaprototipos = new System.Windows.Forms.DataGridView();
			this.btncancelar = new System.Windows.Forms.Button();
			this.btnsiguiente = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvlistaprototipos)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(456, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(144, 108);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(373, 143);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Seleccione el prototipo";
			// 
			// dgvlistaprototipos
			// 
			this.dgvlistaprototipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvlistaprototipos.Location = new System.Drawing.Point(280, 188);
			this.dgvlistaprototipos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvlistaprototipos.Name = "dgvlistaprototipos";
			this.dgvlistaprototipos.RowHeadersWidth = 51;
			this.dgvlistaprototipos.Size = new System.Drawing.Size(479, 217);
			this.dgvlistaprototipos.TabIndex = 2;
			// 
			// btncancelar
			// 
			this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancelar.Location = new System.Drawing.Point(280, 449);
			this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(127, 50);
			this.btncancelar.TabIndex = 3;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsiguiente.Location = new System.Drawing.Point(659, 449);
			this.btnsiguiente.Margin = new System.Windows.Forms.Padding(4);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(127, 50);
			this.btnsiguiente.TabIndex = 4;
			this.btnsiguiente.Text = "Siguiente";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			// 
			// ListaPrototipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnsiguiente);
			this.Controls.Add(this.btncancelar);
			this.Controls.Add(this.dgvlistaprototipos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ListaPrototipos";
			this.Text = "ListaPrototipos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaPrototipos_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvlistaprototipos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlistaprototipos;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsiguiente;
    }
}