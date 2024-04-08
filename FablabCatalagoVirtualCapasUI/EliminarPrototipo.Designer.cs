namespace FablabCatalagoVirtualCapasUI
{
    partial class EliminarPrototipo
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
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.lblBuscarPrototipo = new System.Windows.Forms.Label();
			this.btnLupa = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.dgVer = new System.Windows.Forms.DataGridView();
			this.txtId = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgVer)).BeginInit();
			this.SuspendLayout();
			// 
			// txtbuscar
			// 
			this.txtbuscar.Location = new System.Drawing.Point(260, 62);
			this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtbuscar.Multiline = true;
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(287, 30);
			this.txtbuscar.TabIndex = 1;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.btnEliminar;
			this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
			this.btnEliminar.Location = new System.Drawing.Point(716, 202);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(77, 85);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// lblBuscarPrototipo
			// 
			this.lblBuscarPrototipo.AutoSize = true;
			this.lblBuscarPrototipo.BackColor = System.Drawing.Color.Transparent;
			this.lblBuscarPrototipo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscarPrototipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblBuscarPrototipo.Location = new System.Drawing.Point(241, 30);
			this.lblBuscarPrototipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBuscarPrototipo.Name = "lblBuscarPrototipo";
			this.lblBuscarPrototipo.Size = new System.Drawing.Size(319, 31);
			this.lblBuscarPrototipo.TabIndex = 3;
			this.lblBuscarPrototipo.Text = "Buscar prototipo a eliminar:";
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
			this.btnLupa.Location = new System.Drawing.Point(559, 57);
			this.btnLupa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLupa.Name = "btnLupa";
			this.btnLupa.Size = new System.Drawing.Size(56, 39);
			this.btnLupa.TabIndex = 4;
			this.btnLupa.UseVisualStyleBackColor = false;
			this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
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
			this.btnRegresar.Location = new System.Drawing.Point(0, 2);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(49, 39);
			this.btnRegresar.TabIndex = 5;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// dgVer
			// 
			this.dgVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgVer.Location = new System.Drawing.Point(16, 100);
			this.dgVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgVer.Name = "dgVer";
			this.dgVer.RowHeadersWidth = 51;
			this.dgVer.Size = new System.Drawing.Size(692, 306);
			this.dgVer.TabIndex = 6;
			this.dgVer.SelectionChanged += new System.EventHandler(this.dgVer_SelectionChanged);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(751, 2);
			this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 22);
			this.txtId.TabIndex = 7;
			this.txtId.Visible = false;
			// 
			// EliminarPrototipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.backgroundEliminar;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(809, 421);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.dgVer);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnLupa);
			this.Controls.Add(this.lblBuscarPrototipo);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.txtbuscar);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "EliminarPrototipo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EliminarPrototipo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarPrototipo_FormClosing);
			this.Load += new System.EventHandler(this.EliminarPrototipo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgVer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBuscarPrototipo;
        private System.Windows.Forms.Button btnLupa;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgVer;
		private System.Windows.Forms.TextBox txtId;
	}
}