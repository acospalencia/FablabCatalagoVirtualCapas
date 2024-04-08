namespace FablabCatalagoVirtualCapasUI
{
	partial class IngresarPrototipo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.imgPrototipo = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArmarlo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFabricarlo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrototipo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.FlechaAtras;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;

            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;

            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo requerido para diseñarlo:";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;

            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(288, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de material usado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;

            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 19);

            this.label4.TabIndex = 4;
            this.label4.Text = "Altura de el prototipo finalizado: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;

            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(292, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion:";
            this.label5.Click += new System.EventHandler(this.label5_Click);

            // 
            // btnSubir
            // 
            this.btnSubir.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.btnSubir.Location = new System.Drawing.Point(662, 336);

            this.btnSubir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(136, 33);
            this.btnSubir.TabIndex = 7;
            this.btnSubir.Text = "Subir Imagen";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // imgPrototipo
            // 

            this.imgPrototipo.Location = new System.Drawing.Point(571, 5);
            this.imgPrototipo.Margin = new System.Windows.Forms.Padding(2);
            this.imgPrototipo.Name = "imgPrototipo";
            this.imgPrototipo.Size = new System.Drawing.Size(305, 321);

            this.imgPrototipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPrototipo.TabIndex = 8;
            this.imgPrototipo.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnConfirmar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.btnConfirmar.Location = new System.Drawing.Point(793, 385);

            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 44);
            this.btnConfirmar.TabIndex = 9;

            this.btnConfirmar.Text = "Confirmar Datos";

            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;

            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(11, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 19);

            this.label7.TabIndex = 10;
            this.label7.Text = "Ancho de el prototipo finalizado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.txtNombre.Location = new System.Drawing.Point(15, 55);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 22);

            this.txtNombre.TabIndex = 11;
            // 
            // txtAncho
            // 

            this.txtAncho.Location = new System.Drawing.Point(15, 117);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(2);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(247, 20);

            this.txtAncho.TabIndex = 12;
            // 
            // txtTiempo
            // 

            this.txtTiempo.Location = new System.Drawing.Point(15, 235);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(247, 20);

            this.txtTiempo.TabIndex = 13;
            // 
            // txtAlto
            // 

            this.txtAlto.Location = new System.Drawing.Point(15, 173);
            this.txtAlto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(247, 20);

            this.txtAlto.TabIndex = 14;
            // 
            // txtDescripcion
            // 

            this.txtDescripcion.Location = new System.Drawing.Point(292, 235);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(251, 114);

            this.txtDescripcion.TabIndex = 15;
            // 
            // cbMaterial
            // 
            this.cbMaterial.FormattingEnabled = true;

            this.cbMaterial.Location = new System.Drawing.Point(292, 56);
            this.cbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(251, 21);

            this.cbMaterial.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;

            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(288, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tiempo requerido para armarlo: ";
            // 
            // txtArmarlo
            // 
            this.txtArmarlo.Location = new System.Drawing.Point(296, 117);
            this.txtArmarlo.Margin = new System.Windows.Forms.Padding(2);
            this.txtArmarlo.Name = "txtArmarlo";
            this.txtArmarlo.Size = new System.Drawing.Size(247, 20);
            this.txtArmarlo.TabIndex = 18;
            this.txtArmarlo.TextChanged += new System.EventHandler(this.txtArmarlo_TextChanged);

            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;

            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(288, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tiempo requerido para fabricarlo: ";
            // 
            // txtFabricarlo
            // 
            this.txtFabricarlo.Location = new System.Drawing.Point(296, 173);
            this.txtFabricarlo.Margin = new System.Windows.Forms.Padding(2);
            this.txtFabricarlo.Name = "txtFabricarlo";
            this.txtFabricarlo.Size = new System.Drawing.Size(247, 20);

            this.txtFabricarlo.TabIndex = 20;
            // 
            // IngresarPrototipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.BackgroundIngresar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.ClientSize = new System.Drawing.Size(887, 428);

            this.Controls.Add(this.txtFabricarlo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtArmarlo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.imgPrototipo);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "IngresarPrototipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarPrototipo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngresarPrototipo_FormClosing);
            this.Load += new System.EventHandler(this.IngresarPrototipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPrototipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSubir;
		private System.Windows.Forms.PictureBox imgPrototipo;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtAncho;
		private System.Windows.Forms.TextBox txtTiempo;
		private System.Windows.Forms.TextBox txtAlto;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.ComboBox cbMaterial;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtArmarlo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtFabricarlo;
	}
}