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
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(201, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Que seccion desea administrar";
			// 
			// btnMaterial
			// 
			this.btnMaterial.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaterial.Location = new System.Drawing.Point(120, 171);
			this.btnMaterial.Name = "btnMaterial";
			this.btnMaterial.Size = new System.Drawing.Size(140, 56);
			this.btnMaterial.TabIndex = 1;
			this.btnMaterial.Text = "Materiales";
			this.btnMaterial.UseVisualStyleBackColor = true;
			this.btnMaterial.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnPrototipo
			// 
			this.btnPrototipo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrototipo.Location = new System.Drawing.Point(385, 171);
			this.btnPrototipo.Name = "btnPrototipo";
			this.btnPrototipo.Size = new System.Drawing.Size(140, 56);
			this.btnPrototipo.TabIndex = 2;
			this.btnPrototipo.Text = "Prototipos";
			this.btnPrototipo.UseVisualStyleBackColor = true;
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
			this.btnRegresar.Location = new System.Drawing.Point(5, 7);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(37, 26);
			this.btnRegresar.TabIndex = 5;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// ElegirAccion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(692, 369);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnPrototipo);
			this.Controls.Add(this.btnMaterial);
			this.Controls.Add(this.label1);
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