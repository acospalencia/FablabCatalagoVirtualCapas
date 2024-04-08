







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
			lblAlto = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
			this.SuspendLayout();
			// 
			// lblAlto
			// 
			lblAlto.AutoSize = true;
			lblAlto.BackColor = System.Drawing.Color.Transparent;
			lblAlto.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lblAlto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			lblAlto.Location = new System.Drawing.Point(18, 187);
			lblAlto.Name = "lblAlto";
			lblAlto.Size = new System.Drawing.Size(63, 19);
			lblAlto.TabIndex = 3;
			lblAlto.Text = "Altura:";
			lblAlto.Click += new System.EventHandler(this.label3_Click);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.BackColor = System.Drawing.Color.Transparent;
			this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblNombre.Location = new System.Drawing.Point(18, 55);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(75, 19);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblMaterial
			// 
			this.lblMaterial.AutoSize = true;
			this.lblMaterial.BackColor = System.Drawing.Color.Transparent;
			this.lblMaterial.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaterial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblMaterial.Location = new System.Drawing.Point(18, 117);
			this.lblMaterial.Name = "lblMaterial";
			this.lblMaterial.Size = new System.Drawing.Size(184, 19);
			this.lblMaterial.TabIndex = 2;
			this.lblMaterial.Text = "Tipo de material usado:";
			// 
			// lblTiempo
			// 
			this.lblTiempo.AutoSize = true;
			this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
			this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTiempo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblTiempo.Location = new System.Drawing.Point(290, 187);
			this.lblTiempo.Name = "lblTiempo";
			this.lblTiempo.Size = new System.Drawing.Size(61, 19);
			this.lblTiempo.TabIndex = 4;
			this.lblTiempo.Text = "Ancho:";
			// 
			// txtAncho
			// 
			this.txtAncho.Location = new System.Drawing.Point(294, 223);
			this.txtAncho.Name = "txtAncho";
			this.txtAncho.Size = new System.Drawing.Size(227, 20);
			this.txtAncho.TabIndex = 5;
			// 
			// txtAlto
			// 
			this.txtAlto.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlto.Location = new System.Drawing.Point(22, 216);
			this.txtAlto.Name = "txtAlto";
			this.txtAlto.Size = new System.Drawing.Size(234, 27);
			this.txtAlto.TabIndex = 6;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(22, 80);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(234, 20);
			this.txtNombre.TabIndex = 7;
			// 
			// lblRegresar
			// 
			this.lblRegresar.AutoSize = true;
			this.lblRegresar.Location = new System.Drawing.Point(90, 61);
			this.lblRegresar.Name = "lblRegresar";
			this.lblRegresar.Size = new System.Drawing.Size(0, 13);
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
			this.btnRegresar.Location = new System.Drawing.Point(12, 12);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(37, 32);
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
			this.dgListado.Location = new System.Drawing.Point(549, 117);
			this.dgListado.Name = "dgListado";
			this.dgListado.RowHeadersWidth = 51;
			this.dgListado.Size = new System.Drawing.Size(337, 348);
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
			this.btnModificar.Location = new System.Drawing.Point(22, 444);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(132, 48);
			this.btnModificar.TabIndex = 11;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// cbMaterial
			// 
			this.cbMaterial.FormattingEnabled = true;
			this.cbMaterial.Location = new System.Drawing.Point(22, 153);
			this.cbMaterial.Name = "cbMaterial";
			this.cbMaterial.Size = new System.Drawing.Size(234, 21);
			this.cbMaterial.TabIndex = 12;
			this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
			// 
			// txtbuscar
			// 
			this.txtbuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtbuscar.Location = new System.Drawing.Point(550, 73);
			this.txtbuscar.Multiline = true;
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(301, 27);
			this.txtbuscar.TabIndex = 14;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(869, 12);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 15;
			this.txtId.Visible = false;
			// 
			// txtFabricarlo
			// 
			this.txtFabricarlo.Location = new System.Drawing.Point(294, 154);
			this.txtFabricarlo.Margin = new System.Windows.Forms.Padding(2);
			this.txtFabricarlo.Name = "txtFabricarlo";
			this.txtFabricarlo.Size = new System.Drawing.Size(227, 20);
			this.txtFabricarlo.TabIndex = 26;
			this.txtFabricarlo.TextChanged += new System.EventHandler(this.txtFabricarlo_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(290, 117);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(254, 19);
			this.label8.TabIndex = 25;
			this.label8.Text = "Tiempo requeridodo para fabricarlo: ";
			// 
			// txtArmarlo
			// 
			this.txtArmarlo.Location = new System.Drawing.Point(294, 80);
			this.txtArmarlo.Margin = new System.Windows.Forms.Padding(2);
			this.txtArmarlo.Name = "txtArmarlo";
			this.txtArmarlo.Size = new System.Drawing.Size(227, 20);
			this.txtArmarlo.TabIndex = 24;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(290, 55);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(255, 19);
			this.label6.TabIndex = 23;
			this.label6.Text = "Tiempo requerido para armarlo: ";
			// 
			// txtDesign
			// 
			this.txtDesign.Location = new System.Drawing.Point(22, 286);
			this.txtDesign.Margin = new System.Windows.Forms.Padding(2);
			this.txtDesign.Name = "txtDesign";
			this.txtDesign.Size = new System.Drawing.Size(234, 20);
			this.txtDesign.TabIndex = 22;
			this.txtDesign.TextChanged += new System.EventHandler(this.txtDesign_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(18, 256);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(238, 19);
			this.label2.TabIndex = 21;
			this.label2.Text = "Tiempo requerido para diseño:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(294, 286);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(227, 95);
			this.txtDescripcion.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(290, 256);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 22);
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
			this.btnLupa.Location = new System.Drawing.Point(844, 68);
			this.btnLupa.Name = "btnLupa";
			this.btnLupa.Size = new System.Drawing.Size(42, 32);
			this.btnLupa.TabIndex = 29;
			this.btnLupa.UseVisualStyleBackColor = false;
			this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
			// 
			// ModificarPrototipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.BackgorundModificar;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(898, 504);
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
	}

        //private System.Windows.Forms.Panel panel1;
		//private System.Windows.Forms.Button btnRegresar;
	}

