namespace FablabCatalagoVirtualCapasUI
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.btnIngresar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Location = new System.Drawing.Point(351, 361);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(349, 42);
			this.btnIngresar.TabIndex = 5;
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(504, 87);
			this.panel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(461, 172);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Iniciar sesion";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
			this.txtUsuario.Location = new System.Drawing.Point(351, 229);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtUsuario.Multiline = true;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(348, 47);
			this.txtUsuario.TabIndex = 9;
			this.txtUsuario.Text = "Usuario";
			this.txtUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsuario_MouseClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRegresar.Location = new System.Drawing.Point(4, 10);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(49, 32);
			this.btnRegresar.TabIndex = 4;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(351, 295);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(348, 47);
			this.txtPassword.TabIndex = 10;
			this.txtPassword.Text = "Contraseña";
			this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.imagelogin;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1075, 546);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblClave);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.btnRegresar);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
    }
}