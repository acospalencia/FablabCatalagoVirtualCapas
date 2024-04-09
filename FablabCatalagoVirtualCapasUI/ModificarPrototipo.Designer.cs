







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
			System.Windows.Forms.Label lblAlto;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPrototipo));
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblMaterial = new System.Windows.Forms.Label();
			this.lblTiempo = new System.Windows.Forms.Label();
			this.txtAncho = new System.Windows.Forms.TextBox();
			this.txtAlto = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblRegresar = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgListado = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			this.cbMaterial = new System.Windows.Forms.ComboBox();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtFabricarlo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtArmarlo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDesign = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnLupa = new System.Windows.Forms.Button();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			lblAlto = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
			this.SuspendLayout();
			// 
			// lblAlto
			// 
			lblAlto.AutoSize = true;
			lblAlto.BackColor = System.Drawing.Color.Transparent;
			lblAlto.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblAlto.ForeColor = System.Drawing.SystemColors.ButtonFace;
			lblAlto.Location = new System.Drawing.Point(24, 230);
			lblAlto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblAlto.Name = "lblAlto";
			lblAlto.Size = new System.Drawing.Size(79, 25);
			lblAlto.TabIndex = 3;
			lblAlto.Text = "Altura:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.BackColor = System.Drawing.Color.Transparent;
			this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblNombre.Location = new System.Drawing.Point(24, 68);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(95, 25);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblMaterial
			// 
			this.lblMaterial.AutoSize = true;
			this.lblMaterial.BackColor = System.Drawing.Color.Transparent;
			this.lblMaterial.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaterial.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblMaterial.Location = new System.Drawing.Point(24, 144);
			this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMaterial.Name = "lblMaterial";
			this.lblMaterial.Size = new System.Drawing.Size(236, 25);
			this.lblMaterial.TabIndex = 2;
			this.lblMaterial.Text = "Tipo de material usado:";
			// 
			// lblTiempo
			// 
			this.lblTiempo.AutoSize = true;
			this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
			this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTiempo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTiempo.Location = new System.Drawing.Point(377, 230);
			this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTiempo.Name = "lblTiempo";
			this.lblTiempo.Size = new System.Drawing.Size(79, 25);
			this.lblTiempo.TabIndex = 4;
			this.lblTiempo.Text = "Ancho:";
			// 
			// txtAncho
			// 
			this.txtAncho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAncho.Location = new System.Drawing.Point(382, 274);
			this.txtAncho.Margin = new System.Windows.Forms.Padding(4);
			this.txtAncho.Name = "txtAncho";
			this.txtAncho.Size = new System.Drawing.Size(301, 27);
			this.txtAncho.TabIndex = 5;
			// 
			// txtAlto
			// 
			this.txtAlto.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlto.Location = new System.Drawing.Point(29, 266);
			this.txtAlto.Margin = new System.Windows.Forms.Padding(4);
			this.txtAlto.Name = "txtAlto";
			this.txtAlto.Size = new System.Drawing.Size(311, 27);
			this.txtAlto.TabIndex = 6;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(29, 98);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(311, 27);
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
			this.btnRegresar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.FlechaAtras;
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnRegresar.Location = new System.Drawing.Point(-2, 7);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(64, 46);
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
			this.dgListado.Location = new System.Drawing.Point(774, 144);
			this.dgListado.Margin = new System.Windows.Forms.Padding(4);
			this.dgListado.Name = "dgListado";
			this.dgListado.RowHeadersWidth = 51;
			this.dgListado.Size = new System.Drawing.Size(449, 428);
			this.dgListado.TabIndex = 10;
			this.dgListado.SelectionChanged += new System.EventHandler(this.dgListado_SelectionChanged);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.Botonsubmit;
			this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnModificar.Location = new System.Drawing.Point(29, 532);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(176, 59);
			this.btnModificar.TabIndex = 11;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// cbMaterial
			// 
			this.cbMaterial.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMaterial.FormattingEnabled = true;
			this.cbMaterial.Location = new System.Drawing.Point(29, 188);
			this.cbMaterial.Margin = new System.Windows.Forms.Padding(4);
			this.cbMaterial.Name = "cbMaterial";
			this.cbMaterial.Size = new System.Drawing.Size(311, 27);
			this.cbMaterial.TabIndex = 12;
			// 
			// txtbuscar
			// 
			this.txtbuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbuscar.Location = new System.Drawing.Point(774, 93);
			this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
			this.txtbuscar.Multiline = true;
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(400, 32);
			this.txtbuscar.TabIndex = 14;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(1159, 15);
			this.txtId.Margin = new System.Windows.Forms.Padding(4);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(132, 22);
			this.txtId.TabIndex = 15;
			this.txtId.Visible = false;
			// 
			// txtFabricarlo
			// 
			this.txtFabricarlo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFabricarlo.Location = new System.Drawing.Point(382, 190);
			this.txtFabricarlo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFabricarlo.Name = "txtFabricarlo";
			this.txtFabricarlo.Size = new System.Drawing.Size(301, 27);
			this.txtFabricarlo.TabIndex = 26;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label8.Location = new System.Drawing.Point(377, 144);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(358, 25);
			this.label8.TabIndex = 25;
			this.label8.Text = "Tiempo requeridodo para fabricarlo:";
			// 
			// txtArmarlo
			// 
			this.txtArmarlo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtArmarlo.Location = new System.Drawing.Point(382, 98);
			this.txtArmarlo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtArmarlo.Name = "txtArmarlo";
			this.txtArmarlo.Size = new System.Drawing.Size(301, 27);
			this.txtArmarlo.TabIndex = 24;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(377, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(324, 25);
			this.label6.TabIndex = 23;
			this.label6.Text = "Tiempo requerido para armarlo: ";
			// 
			// txtDesign
			// 
			this.txtDesign.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesign.Location = new System.Drawing.Point(29, 352);
			this.txtDesign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDesign.Name = "txtDesign";
			this.txtDesign.Size = new System.Drawing.Size(311, 27);
			this.txtDesign.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(24, 315);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(303, 25);
			this.label2.TabIndex = 21;
			this.label2.Text = "Tiempo requerido para diseño:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(382, 352);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(301, 116);
			this.txtDescripcion.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(377, 315);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 25);
			this.label5.TabIndex = 27;
			this.label5.Text = "Descripcion:";
			// 
			// btnLupa
			// 
			this.btnLupa.BackColor = System.Drawing.Color.Transparent;
			this.btnLupa.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.btnBuscar;
			this.btnLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLupa.FlatAppearance.BorderSize = 0;
			this.btnLupa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnLupa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLupa.Location = new System.Drawing.Point(1166, 87);
			this.btnLupa.Margin = new System.Windows.Forms.Padding(4);
			this.btnLupa.Name = "btnLupa";
			this.btnLupa.Size = new System.Drawing.Size(56, 39);
			this.btnLupa.TabIndex = 29;
			this.btnLupa.UseVisualStyleBackColor = false;
			this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
			// 
			// txtAutor
			// 
			this.txtAutor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAutor.Location = new System.Drawing.Point(32, 412);
			this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(308, 27);
			this.txtAutor.TabIndex = 31;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label9.Location = new System.Drawing.Point(27, 383);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 25);
			this.label9.TabIndex = 30;
			this.label9.Text = "Autor:";
			// 
			// ModificarPrototipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1237, 620);
			this.Controls.Add(this.txtAutor);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnLupa);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtFabricarlo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtArmarlo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDesign);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.cbMaterial);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.dgListado);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.lblRegresar);
			this.Controls.Add(lblAlto);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtAlto);
			this.Controls.Add(this.lblTiempo);
			this.Controls.Add(this.txtAncho);
			this.Controls.Add(this.lblMaterial);
			this.Controls.Add(this.lblNombre);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtNombre;
		private Panel panel1;
		private System.Windows.Forms.Label lblRegresar;
        private System.Windows.Forms.Button btnRegresar;
		private DataGridView dgListado;
		private Button btnModificar;
		private ComboBox cbMaterial;
		private TextBox txtbuscar;
		private TextBox txtId;
		private TextBox txtFabricarlo;
		private Label label8;
		private TextBox txtArmarlo;
		private Label label6;
		private TextBox txtDesign;
		private Label label2;
		private TextBox txtDescripcion;
		private Label label5;
		private Button btnLupa;
		private TextBox txtAutor;
		private Label label9;
	}

        //private System.Windows.Forms.Panel panel1;
		//private System.Windows.Forms.Button btnRegresar;
	}

