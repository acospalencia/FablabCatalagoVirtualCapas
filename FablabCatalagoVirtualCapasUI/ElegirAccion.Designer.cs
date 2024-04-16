namespace FablabCatalagoVirtualCapasUI
{
	partial class ElegirAccion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirAccion));
			this.label1 = new System.Windows.Forms.Label();
			this.btnMaterial = new System.Windows.Forms.Button();
			this.btnPrototipo = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(268, 52);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(343, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Que sección desea administrar";
			// 
			// btnMaterial
			// 
			this.btnMaterial.BackColor = System.Drawing.Color.Transparent;
			this.btnMaterial.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaterial.Location = new System.Drawing.Point(121, 210);
			this.btnMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMaterial.Name = "btnMaterial";
			this.btnMaterial.Size = new System.Drawing.Size(260, 69);
			this.btnMaterial.TabIndex = 1;
			this.btnMaterial.Text = "Materiales";
			this.btnMaterial.UseVisualStyleBackColor = false;
			this.btnMaterial.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnPrototipo
			// 
			this.btnPrototipo.BackColor = System.Drawing.Color.Transparent;
			this.btnPrototipo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrototipo.Location = new System.Drawing.Point(503, 210);
			this.btnPrototipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPrototipo.Name = "btnPrototipo";
			this.btnPrototipo.Size = new System.Drawing.Size(260, 69);
			this.btnPrototipo.TabIndex = 2;
			this.btnPrototipo.Text = "Prototipos";
			this.btnPrototipo.UseVisualStyleBackColor = false;
			this.btnPrototipo.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRegresar.Location = new System.Drawing.Point(7, 9);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(49, 32);
			this.btnRegresar.TabIndex = 5;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// ElegirAccion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Cornsilk;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.elejiraccion;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(923, 454);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnPrototipo);
			this.Controls.Add(this.btnMaterial);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "ElegirAccion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ElegirAccion";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElegirAccion_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMaterial;
		private System.Windows.Forms.Button btnPrototipo;
		private System.Windows.Forms.Button btnRegresar;
	}
}