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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblAdmin = new System.Windows.Forms.Label();
			this.lblVer = new System.Windows.Forms.Label();
			this.btnVer = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-5, -4);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1075, 133);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(59, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(882, 38);
			this.label1.TabIndex = 6;
			this.label1.Text = "Bienvenido al catalogo digital de prototipos de Fablab ESFE";
			// 
			// lblAdmin
			// 
			this.lblAdmin.AutoSize = true;
			this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdmin.Location = new System.Drawing.Point(684, 234);
			this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAdmin.Name = "lblAdmin";
			this.lblAdmin.Size = new System.Drawing.Size(237, 29);
			this.lblAdmin.TabIndex = 2;
			this.lblAdmin.Text = "Administrar Catalogo";
			// 
			// lblVer
			// 
			this.lblVer.AutoSize = true;
			this.lblVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVer.Location = new System.Drawing.Point(148, 234);
			this.lblVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVer.Name = "lblVer";
			this.lblVer.Size = new System.Drawing.Size(275, 29);
			this.lblVer.TabIndex = 3;
			this.lblVer.Text = "Ver listado de prototipos";
			// 
			// btnVer
			// 
			this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVer.Location = new System.Drawing.Point(175, 287);
			this.btnVer.Margin = new System.Windows.Forms.Padding(4);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(201, 60);
			this.btnVer.TabIndex = 4;
			this.btnVer.Text = "Ingresar";
			this.btnVer.UseVisualStyleBackColor = true;
			// 
			// btnIngresar
			// 
			this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.Location = new System.Drawing.Point(699, 287);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(201, 60);
			this.btnIngresar.TabIndex = 5;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// PantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.lblVer);
			this.Controls.Add(this.lblAdmin);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "PantallaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PantallaPrincipal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Label label1;
	}
}