namespace FablabCatalagoVirtualCapasUI
{
    partial class ModificarRegistro
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
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(346, 53);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(381, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modificar registros de usuarios";
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.editar__1_;
			this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.ForeColor = System.Drawing.Color.Transparent;
			this.btnModificar.Location = new System.Drawing.Point(460, 215);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(109, 89);
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
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(718, 221);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(101, 85);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.FlechaAtras;
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.Location = new System.Drawing.Point(3, 5);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(52, 43);
			this.btnRegresar.TabIndex = 3;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
			this.btnIngresar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.btnIngresar;
			this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.ForeColor = System.Drawing.Color.Transparent;
			this.btnIngresar.Location = new System.Drawing.Point(246, 217);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(92, 85);
			this.btnIngresar.TabIndex = 4;
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// ModificarRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.Presentación_Proyecto_de_Negocios_Moderno_Azul__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1067, 542);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.DarkGray;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ModificarRegistro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ModificarRegistro";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarRegistro_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnIngresar;
    }
}