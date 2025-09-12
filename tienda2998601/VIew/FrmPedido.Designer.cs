namespace tienda2998601.VIew
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.gbEncabezado = new System.Windows.Forms.GroupBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.lalbel3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtvProductos = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbEncabezado.SuspendLayout();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEncabezado
            // 
            this.gbEncabezado.Controls.Add(this.btnSeleccion);
            this.gbEncabezado.Controls.Add(this.cbxEstado);
            this.gbEncabezado.Controls.Add(this.dtpFecha);
            this.gbEncabezado.Controls.Add(this.cbxClientes);
            this.gbEncabezado.Controls.Add(this.lalbel3);
            this.gbEncabezado.Controls.Add(this.label2);
            this.gbEncabezado.Controls.Add(this.label1);
            this.gbEncabezado.Location = new System.Drawing.Point(26, 18);
            this.gbEncabezado.Name = "gbEncabezado";
            this.gbEncabezado.Size = new System.Drawing.Size(988, 164);
            this.gbEncabezado.TabIndex = 0;
            this.gbEncabezado.TabStop = false;
            this.gbEncabezado.Text = "Encabezado";
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccion.Location = new System.Drawing.Point(333, 97);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(355, 47);
            this.btnSeleccion.TabIndex = 6;
            this.btnSeleccion.Text = "SELECCIONAR PRODUCTOS";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cbxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "En Proceso",
            "Devuelto",
            "Cerrado",
            "Finalizado"});
            this.cbxEstado.Location = new System.Drawing.Point(333, 47);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(192, 28);
            this.cbxEstado.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.Location = new System.Drawing.Point(615, 47);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(316, 28);
            this.dtpFecha.TabIndex = 4;
            // 
            // cbxClientes
            // 
            this.cbxClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(72, 46);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(181, 28);
            this.cbxClientes.TabIndex = 3;
            this.cbxClientes.SelectedIndexChanged += new System.EventHandler(this.cbxClientes_SelectedIndexChanged);
            // 
            // lalbel3
            // 
            this.lalbel3.AutoSize = true;
            this.lalbel3.Location = new System.Drawing.Point(545, 50);
            this.lalbel3.Name = "lalbel3";
            this.lalbel3.Size = new System.Drawing.Size(52, 20);
            this.lalbel3.TabIndex = 2;
            this.lalbel3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.lblTotal);
            this.gbProductos.Controls.Add(this.dtvProductos);
            this.gbProductos.Controls.Add(this.txtCantidad);
            this.gbProductos.Controls.Add(this.cbxProducto);
            this.gbProductos.Controls.Add(this.btnFinalizar);
            this.gbProductos.Controls.Add(this.btnAgregar);
            this.gbProductos.Controls.Add(this.label4);
            this.gbProductos.Controls.Add(this.label3);
            this.gbProductos.Enabled = false;
            this.gbProductos.Location = new System.Drawing.Point(26, 188);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(988, 464);
            this.gbProductos.TabIndex = 1;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(395, 97);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(154, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "TOTAL DEL PEDIDO";
            // 
            // dtvProductos
            // 
            this.dtvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProductos.Location = new System.Drawing.Point(-6, 120);
            this.dtvProductos.Name = "dtvProductos";
            this.dtvProductos.RowHeadersWidth = 62;
            this.dtvProductos.RowTemplate.Height = 28;
            this.dtvProductos.Size = new System.Drawing.Size(988, 295);
            this.dtvProductos.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(374, 49);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(144, 28);
            this.txtCantidad.TabIndex = 5;
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(95, 49);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(171, 28);
            this.cbxProducto.TabIndex = 4;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(707, 57);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(110, 27);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(575, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 27);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Productos";
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1102, 613);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.gbEncabezado);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedido";
            this.Text = "FACTURA DE PEDIDOS";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.gbEncabezado.ResumeLayout(false);
            this.gbEncabezado.PerformLayout();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEncabezado;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label lalbel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtvProductos;
        private System.Windows.Forms.Label lblTotal;
    }
}