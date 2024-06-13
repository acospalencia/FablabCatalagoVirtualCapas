namespace FablabCatalagoVirtualCapasUI
{
    partial class ActualizarMateriales
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarMateriales));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbTipoMaterial = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtY = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtZ = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtX = new System.Windows.Forms.TextBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.dgMaterial = new System.Windows.Forms.DataGridView();
			this.btnLupa = new System.Windows.Forms.Button();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtIdTipo = new System.Windows.Forms.TextBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgMaterial)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRegresar.FlatAppearance.BorderSize = 0;
			this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegresar.Location = new System.Drawing.Point(6, 8);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(38, 37);
			this.btnRegresar.TabIndex = 29;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Controls.Add(this.cbTipoMaterial);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtY);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.txtPrecio);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.txtZ);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.txtX);
			this.panel2.Controls.Add(this.btnModificar);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Location = new System.Drawing.Point(130, -3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(375, 604);
			this.panel2.TabIndex = 43;
			// 
			// cbTipoMaterial
			// 
			this.cbTipoMaterial.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.cbTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoMaterial.Enabled = false;
			this.cbTipoMaterial.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTipoMaterial.FormattingEnabled = true;
			this.cbTipoMaterial.Location = new System.Drawing.Point(51, 179);
			this.cbTipoMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbTipoMaterial.Name = "cbTipoMaterial";
			this.cbTipoMaterial.Size = new System.Drawing.Size(259, 27);
			this.cbTipoMaterial.TabIndex = 72;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(40, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 29);
			this.label2.TabIndex = 71;
			this.label2.Text = "Tipo Material:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(40, 354);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 29);
			this.label3.TabIndex = 69;
			this.label3.Text = "Tamaño eje Y";
			// 
			// txtY
			// 
			this.txtY.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtY.Enabled = false;
			this.txtY.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtY.Location = new System.Drawing.Point(51, 387);
			this.txtY.Multiline = true;
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(259, 29);
			this.txtY.TabIndex = 70;
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(51, 110);
			this.txtNombre.Multiline = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(260, 29);
			this.txtNombre.TabIndex = 68;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(40, 212);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 29);
			this.label6.TabIndex = 67;
			this.label6.Text = "Precio:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Location = new System.Drawing.Point(40, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 29);
			this.label7.TabIndex = 66;
			this.label7.Text = "Nombre:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtPrecio.Enabled = false;
			this.txtPrecio.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(51, 248);
			this.txtPrecio.Multiline = true;
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(262, 29);
			this.txtPrecio.TabIndex = 62;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label9.Location = new System.Drawing.Point(40, 280);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(152, 29);
			this.label9.TabIndex = 63;
			this.label9.Text = "Tamaño eje X";
			// 
			// txtZ
			// 
			this.txtZ.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtZ.Enabled = false;
			this.txtZ.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtZ.Location = new System.Drawing.Point(51, 467);
			this.txtZ.Multiline = true;
			this.txtZ.Name = "txtZ";
			this.txtZ.Size = new System.Drawing.Size(262, 29);
			this.txtZ.TabIndex = 65;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label10.Location = new System.Drawing.Point(40, 435);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(152, 29);
			this.label10.TabIndex = 61;
			this.label10.Text = "Tamaño Eje Z";
			// 
			// txtX
			// 
			this.txtX.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtX.Enabled = false;
			this.txtX.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtX.Location = new System.Drawing.Point(51, 312);
			this.txtX.Multiline = true;
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(259, 29);
			this.txtX.TabIndex = 64;
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
			this.btnModificar.Location = new System.Drawing.Point(95, 526);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(132, 48);
			this.btnModificar.TabIndex = 47;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Visible = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(27, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(351, 42);
			this.label8.TabIndex = 1;
			this.label8.Text = "Actualizar materiales";
			// 
			// dgMaterial
			// 
			this.dgMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMaterial.Location = new System.Drawing.Point(507, 94);
			this.dgMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgMaterial.Name = "dgMaterial";
			this.dgMaterial.RowHeadersWidth = 51;
			this.dgMaterial.RowTemplate.Height = 24;
			this.dgMaterial.Size = new System.Drawing.Size(506, 503);
			this.dgMaterial.TabIndex = 45;
			this.dgMaterial.SelectionChanged += new System.EventHandler(this.dgMaterial_SelectionChanged);
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
			this.btnLupa.Location = new System.Drawing.Point(872, 32);
			this.btnLupa.Name = "btnLupa";
			this.btnLupa.Size = new System.Drawing.Size(42, 32);
			this.btnLupa.TabIndex = 47;
			this.btnLupa.UseVisualStyleBackColor = false;
			this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
			// 
			// txtbuscar
			// 
			this.txtbuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtbuscar.Location = new System.Drawing.Point(648, 37);
			this.txtbuscar.Multiline = true;
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(216, 25);
			this.txtbuscar.TabIndex = 46;
			this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(6, 569);
			this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(76, 20);
			this.txtId.TabIndex = 48;
			this.txtId.Visible = false;
			// 
			// txtIdTipo
			// 
			this.txtIdTipo.Location = new System.Drawing.Point(6, 508);
			this.txtIdTipo.Margin = new System.Windows.Forms.Padding(2);
			this.txtIdTipo.Name = "txtIdTipo";
			this.txtIdTipo.Size = new System.Drawing.Size(76, 20);
			this.txtIdTipo.TabIndex = 49;
			this.txtIdTipo.Visible = false;
			this.txtIdTipo.TextChanged += new System.EventHandler(this.txtIdTipo_TextChanged);
			// 
			// ActualizarMateriales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.IMG1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1016, 600);
			this.Controls.Add(this.txtIdTipo);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnLupa);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.dgMaterial);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnRegresar);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ActualizarMateriales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ActualizarMateriales";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActualizarMateriales_FormClosing);
			this.Load += new System.EventHandler(this.ActualizarMateriales_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgMaterial)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dgMaterial;
		private System.Windows.Forms.Button btnLupa;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.ComboBox cbTipoMaterial;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtZ;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.TextBox txtIdTipo;
	}
}