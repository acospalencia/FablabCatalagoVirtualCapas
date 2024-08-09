namespace FablabCatalagoVirtualCapasUI
{
    partial class AgregarPrototipo
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
			System.Windows.Forms.Button btnIngresar;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPrototipo));
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnRegresar = new System.Windows.Forms.Button();
			btnIngresar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnIngresar
			// 
			btnIngresar.BackColor = System.Drawing.Color.Transparent;
			btnIngresar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.btnIngresar;
			btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			btnIngresar.FlatAppearance.BorderSize = 0;
			btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			btnIngresar.Location = new System.Drawing.Point(16, 233);
			btnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
			btnIngresar.Name = "btnIngresar";
			btnIngresar.Size = new System.Drawing.Size(100, 97);
			btnIngresar.TabIndex = 0;
			btnIngresar.UseVisualStyleBackColor = false;
			btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
			this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(187, 233);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(116, 98);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.btnElimnar2;
			this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(368, 233);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(103, 87);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblTitulo.Location = new System.Drawing.Point(16, 133);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(446, 45);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Elija la opción  a realizar";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.backgroundPanel;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.btnRegresar);
			this.panel1.Controls.Add(this.btnEliminar);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.lblTitulo);
			this.panel1.Controls.Add(btnIngresar);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(524, 550);
			this.panel1.TabIndex = 9;
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.FlechaAtras;
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRegresar.Location = new System.Drawing.Point(-3, 7);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(64, 46);
			this.btnRegresar.TabIndex = 5;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// AgregarPrototipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.BackgroundAgregar;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1067, 542);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "AgregarPrototipo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AgregarPrototipo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnRegresar;
	}
}