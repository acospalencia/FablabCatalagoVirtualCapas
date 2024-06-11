







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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPrototipo));
			this.btnRegresar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgListado = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnLupa = new System.Windows.Forms.Button();
			this.img = new System.Windows.Forms.PictureBox();
			this.cbMaquinaria = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbIdEstado = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtX = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtFabricarlo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtArmarlo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbMaterial = new System.Windows.Forms.ComboBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtZ = new System.Windows.Forms.TextBox();
			this.txtDesign = new System.Windows.Forms.TextBox();
			this.txtY = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdMaterial = new System.Windows.Forms.TextBox();
			this.txtIdDuraciones = new System.Windows.Forms.TextBox();
			this.txtIdEstado = new System.Windows.Forms.TextBox();
			this.txtIdMaquinaria = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
			this.SuspendLayout();
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
			this.btnRegresar.Location = new System.Drawing.Point(-2, 6);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(48, 37);
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
			this.dgListado.Location = new System.Drawing.Point(595, 76);
			this.dgListado.Name = "dgListado";
			this.dgListado.RowHeadersWidth = 51;
			this.dgListado.Size = new System.Drawing.Size(456, 419);
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
			this.btnModificar.Location = new System.Drawing.Point(30, 486);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(132, 48);
			this.btnModificar.TabIndex = 11;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// txtbuscar
			// 
			this.txtbuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbuscar.Location = new System.Drawing.Point(657, 33);
			this.txtbuscar.Multiline = true;
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(301, 27);
			this.txtbuscar.TabIndex = 14;
			this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(373, 434);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 15;
			this.txtId.Visible = false;
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
			this.btnLupa.Location = new System.Drawing.Point(964, 30);
			this.btnLupa.Name = "btnLupa";
			this.btnLupa.Size = new System.Drawing.Size(57, 32);
			this.btnLupa.TabIndex = 29;
			this.btnLupa.UseVisualStyleBackColor = false;
			// 
			// img
			// 
			this.img.Location = new System.Drawing.Point(487, 378);
			this.img.Margin = new System.Windows.Forms.Padding(2);
			this.img.Name = "img";
			this.img.Size = new System.Drawing.Size(103, 104);
			this.img.TabIndex = 32;
			this.img.TabStop = false;
			this.img.Visible = false;
			// 
			// cbMaquinaria
			// 
			this.cbMaquinaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMaquinaria.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMaquinaria.FormattingEnabled = true;
			this.cbMaquinaria.Location = new System.Drawing.Point(30, 411);
			this.cbMaquinaria.Margin = new System.Windows.Forms.Padding(2);
			this.cbMaquinaria.Name = "cbMaquinaria";
			this.cbMaquinaria.Size = new System.Drawing.Size(251, 24);
			this.cbMaquinaria.TabIndex = 54;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label11.Location = new System.Drawing.Point(27, 389);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(151, 19);
			this.label11.TabIndex = 53;
			this.label11.Text = "Maquinaria Usado:";
			// 
			// cbIdEstado
			// 
			this.cbIdEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIdEstado.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbIdEstado.FormattingEnabled = true;
			this.cbIdEstado.Location = new System.Drawing.Point(30, 355);
			this.cbIdEstado.Margin = new System.Windows.Forms.Padding(2);
			this.cbIdEstado.Name = "cbIdEstado";
			this.cbIdEstado.Size = new System.Drawing.Size(251, 24);
			this.cbIdEstado.TabIndex = 52;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label10.Location = new System.Drawing.Point(27, 333);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 19);
			this.label10.TabIndex = 51;
			this.label10.Text = "Estado:";
			// 
			// txtX
			// 
			this.txtX.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtX.Location = new System.Drawing.Point(31, 189);
			this.txtX.Margin = new System.Windows.Forms.Padding(2);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(247, 23);
			this.txtX.TabIndex = 50;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label9.Location = new System.Drawing.Point(27, 165);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(87, 19);
			this.label9.TabIndex = 49;
			this.label9.Text = "Tamaño X:";
			// 
			// txtFabricarlo
			// 
			this.txtFabricarlo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFabricarlo.Location = new System.Drawing.Point(329, 189);
			this.txtFabricarlo.Margin = new System.Windows.Forms.Padding(2);
			this.txtFabricarlo.Name = "txtFabricarlo";
			this.txtFabricarlo.Size = new System.Drawing.Size(247, 23);
			this.txtFabricarlo.TabIndex = 48;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label8.Location = new System.Drawing.Point(321, 164);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(269, 19);
			this.label8.TabIndex = 47;
			this.label8.Text = "Tiempo requerido para fabricarlo: ";
			// 
			// txtArmarlo
			// 
			this.txtArmarlo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtArmarlo.Location = new System.Drawing.Point(329, 132);
			this.txtArmarlo.Margin = new System.Windows.Forms.Padding(2);
			this.txtArmarlo.Name = "txtArmarlo";
			this.txtArmarlo.Size = new System.Drawing.Size(247, 23);
			this.txtArmarlo.TabIndex = 46;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(321, 108);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(265, 20);
			this.label6.TabIndex = 45;
			this.label6.Text = "Tiempo requerido para armarlo: ";
			// 
			// cbMaterial
			// 
			this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMaterial.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMaterial.FormattingEnabled = true;
			this.cbMaterial.Location = new System.Drawing.Point(30, 132);
			this.cbMaterial.Margin = new System.Windows.Forms.Padding(2);
			this.cbMaterial.Name = "cbMaterial";
			this.cbMaterial.Size = new System.Drawing.Size(251, 24);
			this.cbMaterial.TabIndex = 44;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(325, 245);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(251, 114);
			this.txtDescripcion.TabIndex = 43;
			// 
			// txtZ
			// 
			this.txtZ.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtZ.Location = new System.Drawing.Point(30, 302);
			this.txtZ.Margin = new System.Windows.Forms.Padding(2);
			this.txtZ.Name = "txtZ";
			this.txtZ.Size = new System.Drawing.Size(247, 23);
			this.txtZ.TabIndex = 42;
			// 
			// txtDesign
			// 
			this.txtDesign.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesign.Location = new System.Drawing.Point(329, 80);
			this.txtDesign.Margin = new System.Windows.Forms.Padding(2);
			this.txtDesign.Name = "txtDesign";
			this.txtDesign.Size = new System.Drawing.Size(247, 23);
			this.txtDesign.TabIndex = 41;
			// 
			// txtY
			// 
			this.txtY.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtY.Location = new System.Drawing.Point(30, 246);
			this.txtY.Margin = new System.Windows.Forms.Padding(2);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(247, 23);
			this.txtY.TabIndex = 40;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(31, 80);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(247, 23);
			this.txtNombre.TabIndex = 39;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new System.Drawing.Point(27, 221);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 19);
			this.label7.TabIndex = 38;
			this.label7.Text = "Tamaño Y:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(325, 223);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 19);
			this.label5.TabIndex = 37;
			this.label5.Text = "Descripcion:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(27, 276);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 19);
			this.label4.TabIndex = 36;
			this.label4.Text = "Tamaño Z: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(27, 108);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 19);
			this.label3.TabIndex = 35;
			this.label3.Text = "Tipo de material usado:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(325, 57);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(260, 19);
			this.label2.TabIndex = 34;
			this.label2.Text = "Tiempo requerido para diseñarlo:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(27, 60);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 33;
			this.label1.Text = "Nombre:";
			// 
			// txtIdMaterial
			// 
			this.txtIdMaterial.Location = new System.Drawing.Point(373, 462);
			this.txtIdMaterial.Name = "txtIdMaterial";
			this.txtIdMaterial.Size = new System.Drawing.Size(100, 20);
			this.txtIdMaterial.TabIndex = 55;
			this.txtIdMaterial.Visible = false;
			this.txtIdMaterial.TextChanged += new System.EventHandler(this.txtIdMaterial_TextChanged);
			// 
			// txtIdDuraciones
			// 
			this.txtIdDuraciones.Location = new System.Drawing.Point(373, 488);
			this.txtIdDuraciones.Name = "txtIdDuraciones";
			this.txtIdDuraciones.Size = new System.Drawing.Size(100, 20);
			this.txtIdDuraciones.TabIndex = 56;
			this.txtIdDuraciones.Visible = false;
			this.txtIdDuraciones.TextChanged += new System.EventHandler(this.txtIdDuraciones_TextChanged);
			// 
			// txtIdEstado
			// 
			this.txtIdEstado.Location = new System.Drawing.Point(373, 514);
			this.txtIdEstado.Name = "txtIdEstado";
			this.txtIdEstado.Size = new System.Drawing.Size(100, 20);
			this.txtIdEstado.TabIndex = 57;
			this.txtIdEstado.Visible = false;
			this.txtIdEstado.TextChanged += new System.EventHandler(this.txtIdEstado_TextChanged);
			// 
			// txtIdMaquinaria
			// 
			this.txtIdMaquinaria.Location = new System.Drawing.Point(373, 540);
			this.txtIdMaquinaria.Name = "txtIdMaquinaria";
			this.txtIdMaquinaria.Size = new System.Drawing.Size(100, 20);
			this.txtIdMaquinaria.TabIndex = 58;
			this.txtIdMaquinaria.Visible = false;
			this.txtIdMaquinaria.TextChanged += new System.EventHandler(this.txtIdMaquinaria_TextChanged);
			// 
			// ModificarPrototipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.agregarmateriales;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1063, 589);
			this.Controls.Add(this.txtIdMaquinaria);
			this.Controls.Add(this.txtIdEstado);
			this.Controls.Add(this.txtIdDuraciones);
			this.Controls.Add(this.txtIdMaterial);
			this.Controls.Add(this.cbMaquinaria);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cbIdEstado);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtX);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtFabricarlo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtArmarlo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbMaterial);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtZ);
			this.Controls.Add(this.txtDesign);
			this.Controls.Add(this.txtY);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.img);
			this.Controls.Add(this.btnLupa);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.dgListado);
			this.Controls.Add(this.btnRegresar);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ModificarPrototipo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ModificarPrototipo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarPrototipo_FormClosing);
			this.Load += new System.EventHandler(this.ModificarPrototipo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
		private DataGridView dgListado;
		private Button btnModificar;
		private TextBox txtbuscar;
		private TextBox txtId;
		private Button btnLupa;
		private PictureBox img;
		private ComboBox cbMaquinaria;
		private Label label11;
		private ComboBox cbIdEstado;
		private Label label10;
		private TextBox txtX;
		private Label label9;
		private TextBox txtFabricarlo;
		private Label label8;
		private TextBox txtArmarlo;
		private Label label6;
		private ComboBox cbMaterial;
		private TextBox txtDescripcion;
		private TextBox txtZ;
		private TextBox txtDesign;
		private TextBox txtY;
		private TextBox txtNombre;
		private Label label7;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox txtIdMaterial;
		private TextBox txtIdDuraciones;
		private TextBox txtIdEstado;
		private TextBox txtIdMaquinaria;
	}

        //private System.Windows.Forms.Panel panel1;
		//private System.Windows.Forms.Button btnRegresar;
	}

