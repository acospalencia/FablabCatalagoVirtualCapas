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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnTexto = new System.Windows.Forms.Button();
            this.lblVer = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnTexto);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 157);
            this.panel1.TabIndex = 1;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(602, 303);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(103, 13);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Administrar Catalogo";
            // 
            // btnTexto
            // 
            this.btnTexto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTexto.Font = new System.Drawing.Font("Noto Serif Armenian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnTexto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTexto.Location = new System.Drawing.Point(133, 15);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(526, 77);
            this.btnTexto.TabIndex = 0;
            this.btnTexto.Text = "Bienvenido al catalogo digital de prototipos de Fablab ESFE";
            this.btnTexto.UseVisualStyleBackColor = false;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(82, 303);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(120, 13);
            this.lblVer.TabIndex = 3;
            this.lblVer.Text = "Ver listado de prototipos";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(85, 361);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(117, 40);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ingresar";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(605, 361);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 40);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnIngresar;
    }
}