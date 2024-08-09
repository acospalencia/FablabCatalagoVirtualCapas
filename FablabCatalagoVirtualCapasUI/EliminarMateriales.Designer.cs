namespace FablabCatalagoVirtualCapasUI
{
    partial class EliminarMateriales
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
			this.dgVer = new System.Windows.Forms.DataGridView();
			this.btnLupa = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgVer)).BeginInit();
			this.SuspendLayout();
			// 
			// dgVer
			// 
			this.dgVer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgVer.Location = new System.Drawing.Point(31, 135);
			this.dgVer.Name = "dgVer";
			this.dgVer.RowHeadersWidth = 51;
			this.dgVer.Size = new System.Drawing.Size(892, 315);
			this.dgVer.TabIndex = 10;
			this.dgVer.SelectionChanged += new System.EventHandler(this.dgVer_SelectionChanged);
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
			this.btnLupa.Location = new System.Drawing.Point(706, 64);
			this.btnLupa.Name = "btnLupa";
			this.btnLupa.Size = new System.Drawing.Size(56, 42);
			this.btnLupa.TabIndex = 9;
			this.btnLupa.UseVisualStyleBackColor = false;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.btnEliminar;
			this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Enabled = false;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
			this.btnEliminar.Location = new System.Drawing.Point(944, 257);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 82);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// txtbuscar
			// 
			this.txtbuscar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbuscar.Location = new System.Drawing.Point(273, 70);
			this.txtbuscar.Multiline = true;
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(418, 28);
			this.txtbuscar.TabIndex = 7;
			this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
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
			this.btnRegresar.Location = new System.Drawing.Point(3, 3);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(37, 32);
			this.btnRegresar.TabIndex = 11;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(971, 10);
			this.txtId.Margin = new System.Windows.Forms.Padding(2);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(76, 20);
			this.txtId.TabIndex = 12;
			this.txtId.Visible = false;
			// 
			// EliminarMateriales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FablabCatalagoVirtualCapasUI.Properties.Resources.agregarmateriales;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1036, 541);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.dgVer);
			this.Controls.Add(this.btnLupa);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.txtbuscar);
			this.Name = "EliminarMateriales";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EliminarMateriales";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarMateriales_FormClosing);
			this.Load += new System.EventHandler(this.EliminarMateriales_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgVer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVer;
        private System.Windows.Forms.Button btnLupa;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtId;
    }
}