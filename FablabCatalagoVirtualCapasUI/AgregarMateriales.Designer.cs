﻿namespace FablabCatalagoVirtualCapasUI
{
    partial class AgregarMateriales
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMateriales));
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbTipoMaterial = new System.Windows.Forms.ComboBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtY = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtZ = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtX = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(185, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(412, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "Agregar materiales";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(115, -55);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 36);
			this.label5.TabIndex = 34;
			this.label5.Text = "Precio";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(115, -138);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 36);
			this.label4.TabIndex = 29;
			this.label4.Text = "Tipo";
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
			this.btnRegresar.Location = new System.Drawing.Point(8, 10);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(51, 46);
			this.btnRegresar.TabIndex = 41;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.cbTipoMaterial);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtY);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtPrecio);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtZ);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txtX);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(114, 1);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(786, 706);
			this.panel1.TabIndex = 42;
			// 
			// cbTipoMaterial
			// 
			this.cbTipoMaterial.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.cbTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoMaterial.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTipoMaterial.FormattingEnabled = true;
			this.cbTipoMaterial.Location = new System.Drawing.Point(313, 210);
			this.cbTipoMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbTipoMaterial.Name = "cbTipoMaterial";
			this.cbTipoMaterial.Size = new System.Drawing.Size(344, 31);
			this.cbTipoMaterial.TabIndex = 60;
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.Botonsubmit;
			this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnModificar.Location = new System.Drawing.Point(303, 631);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(176, 59);
			this.btnModificar.TabIndex = 59;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(107, 201);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(199, 36);
			this.label2.TabIndex = 57;
			this.label2.Text = "Tipo Material:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(107, 464);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(195, 36);
			this.label3.TabIndex = 55;
			this.label3.Text = "Tamaño eje Y:";
			// 
			// txtY
			// 
			this.txtY.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtY.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtY.Location = new System.Drawing.Point(313, 466);
			this.txtY.Margin = new System.Windows.Forms.Padding(4);
			this.txtY.Multiline = true;
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(344, 35);
			this.txtY.TabIndex = 56;
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(313, 125);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Multiline = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(345, 35);
			this.txtNombre.TabIndex = 54;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(107, 289);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 36);
			this.label6.TabIndex = 53;
			this.label6.Text = "Precio:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Location = new System.Drawing.Point(107, 124);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(127, 36);
			this.label7.TabIndex = 52;
			this.label7.Text = "Nombre:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtPrecio.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(313, 295);
			this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrecio.Multiline = true;
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(348, 35);
			this.txtPrecio.TabIndex = 48;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label9.Location = new System.Drawing.Point(107, 372);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(199, 36);
			this.label9.TabIndex = 49;
			this.label9.Text = "Tamaño eje X:";
			// 
			// txtZ
			// 
			this.txtZ.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtZ.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtZ.Location = new System.Drawing.Point(313, 565);
			this.txtZ.Margin = new System.Windows.Forms.Padding(4);
			this.txtZ.Multiline = true;
			this.txtZ.Name = "txtZ";
			this.txtZ.Size = new System.Drawing.Size(348, 35);
			this.txtZ.TabIndex = 51;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label10.Location = new System.Drawing.Point(107, 563);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(201, 36);
			this.label10.TabIndex = 47;
			this.label10.Text = "Tamaño Eje Z:";
			// 
			// txtX
			// 
			this.txtX.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtX.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtX.Location = new System.Drawing.Point(313, 374);
			this.txtX.Margin = new System.Windows.Forms.Padding(4);
			this.txtX.Multiline = true;
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(344, 35);
			this.txtX.TabIndex = 50;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(-61, 602);
			this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 22);
			this.txtId.TabIndex = 47;
			this.txtId.Visible = false;
			// 
			// AgregarMateriales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(989, 704);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "AgregarMateriales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AgregarMateriales";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarMateriales_FormClosing);
			this.Load += new System.EventHandler(this.AgregarMateriales_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtZ;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.ComboBox cbTipoMaterial;
	}
}