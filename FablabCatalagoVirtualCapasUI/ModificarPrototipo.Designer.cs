using System.Windows.Forms;

namespace FablabCatalagoVirtualCapasUI
{
    partial class ModificarPrototipo
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
			System.Windows.Forms.Label lblPrecio;
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblMaterial = new System.Windows.Forms.Label();
			this.lblTiempo = new System.Windows.Forms.Label();
			this.txtTiempo = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblRegresar = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgListado = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			this.cbMaterial = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			lblPrecio = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPrecio
			// 
			lblPrecio.AutoSize = true;
			lblPrecio.BackColor = System.Drawing.Color.Transparent;
			lblPrecio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			lblPrecio.Location = new System.Drawing.Point(16, 238);
			lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblPrecio.Name = "lblPrecio";
			lblPrecio.Size = new System.Drawing.Size(62, 22);
			lblPrecio.TabIndex = 3;
			lblPrecio.Text = "Precio";
			lblPrecio.Click += new System.EventHandler(this.label3_Click);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.BackColor = System.Drawing.Color.Transparent;
			this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblNombre.Location = new System.Drawing.Point(11, 135);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(183, 22);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre del Prototipo";
			// 
			// lblMaterial
			// 
			this.lblMaterial.AutoSize = true;
			this.lblMaterial.BackColor = System.Drawing.Color.Transparent;
			this.lblMaterial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaterial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblMaterial.Location = new System.Drawing.Point(12, 188);
			this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMaterial.Name = "lblMaterial";
			this.lblMaterial.Size = new System.Drawing.Size(192, 22);
			this.lblMaterial.TabIndex = 2;
			this.lblMaterial.Text = "Tipo de material usado";
			// 
			// lblTiempo
			// 
			this.lblTiempo.AutoSize = true;
			this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
			this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTiempo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTiempo.Location = new System.Drawing.Point(16, 286);
			this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTiempo.Name = "lblTiempo";
			this.lblTiempo.Size = new System.Drawing.Size(147, 22);
			this.lblTiempo.TabIndex = 4;
			this.lblTiempo.Text = "Tiempo invertido";
			// 
			// txtTiempo
			// 
			this.txtTiempo.Location = new System.Drawing.Point(272, 284);
			this.txtTiempo.Margin = new System.Windows.Forms.Padding(4);
			this.txtTiempo.Name = "txtTiempo";
			this.txtTiempo.Size = new System.Drawing.Size(132, 22);
			this.txtTiempo.TabIndex = 5;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(272, 239);
			this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(132, 22);
			this.txtPrecio.TabIndex = 6;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(272, 137);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(132, 22);
			this.txtNombre.TabIndex = 7;
			// 
			// lblRegresar
			// 
			this.lblRegresar.AutoSize = true;
			this.lblRegresar.Location = new System.Drawing.Point(120, 75);
			this.lblRegresar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRegresar.Name = "lblRegresar";
			this.lblRegresar.Size = new System.Drawing.Size(0, 16);
			this.lblRegresar.TabIndex = 8;
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.Capa_23;
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnRegresar.Location = new System.Drawing.Point(1, 4);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(49, 39);
			this.btnRegresar.TabIndex = 9;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 100);
			this.panel1.TabIndex = 0;
			// 
			// dgListado
			// 
			this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgListado.Location = new System.Drawing.Point(457, 98);
			this.dgListado.Margin = new System.Windows.Forms.Padding(4);
			this.dgListado.Name = "dgListado";
			this.dgListado.RowHeadersWidth = 51;
			this.dgListado.Size = new System.Drawing.Size(468, 379);
			this.dgListado.TabIndex = 10;
			this.dgListado.SelectionChanged += new System.EventHandler(this.dgListado_SelectionChanged);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.Boton_submit;
			this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnModificar.Location = new System.Drawing.Point(124, 346);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(176, 59);
			this.btnModificar.TabIndex = 11;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// cbMaterial
			// 
			this.cbMaterial.FormattingEnabled = true;
			this.cbMaterial.Location = new System.Drawing.Point(272, 190);
			this.cbMaterial.Margin = new System.Windows.Forms.Padding(4);
			this.cbMaterial.Name = "cbMaterial";
			this.cbMaterial.Size = new System.Drawing.Size(132, 24);
			this.cbMaterial.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(452, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 22);
			this.label1.TabIndex = 13;
			this.label1.Text = "Buscar por Nombre";
			// 
			// txtbuscar
			// 
			this.txtbuscar.Location = new System.Drawing.Point(659, 42);
			this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
			this.txtbuscar.Multiline = true;
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(204, 24);
			this.txtbuscar.TabIndex = 14;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(1, 455);
			this.txtId.Margin = new System.Windows.Forms.Padding(4);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(132, 22);
			this.txtId.TabIndex = 15;
			this.txtId.Visible = false;
			// 
			// ModificarPrototipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.Presentación_Proyecto_de_Negocios_Moderno_Azul1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(941, 492);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbMaterial);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.dgListado);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.lblRegresar);
			this.Controls.Add(lblPrecio);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.lblTiempo);
			this.Controls.Add(this.txtTiempo);
			this.Controls.Add(this.lblMaterial);
			this.Controls.Add(this.lblNombre);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "ModificarPrototipo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ModificarPrototipo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarPrototipo_FormClosing);
			this.Load += new System.EventHandler(this.ModificarPrototipo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMaterial;
		private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
		private Panel panel1;
		private System.Windows.Forms.Label lblRegresar;
        private System.Windows.Forms.Button btnRegresar;
		private DataGridView dgListado;
		private Button btnModificar;
		private ComboBox cbMaterial;
		private Label label1;
		private TextBox txtbuscar;
		private TextBox txtId;
	}

        //private System.Windows.Forms.Panel panel1;
		//private System.Windows.Forms.Button btnRegresar;
	}

