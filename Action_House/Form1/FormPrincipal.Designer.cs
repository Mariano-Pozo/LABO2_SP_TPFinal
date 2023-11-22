namespace Form1
{
    partial class FormPrincipal
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
            buttonAgregar = new Button();
            buttonFiltroPelotas = new Button();
            buttonFiltroMotos = new Button();
            buttonFiltroAutos = new Button();
            buttonBuy = new Button();
            labelDinero = new Label();
            dataGridView1 = new DataGridView();
            buttonBorrar = new Button();
            buttonActualizar = new Button();
            labelFiltros = new Label();
            textBoxNombre = new TextBox();
            textBoxCantidad = new TextBox();
            textBoxEstado = new TextBox();
            labelTipo = new Label();
            labelNombreItem = new Label();
            labelCantidadItem = new Label();
            labelEstadoItem = new Label();
            textBoxPrecio = new TextBox();
            labelPrecioItem = new Label();
            comboBoxTipo = new ComboBox();
            buttonCerrarFormPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(54, 12);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonFiltroPelotas
            // 
            buttonFiltroPelotas.Location = new Point(236, 1);
            buttonFiltroPelotas.Name = "buttonFiltroPelotas";
            buttonFiltroPelotas.Size = new Size(75, 23);
            buttonFiltroPelotas.TabIndex = 14;
            buttonFiltroPelotas.Text = "Pelotas";
            buttonFiltroPelotas.UseVisualStyleBackColor = true;
            buttonFiltroPelotas.Click += buttonFiltroPelotas_Click;
            // 
            // buttonFiltroMotos
            // 
            buttonFiltroMotos.Location = new Point(236, 30);
            buttonFiltroMotos.Name = "buttonFiltroMotos";
            buttonFiltroMotos.Size = new Size(75, 23);
            buttonFiltroMotos.TabIndex = 15;
            buttonFiltroMotos.Text = "Motos";
            buttonFiltroMotos.UseVisualStyleBackColor = true;
            buttonFiltroMotos.Click += buttonFiltroMotos_Click;
            // 
            // buttonFiltroAutos
            // 
            buttonFiltroAutos.Location = new Point(236, 59);
            buttonFiltroAutos.Name = "buttonFiltroAutos";
            buttonFiltroAutos.Size = new Size(75, 23);
            buttonFiltroAutos.TabIndex = 16;
            buttonFiltroAutos.Text = "Autos";
            buttonFiltroAutos.UseVisualStyleBackColor = true;
            buttonFiltroAutos.Click += buttonFiltroAutos_Click;
            // 
            // buttonBuy
            // 
            buttonBuy.Location = new Point(701, 405);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(75, 23);
            buttonBuy.TabIndex = 17;
            buttonBuy.Text = "Buy";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // labelDinero
            // 
            labelDinero.AutoSize = true;
            labelDinero.Location = new Point(32, 160);
            labelDinero.Name = "labelDinero";
            labelDinero.Size = new Size(16, 15);
            labelDinero.TabIndex = 20;
            labelDinero.Text = "$ ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(135, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(641, 294);
            dataGridView1.TabIndex = 21;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(356, 24);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(75, 23);
            buttonBorrar.TabIndex = 22;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(453, 24);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(75, 23);
            buttonActualizar.TabIndex = 23;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // labelFiltros
            // 
            labelFiltros.AutoSize = true;
            labelFiltros.Location = new Point(188, 5);
            labelFiltros.Name = "labelFiltros";
            labelFiltros.Size = new Size(42, 15);
            labelFiltros.TabIndex = 24;
            labelFiltros.Text = "Filtros:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(54, 70);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(75, 23);
            textBoxNombre.TabIndex = 26;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(54, 99);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(75, 23);
            textBoxCantidad.TabIndex = 27;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(54, 128);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(75, 23);
            textBoxEstado.TabIndex = 29;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(18, 44);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(30, 15);
            labelTipo.TabIndex = 30;
            labelTipo.Text = "Tipo";
            // 
            // labelNombreItem
            // 
            labelNombreItem.AutoSize = true;
            labelNombreItem.Location = new Point(1, 73);
            labelNombreItem.Name = "labelNombreItem";
            labelNombreItem.Size = new Size(51, 15);
            labelNombreItem.TabIndex = 31;
            labelNombreItem.Text = "Nombre";
            // 
            // labelCantidadItem
            // 
            labelCantidadItem.AutoSize = true;
            labelCantidadItem.Location = new Point(-3, 102);
            labelCantidadItem.Name = "labelCantidadItem";
            labelCantidadItem.Size = new Size(55, 15);
            labelCantidadItem.TabIndex = 32;
            labelCantidadItem.Text = "Cantidad";
            // 
            // labelEstadoItem
            // 
            labelEstadoItem.AutoSize = true;
            labelEstadoItem.Location = new Point(10, 131);
            labelEstadoItem.Name = "labelEstadoItem";
            labelEstadoItem.Size = new Size(42, 15);
            labelEstadoItem.TabIndex = 34;
            labelEstadoItem.Text = "Estado";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(54, 157);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(75, 23);
            textBoxPrecio.TabIndex = 35;
            // 
            // labelPrecioItem
            // 
            labelPrecioItem.AutoSize = true;
            labelPrecioItem.Location = new Point(12, 160);
            labelPrecioItem.Name = "labelPrecioItem";
            labelPrecioItem.Size = new Size(0, 15);
            labelPrecioItem.TabIndex = 36;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Pelota", "Moto", "Auto" });
            comboBoxTipo.Location = new Point(54, 41);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(75, 23);
            comboBoxTipo.TabIndex = 37;
            // 
            // buttonCerrarFormPrincipal
            // 
            buttonCerrarFormPrincipal.Location = new Point(771, -3);
            buttonCerrarFormPrincipal.Name = "buttonCerrarFormPrincipal";
            buttonCerrarFormPrincipal.Size = new Size(30, 27);
            buttonCerrarFormPrincipal.TabIndex = 38;
            buttonCerrarFormPrincipal.Text = "X";
            buttonCerrarFormPrincipal.UseVisualStyleBackColor = true;
            buttonCerrarFormPrincipal.Click += buttonCerrarFormPrincipal_Click;
            buttonCerrarFormPrincipal.Click += cartel;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCerrarFormPrincipal);
            Controls.Add(comboBoxTipo);
            Controls.Add(labelPrecioItem);
            Controls.Add(textBoxPrecio);
            Controls.Add(labelEstadoItem);
            Controls.Add(labelCantidadItem);
            Controls.Add(labelNombreItem);
            Controls.Add(labelTipo);
            Controls.Add(textBoxEstado);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxNombre);
            Controls.Add(labelFiltros);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonBorrar);
            Controls.Add(dataGridView1);
            Controls.Add(labelDinero);
            Controls.Add(buttonBuy);
            Controls.Add(buttonFiltroAutos);
            Controls.Add(buttonFiltroMotos);
            Controls.Add(buttonFiltroPelotas);
            Controls.Add(buttonAgregar);
            Name = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregar;
        private TextBox textBoxSearch;
        private Button buttonFiltroPelotas;
        private Button buttonFiltroMotos;
        private Button buttonFiltroAutos;
        private Button buttonBuy;
        private Label labelDinero;
        private DataGridView dataGridView1;
        private Button buttonBorrar;
        private Button buttonActualizar;
        private Label labelFiltros;
        private TextBox textBoxTipo;
        private TextBox textBoxNombre;
        private TextBox textBoxCantidad;
        private TextBox textBoxEstado;
        private Label labelTipo;
        private Label labelNombreItem;
        private Label labelCantidadItem;
        private Label labelEstadoItem;
        private TextBox textBoxPrecio;
        private Label labelPrecioItem;
        private ComboBox comboBoxTipo;
        private Button buttonCerrarFormPrincipal;
    }
}