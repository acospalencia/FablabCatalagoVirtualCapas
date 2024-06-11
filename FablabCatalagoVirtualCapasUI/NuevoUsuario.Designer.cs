namespace FablabCatalagoVirtualCapasUI
{
    partial class NuevoUsuario
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(165, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Agregar Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(209, 108);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 27);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nombre:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(193, 229);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 27);
			this.label3.TabIndex = 4;
			this.label3.Text = "Contraseña:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(171, 138);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(180, 22);
			this.txtNombre.TabIndex = 6;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(171, 258);
			this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(180, 22);
			this.txtContraseña.TabIndex = 7;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.Botonsubmit;
			this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAgregar.FlatAppearance.BorderSize = 0;
			this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAgregar.Location = new System.Drawing.Point(383, 321);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(148, 68);
			this.btnAgregar.TabIndex = 11;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.FlechaAtras;
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.Location = new System.Drawing.Point(-1, 1);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(45, 34);
			this.btnRegresar.TabIndex = 12;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// NuevoUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.BackgorundModificar;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(596, 415);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "NuevoUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NuevoUsuario";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegresar;
    }
}