namespace FablabCatalagoVirtualCapasUI
{
    partial class ActualizarMateriales
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
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtprecio = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cbxtipomaterial = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtproveedor = new System.Windows.Forms.TextBox();
			this.txtdimensiones = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnguardar = new System.Windows.Forms.Button();
			this.btncancelar = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.Location = new System.Drawing.Point(412, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(237, 161);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(175, 193);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(623, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Seleccione el tipo de material que desea actualizar";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(304, 258);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tipo";
			// 
			// txtprecio
			// 
			this.txtprecio.Location = new System.Drawing.Point(483, 309);
			this.txtprecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtprecio.Name = "txtprecio";
			this.txtprecio.Size = new System.Drawing.Size(197, 22);
			this.txtprecio.TabIndex = 8;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// cbxtipomaterial
			// 
			this.cbxtipomaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxtipomaterial.FormattingEnabled = true;
			this.cbxtipomaterial.Items.AddRange(new object[] {
            "Filamento",
            "Resina",
            "Playbond"});
			this.cbxtipomaterial.Location = new System.Drawing.Point(483, 257);
			this.cbxtipomaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbxtipomaterial.Name = "cbxtipomaterial";
			this.cbxtipomaterial.Size = new System.Drawing.Size(197, 33);
			this.cbxtipomaterial.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(304, 354);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 25);
			this.label3.TabIndex = 11;
			this.label3.Text = "Dimensiones";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(304, 306);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 25);
			this.label4.TabIndex = 12;
			this.label4.Text = "Precio";
			// 
			// txtproveedor
			// 
			this.txtproveedor.Location = new System.Drawing.Point(483, 405);
			this.txtproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtproveedor.Name = "txtproveedor";
			this.txtproveedor.Size = new System.Drawing.Size(197, 22);
			this.txtproveedor.TabIndex = 13;
			// 
			// txtdimensiones
			// 
			this.txtdimensiones.Location = new System.Drawing.Point(483, 354);
			this.txtdimensiones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtdimensiones.Name = "txtdimensiones";
			this.txtdimensiones.Size = new System.Drawing.Size(197, 22);
			this.txtdimensiones.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(304, 405);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 25);
			this.label6.TabIndex = 16;
			this.label6.Text = "Proveedor";
			// 
			// btnguardar
			// 
			this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnguardar.Location = new System.Drawing.Point(897, 489);
			this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(137, 52);
			this.btnguardar.TabIndex = 17;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			// 
			// btncancelar
			// 
			this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancelar.Location = new System.Drawing.Point(601, 465);
			this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(137, 52);
			this.btncancelar.TabIndex = 18;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(859, 257);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(133, 111);
			this.pictureBox2.TabIndex = 19;
			this.pictureBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(859, 405);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 52);
			this.button1.TabIndex = 20;
			this.button1.Text = "subir imagen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// ActualizarMateriales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btncancelar);
			this.Controls.Add(this.btnguardar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtdimensiones);
			this.Controls.Add(this.txtproveedor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbxtipomaterial);
			this.Controls.Add(this.txtprecio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ActualizarMateriales";
			this.Text = "ActualizarMateriales";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbxtipomaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.TextBox txtdimensiones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}