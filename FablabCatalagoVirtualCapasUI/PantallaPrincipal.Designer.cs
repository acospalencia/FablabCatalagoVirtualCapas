namespace FablabCatalagoVirtualCapasUI
{
    partial class PantallaPrincipal
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

			this.label1 = new System.Windows.Forms.Label();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnVer = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(11, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(381, 126);
			this.label1.TabIndex = 6;
			this.label1.Text = "Bienvenido al catalogo \r\ndigital de prototipos\r\n de FabLab ESFE.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.MediumOrchid;
			this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnIngresar.FlatAppearance.BorderSize = 2;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.Location = new System.Drawing.Point(72, 308);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(253, 41);
			this.btnIngresar.TabIndex = 5;
			this.btnIngresar.Text = "Administrar Catalogo";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.btnVer);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnIngresar);
			this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Location = new System.Drawing.Point(388, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(416, 445);
			this.panel1.TabIndex = 7;
			// 
			// btnVer
			// 
			this.btnVer.BackColor = System.Drawing.Color.MediumOrchid;
			this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnVer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnVer.FlatAppearance.BorderSize = 2;
			this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVer.ForeColor = System.Drawing.Color.Snow;
			this.btnVer.Location = new System.Drawing.Point(72, 197);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(253, 41);
			this.btnVer.TabIndex = 5;
			this.btnVer.Text = "Ver listado de prototipos\r\n\r\n";
			this.btnVer.UseVisualStyleBackColor = false;
			this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::FablabCatalagoVirtualCapasUI.Properties.Resources.logoFablab;
			this.pictureBox1.Location = new System.Drawing.Point(72, 198);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(240, 189);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// PantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.BackgroundMain;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 440);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "PantallaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PantallaPrincipal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
			this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVer;
    }
}