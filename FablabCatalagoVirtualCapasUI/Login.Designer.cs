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
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblClave = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(16, 247);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(141, 55);
			this.btnRegresar.TabIndex = 4;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(343, 247);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(141, 55);
			this.btnIngresar.TabIndex = 5;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
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
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(383, 58);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inciar sesion para poder modificar \r\nlos registros";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(72, 112);
			this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(79, 25);
			this.lblUsuario.TabIndex = 7;
			this.lblUsuario.Text = "Usuario";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(227, 112);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsuario.Multiline = true;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(211, 36);
			this.txtUsuario.TabIndex = 9;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(227, 171);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(211, 36);
			this.txtPassword.TabIndex = 10;
			// 
			// lblClave
			// 
			this.lblClave.AutoSize = true;
			this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClave.Location = new System.Drawing.Point(72, 183);
			this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(63, 25);
			this.lblClave.TabIndex = 8;
			this.lblClave.Text = "Clave";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(500, 318);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblClave);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.btnRegresar);
			this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblClave;
	}
}