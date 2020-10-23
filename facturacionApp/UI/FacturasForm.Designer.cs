namespace facturacionApp.UI
{
    partial class FacturasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.clientePanel = new System.Windows.Forms.Panel();
            this.limpiarDetallesClientePictureBox = new System.Windows.Forms.PictureBox();
            this.buscarClienteMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nitClienteLabel = new System.Windows.Forms.Label();
            this.buscarClienteLabel = new System.Windows.Forms.Label();
            this.telefonoClienteLabel = new System.Windows.Forms.Label();
            this.clienteLable = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.apellidoClienteTextBox = new System.Windows.Forms.TextBox();
            this.cedulaClienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteLable = new System.Windows.Forms.Label();
            this.telefonoClienteTextBox = new System.Windows.Forms.TextBox();
            this.detallesProductosPanel = new System.Windows.Forms.Panel();
            this.limpiarDetallesProductoPictureBox = new System.Windows.Forms.PictureBox();
            this.buscarProductoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cantidadProductosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalProductosLabel = new System.Windows.Forms.Label();
            this.totalProductosTextBox = new System.Windows.Forms.TextBox();
            this.agregarProductoButton = new System.Windows.Forms.Button();
            this.existenciaProductoTextBox = new System.Windows.Forms.TextBox();
            this.existenciaProductoLabel = new System.Windows.Forms.Label();
            this.cantidadProductoLabel = new System.Windows.Forms.Label();
            this.buscarProductoLabel = new System.Windows.Forms.Label();
            this.detallesProductosLabel = new System.Windows.Forms.Label();
            this.precioProductoLabel = new System.Windows.Forms.Label();
            this.nombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.precio_unitarioProductoTextBox = new System.Windows.Forms.TextBox();
            this.nombreProductoLable = new System.Windows.Forms.Label();
            this.productosAgregadosPanel = new System.Windows.Forms.Panel();
            this.EliminarProductoAgregadoPictureBox = new System.Windows.Forms.PictureBox();
            this.productosAgregadosDataGridView = new System.Windows.Forms.DataGridView();
            this.productosAgregadosLabel = new System.Windows.Forms.Label();
            this.detallesCalculoPanel = new System.Windows.Forms.Panel();
            this.pagoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.cambioTextBox = new System.Windows.Forms.TextBox();
            this.cambioLabel = new System.Windows.Forms.Label();
            this.pagoLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.detallesCalculoLabel = new System.Windows.Forms.Label();
            this.facturarButton = new System.Windows.Forms.Button();
            this.facturarPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.clientePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limpiarDetallesClientePictureBox)).BeginInit();
            this.detallesProductosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limpiarDetallesProductoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarProductoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProductosNumericUpDown)).BeginInit();
            this.productosAgregadosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarProductoAgregadoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosAgregadosDataGridView)).BeginInit();
            this.detallesCalculoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.facturarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Controls.Add(this.topLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1192, 44);
            this.topPanel.TabIndex = 20;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1148, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(9, 8);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(93, 27);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "Facturas";
            // 
            // clientePanel
            // 
            this.clientePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clientePanel.Controls.Add(this.limpiarDetallesClientePictureBox);
            this.clientePanel.Controls.Add(this.buscarClienteMaskedTextBox);
            this.clientePanel.Controls.Add(this.nitClienteLabel);
            this.clientePanel.Controls.Add(this.buscarClienteLabel);
            this.clientePanel.Controls.Add(this.telefonoClienteLabel);
            this.clientePanel.Controls.Add(this.clienteLable);
            this.clientePanel.Controls.Add(this.apellidoLabel);
            this.clientePanel.Controls.Add(this.nombreClienteTextBox);
            this.clientePanel.Controls.Add(this.apellidoClienteTextBox);
            this.clientePanel.Controls.Add(this.cedulaClienteTextBox);
            this.clientePanel.Controls.Add(this.nombreClienteLable);
            this.clientePanel.Controls.Add(this.telefonoClienteTextBox);
            this.clientePanel.Location = new System.Drawing.Point(13, 82);
            this.clientePanel.Name = "clientePanel";
            this.clientePanel.Size = new System.Drawing.Size(1167, 112);
            this.clientePanel.TabIndex = 21;
            // 
            // limpiarDetallesClientePictureBox
            // 
            this.limpiarDetallesClientePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarDetallesClientePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("limpiarDetallesClientePictureBox.Image")));
            this.limpiarDetallesClientePictureBox.Location = new System.Drawing.Point(10, 67);
            this.limpiarDetallesClientePictureBox.Name = "limpiarDetallesClientePictureBox";
            this.limpiarDetallesClientePictureBox.Size = new System.Drawing.Size(30, 32);
            this.limpiarDetallesClientePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.limpiarDetallesClientePictureBox.TabIndex = 31;
            this.limpiarDetallesClientePictureBox.TabStop = false;
            this.limpiarDetallesClientePictureBox.Click += new System.EventHandler(this.LimpiarDetallesClientePictureBox_Click);
            // 
            // buscarClienteMaskedTextBox
            // 
            this.buscarClienteMaskedTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.buscarClienteMaskedTextBox.Location = new System.Drawing.Point(104, 29);
            this.buscarClienteMaskedTextBox.Mask = "SDO00000";
            this.buscarClienteMaskedTextBox.Name = "buscarClienteMaskedTextBox";
            this.buscarClienteMaskedTextBox.Size = new System.Drawing.Size(245, 32);
            this.buscarClienteMaskedTextBox.TabIndex = 24;
            this.buscarClienteMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarClienteMaskedTextBox_KeyPress);
            // 
            // nitClienteLabel
            // 
            this.nitClienteLabel.AutoSize = true;
            this.nitClienteLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nitClienteLabel.Location = new System.Drawing.Point(391, 70);
            this.nitClienteLabel.Name = "nitClienteLabel";
            this.nitClienteLabel.Size = new System.Drawing.Size(69, 23);
            this.nitClienteLabel.TabIndex = 23;
            this.nitClienteLabel.Text = "Cédula";
            // 
            // buscarClienteLabel
            // 
            this.buscarClienteLabel.AutoSize = true;
            this.buscarClienteLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarClienteLabel.Location = new System.Drawing.Point(6, 38);
            this.buscarClienteLabel.Name = "buscarClienteLabel";
            this.buscarClienteLabel.Size = new System.Drawing.Size(66, 23);
            this.buscarClienteLabel.TabIndex = 2;
            this.buscarClienteLabel.Text = "Buscar";
            // 
            // telefonoClienteLabel
            // 
            this.telefonoClienteLabel.AutoSize = true;
            this.telefonoClienteLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoClienteLabel.Location = new System.Drawing.Point(731, 70);
            this.telefonoClienteLabel.Name = "telefonoClienteLabel";
            this.telefonoClienteLabel.Size = new System.Drawing.Size(84, 23);
            this.telefonoClienteLabel.TabIndex = 10;
            this.telefonoClienteLabel.Text = "Teléfono";
            // 
            // clienteLable
            // 
            this.clienteLable.AutoSize = true;
            this.clienteLable.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.clienteLable.Location = new System.Drawing.Point(4, 4);
            this.clienteLable.Name = "clienteLable";
            this.clienteLable.Size = new System.Drawing.Size(174, 23);
            this.clienteLable.TabIndex = 0;
            this.clienteLable.Text = "Detalles del cliente";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoLabel.Location = new System.Drawing.Point(731, 32);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(80, 23);
            this.apellidoLabel.TabIndex = 8;
            this.apellidoLabel.Text = "Apellido";
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.nombreClienteTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.nombreClienteTextBox.Location = new System.Drawing.Point(475, 29);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.ReadOnly = true;
            this.nombreClienteTextBox.Size = new System.Drawing.Size(245, 32);
            this.nombreClienteTextBox.TabIndex = 5;
            // 
            // apellidoClienteTextBox
            // 
            this.apellidoClienteTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.apellidoClienteTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.apellidoClienteTextBox.Location = new System.Drawing.Point(830, 29);
            this.apellidoClienteTextBox.Name = "apellidoClienteTextBox";
            this.apellidoClienteTextBox.ReadOnly = true;
            this.apellidoClienteTextBox.Size = new System.Drawing.Size(332, 32);
            this.apellidoClienteTextBox.TabIndex = 9;
            // 
            // cedulaClienteTextBox
            // 
            this.cedulaClienteTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.cedulaClienteTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.cedulaClienteTextBox.Location = new System.Drawing.Point(475, 67);
            this.cedulaClienteTextBox.Name = "cedulaClienteTextBox";
            this.cedulaClienteTextBox.ReadOnly = true;
            this.cedulaClienteTextBox.Size = new System.Drawing.Size(245, 32);
            this.cedulaClienteTextBox.TabIndex = 22;
            // 
            // nombreClienteLable
            // 
            this.nombreClienteLable.AutoSize = true;
            this.nombreClienteLable.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClienteLable.Location = new System.Drawing.Point(390, 32);
            this.nombreClienteLable.Name = "nombreClienteLable";
            this.nombreClienteLable.Size = new System.Drawing.Size(79, 23);
            this.nombreClienteLable.TabIndex = 6;
            this.nombreClienteLable.Text = "Nombre";
            // 
            // telefonoClienteTextBox
            // 
            this.telefonoClienteTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.telefonoClienteTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.telefonoClienteTextBox.Location = new System.Drawing.Point(830, 67);
            this.telefonoClienteTextBox.Name = "telefonoClienteTextBox";
            this.telefonoClienteTextBox.ReadOnly = true;
            this.telefonoClienteTextBox.Size = new System.Drawing.Size(332, 32);
            this.telefonoClienteTextBox.TabIndex = 7;
            // 
            // detallesProductosPanel
            // 
            this.detallesProductosPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.detallesProductosPanel.Controls.Add(this.limpiarDetallesProductoPictureBox);
            this.detallesProductosPanel.Controls.Add(this.buscarProductoNumericUpDown);
            this.detallesProductosPanel.Controls.Add(this.numericUpDown1);
            this.detallesProductosPanel.Controls.Add(this.cantidadProductosNumericUpDown);
            this.detallesProductosPanel.Controls.Add(this.totalProductosLabel);
            this.detallesProductosPanel.Controls.Add(this.totalProductosTextBox);
            this.detallesProductosPanel.Controls.Add(this.agregarProductoButton);
            this.detallesProductosPanel.Controls.Add(this.existenciaProductoTextBox);
            this.detallesProductosPanel.Controls.Add(this.existenciaProductoLabel);
            this.detallesProductosPanel.Controls.Add(this.cantidadProductoLabel);
            this.detallesProductosPanel.Controls.Add(this.buscarProductoLabel);
            this.detallesProductosPanel.Controls.Add(this.detallesProductosLabel);
            this.detallesProductosPanel.Controls.Add(this.precioProductoLabel);
            this.detallesProductosPanel.Controls.Add(this.nombreProductoTextBox);
            this.detallesProductosPanel.Controls.Add(this.precio_unitarioProductoTextBox);
            this.detallesProductosPanel.Controls.Add(this.nombreProductoLable);
            this.detallesProductosPanel.Location = new System.Drawing.Point(14, 201);
            this.detallesProductosPanel.Name = "detallesProductosPanel";
            this.detallesProductosPanel.Size = new System.Drawing.Size(1167, 144);
            this.detallesProductosPanel.TabIndex = 24;
            // 
            // limpiarDetallesProductoPictureBox
            // 
            this.limpiarDetallesProductoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarDetallesProductoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("limpiarDetallesProductoPictureBox.Image")));
            this.limpiarDetallesProductoPictureBox.Location = new System.Drawing.Point(9, 100);
            this.limpiarDetallesProductoPictureBox.Name = "limpiarDetallesProductoPictureBox";
            this.limpiarDetallesProductoPictureBox.Size = new System.Drawing.Size(30, 32);
            this.limpiarDetallesProductoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.limpiarDetallesProductoPictureBox.TabIndex = 32;
            this.limpiarDetallesProductoPictureBox.TabStop = false;
            this.limpiarDetallesProductoPictureBox.Click += new System.EventHandler(this.LimpiarDetallesProductoPictureBox_Click);
            // 
            // buscarProductoNumericUpDown
            // 
            this.buscarProductoNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buscarProductoNumericUpDown.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.buscarProductoNumericUpDown.Location = new System.Drawing.Point(103, 36);
            this.buscarProductoNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.buscarProductoNumericUpDown.Name = "buscarProductoNumericUpDown";
            this.buscarProductoNumericUpDown.Size = new System.Drawing.Size(245, 32);
            this.buscarProductoNumericUpDown.TabIndex = 28;
            this.buscarProductoNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarProductoNumericUpDown_KeyPress);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(208, 145);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(186, 20);
            this.numericUpDown1.TabIndex = 27;
            // 
            // cantidadProductosNumericUpDown
            // 
            this.cantidadProductosNumericUpDown.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.cantidadProductosNumericUpDown.Location = new System.Drawing.Point(475, 72);
            this.cantidadProductosNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantidadProductosNumericUpDown.Name = "cantidadProductosNumericUpDown";
            this.cantidadProductosNumericUpDown.Size = new System.Drawing.Size(245, 32);
            this.cantidadProductosNumericUpDown.TabIndex = 26;
            this.cantidadProductosNumericUpDown.Tag = "";
            this.cantidadProductosNumericUpDown.Click += new System.EventHandler(this.CantidadProductosNumericUpDown_Click);
            this.cantidadProductosNumericUpDown.DoubleClick += new System.EventHandler(this.CantidadProductosNumericUpDown_DoubleClick);
            this.cantidadProductosNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadProductosNumericUpDown_KeyPress);
            // 
            // totalProductosLabel
            // 
            this.totalProductosLabel.AutoSize = true;
            this.totalProductosLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductosLabel.Location = new System.Drawing.Point(730, 75);
            this.totalProductosLabel.Name = "totalProductosLabel";
            this.totalProductosLabel.Size = new System.Drawing.Size(52, 23);
            this.totalProductosLabel.TabIndex = 15;
            this.totalProductosLabel.Text = "Total";
            // 
            // totalProductosTextBox
            // 
            this.totalProductosTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.totalProductosTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.totalProductosTextBox.Location = new System.Drawing.Point(829, 72);
            this.totalProductosTextBox.Name = "totalProductosTextBox";
            this.totalProductosTextBox.ReadOnly = true;
            this.totalProductosTextBox.Size = new System.Drawing.Size(245, 32);
            this.totalProductosTextBox.TabIndex = 16;
            // 
            // agregarProductoButton
            // 
            this.agregarProductoButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.agregarProductoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarProductoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarProductoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProductoButton.ForeColor = System.Drawing.Color.White;
            this.agregarProductoButton.Location = new System.Drawing.Point(1080, 33);
            this.agregarProductoButton.Name = "agregarProductoButton";
            this.agregarProductoButton.Size = new System.Drawing.Size(81, 71);
            this.agregarProductoButton.TabIndex = 14;
            this.agregarProductoButton.Text = "Agregar";
            this.agregarProductoButton.UseVisualStyleBackColor = false;
            this.agregarProductoButton.Click += new System.EventHandler(this.AgregarProductoButton_Click);
            // 
            // existenciaProductoTextBox
            // 
            this.existenciaProductoTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.existenciaProductoTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.existenciaProductoTextBox.Location = new System.Drawing.Point(103, 72);
            this.existenciaProductoTextBox.Name = "existenciaProductoTextBox";
            this.existenciaProductoTextBox.ReadOnly = true;
            this.existenciaProductoTextBox.Size = new System.Drawing.Size(245, 32);
            this.existenciaProductoTextBox.TabIndex = 12;
            // 
            // existenciaProductoLabel
            // 
            this.existenciaProductoLabel.AutoSize = true;
            this.existenciaProductoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existenciaProductoLabel.Location = new System.Drawing.Point(3, 75);
            this.existenciaProductoLabel.Name = "existenciaProductoLabel";
            this.existenciaProductoLabel.Size = new System.Drawing.Size(93, 23);
            this.existenciaProductoLabel.TabIndex = 13;
            this.existenciaProductoLabel.Text = "Existencia";
            // 
            // cantidadProductoLabel
            // 
            this.cantidadProductoLabel.AutoSize = true;
            this.cantidadProductoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadProductoLabel.Location = new System.Drawing.Point(383, 75);
            this.cantidadProductoLabel.Name = "cantidadProductoLabel";
            this.cantidadProductoLabel.Size = new System.Drawing.Size(86, 23);
            this.cantidadProductoLabel.TabIndex = 11;
            this.cantidadProductoLabel.Text = "Cantidad";
            // 
            // buscarProductoLabel
            // 
            this.buscarProductoLabel.AutoSize = true;
            this.buscarProductoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarProductoLabel.Location = new System.Drawing.Point(4, 36);
            this.buscarProductoLabel.Name = "buscarProductoLabel";
            this.buscarProductoLabel.Size = new System.Drawing.Size(66, 23);
            this.buscarProductoLabel.TabIndex = 2;
            this.buscarProductoLabel.Text = "Buscar";
            // 
            // detallesProductosLabel
            // 
            this.detallesProductosLabel.AutoSize = true;
            this.detallesProductosLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.detallesProductosLabel.Location = new System.Drawing.Point(4, 4);
            this.detallesProductosLabel.Name = "detallesProductosLabel";
            this.detallesProductosLabel.Size = new System.Drawing.Size(203, 23);
            this.detallesProductosLabel.TabIndex = 0;
            this.detallesProductosLabel.Text = "Detalles de productos";
            // 
            // precioProductoLabel
            // 
            this.precioProductoLabel.AutoSize = true;
            this.precioProductoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioProductoLabel.Location = new System.Drawing.Point(730, 36);
            this.precioProductoLabel.Name = "precioProductoLabel";
            this.precioProductoLabel.Size = new System.Drawing.Size(97, 23);
            this.precioProductoLabel.TabIndex = 8;
            this.precioProductoLabel.Text = "Precio/uni";
            // 
            // nombreProductoTextBox
            // 
            this.nombreProductoTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.nombreProductoTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.nombreProductoTextBox.Location = new System.Drawing.Point(475, 33);
            this.nombreProductoTextBox.Name = "nombreProductoTextBox";
            this.nombreProductoTextBox.ReadOnly = true;
            this.nombreProductoTextBox.Size = new System.Drawing.Size(245, 32);
            this.nombreProductoTextBox.TabIndex = 5;
            // 
            // precio_unitarioProductoTextBox
            // 
            this.precio_unitarioProductoTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.precio_unitarioProductoTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.precio_unitarioProductoTextBox.Location = new System.Drawing.Point(829, 33);
            this.precio_unitarioProductoTextBox.Name = "precio_unitarioProductoTextBox";
            this.precio_unitarioProductoTextBox.ReadOnly = true;
            this.precio_unitarioProductoTextBox.Size = new System.Drawing.Size(245, 32);
            this.precio_unitarioProductoTextBox.TabIndex = 9;
            // 
            // nombreProductoLable
            // 
            this.nombreProductoLable.AutoSize = true;
            this.nombreProductoLable.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProductoLable.Location = new System.Drawing.Point(390, 36);
            this.nombreProductoLable.Name = "nombreProductoLable";
            this.nombreProductoLable.Size = new System.Drawing.Size(79, 23);
            this.nombreProductoLable.TabIndex = 6;
            this.nombreProductoLable.Text = "Nombre";
            // 
            // productosAgregadosPanel
            // 
            this.productosAgregadosPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.productosAgregadosPanel.Controls.Add(this.EliminarProductoAgregadoPictureBox);
            this.productosAgregadosPanel.Controls.Add(this.productosAgregadosDataGridView);
            this.productosAgregadosPanel.Controls.Add(this.productosAgregadosLabel);
            this.productosAgregadosPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.productosAgregadosPanel.Location = new System.Drawing.Point(14, 351);
            this.productosAgregadosPanel.Name = "productosAgregadosPanel";
            this.productosAgregadosPanel.Size = new System.Drawing.Size(959, 306);
            this.productosAgregadosPanel.TabIndex = 24;
            // 
            // EliminarProductoAgregadoPictureBox
            // 
            this.EliminarProductoAgregadoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarProductoAgregadoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EliminarProductoAgregadoPictureBox.Image")));
            this.EliminarProductoAgregadoPictureBox.Location = new System.Drawing.Point(9, 271);
            this.EliminarProductoAgregadoPictureBox.Name = "EliminarProductoAgregadoPictureBox";
            this.EliminarProductoAgregadoPictureBox.Size = new System.Drawing.Size(30, 32);
            this.EliminarProductoAgregadoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EliminarProductoAgregadoPictureBox.TabIndex = 27;
            this.EliminarProductoAgregadoPictureBox.TabStop = false;
            this.EliminarProductoAgregadoPictureBox.Visible = false;
            this.EliminarProductoAgregadoPictureBox.Click += new System.EventHandler(this.EliminarProductoAgregadoPictureBox_Click);
            // 
            // productosAgregadosDataGridView
            // 
            this.productosAgregadosDataGridView.AllowUserToAddRows = false;
            this.productosAgregadosDataGridView.AllowUserToOrderColumns = true;
            this.productosAgregadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosAgregadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosAgregadosDataGridView.Location = new System.Drawing.Point(9, 34);
            this.productosAgregadosDataGridView.Name = "productosAgregadosDataGridView";
            this.productosAgregadosDataGridView.ReadOnly = true;
            this.productosAgregadosDataGridView.Size = new System.Drawing.Size(941, 234);
            this.productosAgregadosDataGridView.TabIndex = 1;
            this.productosAgregadosDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductosAgregadosDataGridView_RowHeaderMouseClick);
            this.productosAgregadosDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ProductosAgregadosDataGridView_UserDeletedRow);
            // 
            // productosAgregadosLabel
            // 
            this.productosAgregadosLabel.AutoSize = true;
            this.productosAgregadosLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.productosAgregadosLabel.Location = new System.Drawing.Point(4, 4);
            this.productosAgregadosLabel.Name = "productosAgregadosLabel";
            this.productosAgregadosLabel.Size = new System.Drawing.Size(201, 23);
            this.productosAgregadosLabel.TabIndex = 0;
            this.productosAgregadosLabel.Text = "Productos agregados";
            // 
            // detallesCalculoPanel
            // 
            this.detallesCalculoPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.detallesCalculoPanel.Controls.Add(this.pagoNumericUpDown);
            this.detallesCalculoPanel.Controls.Add(this.pictureBox1);
            this.detallesCalculoPanel.Controls.Add(this.CalcularButton);
            this.detallesCalculoPanel.Controls.Add(this.cambioTextBox);
            this.detallesCalculoPanel.Controls.Add(this.cambioLabel);
            this.detallesCalculoPanel.Controls.Add(this.pagoLabel);
            this.detallesCalculoPanel.Controls.Add(this.TotalTextBox);
            this.detallesCalculoPanel.Controls.Add(this.totalLabel);
            this.detallesCalculoPanel.Controls.Add(this.detallesCalculoLabel);
            this.detallesCalculoPanel.Location = new System.Drawing.Point(979, 351);
            this.detallesCalculoPanel.Name = "detallesCalculoPanel";
            this.detallesCalculoPanel.Size = new System.Drawing.Size(202, 223);
            this.detallesCalculoPanel.TabIndex = 25;
            // 
            // pagoNumericUpDown
            // 
            this.pagoNumericUpDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.pagoNumericUpDown.DecimalPlaces = 2;
            this.pagoNumericUpDown.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.pagoNumericUpDown.Location = new System.Drawing.Point(77, 71);
            this.pagoNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.pagoNumericUpDown.Name = "pagoNumericUpDown";
            this.pagoNumericUpDown.Size = new System.Drawing.Size(119, 32);
            this.pagoNumericUpDown.TabIndex = 29;
            this.pagoNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PagoNumericUpDown_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // CalcularButton
            // 
            this.CalcularButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.CalcularButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcularButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcularButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.ForeColor = System.Drawing.Color.White;
            this.CalcularButton.Location = new System.Drawing.Point(7, 151);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(189, 63);
            this.CalcularButton.TabIndex = 15;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = false;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // cambioTextBox
            // 
            this.cambioTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.cambioTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.cambioTextBox.Location = new System.Drawing.Point(77, 109);
            this.cambioTextBox.Name = "cambioTextBox";
            this.cambioTextBox.ReadOnly = true;
            this.cambioTextBox.Size = new System.Drawing.Size(119, 32);
            this.cambioTextBox.TabIndex = 28;
            // 
            // cambioLabel
            // 
            this.cambioLabel.AutoSize = true;
            this.cambioLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambioLabel.Location = new System.Drawing.Point(3, 118);
            this.cambioLabel.Name = "cambioLabel";
            this.cambioLabel.Size = new System.Drawing.Size(75, 23);
            this.cambioLabel.TabIndex = 27;
            this.cambioLabel.Text = "Cambio";
            // 
            // pagoLabel
            // 
            this.pagoLabel.AutoSize = true;
            this.pagoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoLabel.Location = new System.Drawing.Point(3, 79);
            this.pagoLabel.Name = "pagoLabel";
            this.pagoLabel.Size = new System.Drawing.Size(53, 23);
            this.pagoLabel.TabIndex = 25;
            this.pagoLabel.Text = "Pago";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.TotalTextBox.Location = new System.Drawing.Point(77, 31);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(119, 32);
            this.TotalTextBox.TabIndex = 24;
            this.TotalTextBox.Text = "0.00";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(3, 40);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(52, 23);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // detallesCalculoLabel
            // 
            this.detallesCalculoLabel.AutoSize = true;
            this.detallesCalculoLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.detallesCalculoLabel.Location = new System.Drawing.Point(3, 5);
            this.detallesCalculoLabel.Name = "detallesCalculoLabel";
            this.detallesCalculoLabel.Size = new System.Drawing.Size(173, 23);
            this.detallesCalculoLabel.TabIndex = 0;
            this.detallesCalculoLabel.Text = "Detalles de calculo";
            // 
            // facturarButton
            // 
            this.facturarButton.BackColor = System.Drawing.Color.Green;
            this.facturarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facturarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facturarButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturarButton.ForeColor = System.Drawing.Color.White;
            this.facturarButton.Location = new System.Drawing.Point(5, 6);
            this.facturarButton.Name = "facturarButton";
            this.facturarButton.Size = new System.Drawing.Size(189, 63);
            this.facturarButton.TabIndex = 15;
            this.facturarButton.Text = "Facturar";
            this.facturarButton.UseVisualStyleBackColor = false;
            this.facturarButton.Click += new System.EventHandler(this.FacturarButton_Click);
            // 
            // facturarPanel
            // 
            this.facturarPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.facturarPanel.Controls.Add(this.facturarButton);
            this.facturarPanel.Location = new System.Drawing.Point(981, 580);
            this.facturarPanel.Name = "facturarPanel";
            this.facturarPanel.Size = new System.Drawing.Size(200, 77);
            this.facturarPanel.TabIndex = 26;
            // 
            // FacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1192, 676);
            this.Controls.Add(this.facturarPanel);
            this.Controls.Add(this.detallesCalculoPanel);
            this.Controls.Add(this.productosAgregadosPanel);
            this.Controls.Add(this.detallesProductosPanel);
            this.Controls.Add(this.clientePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.clientePanel.ResumeLayout(false);
            this.clientePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limpiarDetallesClientePictureBox)).EndInit();
            this.detallesProductosPanel.ResumeLayout(false);
            this.detallesProductosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limpiarDetallesProductoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarProductoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProductosNumericUpDown)).EndInit();
            this.productosAgregadosPanel.ResumeLayout(false);
            this.productosAgregadosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarProductoAgregadoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosAgregadosDataGridView)).EndInit();
            this.detallesCalculoPanel.ResumeLayout(false);
            this.detallesCalculoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.facturarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel clientePanel;
        private System.Windows.Forms.Label clienteLable;
        private System.Windows.Forms.Label nitClienteLabel;
        private System.Windows.Forms.Label buscarClienteLabel;
        private System.Windows.Forms.Label telefonoClienteLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox apellidoClienteTextBox;
        private System.Windows.Forms.TextBox cedulaClienteTextBox;
        private System.Windows.Forms.Label nombreClienteLable;
        private System.Windows.Forms.TextBox telefonoClienteTextBox;
        private System.Windows.Forms.Label buscarProductoLabel;
        private System.Windows.Forms.Label detallesProductosLabel;
        private System.Windows.Forms.Label precioProductoLabel;
        private System.Windows.Forms.TextBox nombreProductoTextBox;
        private System.Windows.Forms.TextBox precio_unitarioProductoTextBox;
        private System.Windows.Forms.Label nombreProductoLable;
        private System.Windows.Forms.Button agregarProductoButton;
        private System.Windows.Forms.TextBox existenciaProductoTextBox;
        private System.Windows.Forms.Label existenciaProductoLabel;
        private System.Windows.Forms.Label cantidadProductoLabel;
        private System.Windows.Forms.Panel productosAgregadosPanel;
        private System.Windows.Forms.DataGridView productosAgregadosDataGridView;
        private System.Windows.Forms.Label productosAgregadosLabel;
        private System.Windows.Forms.Panel detallesCalculoPanel;
        private System.Windows.Forms.TextBox cambioTextBox;
        private System.Windows.Forms.Label cambioLabel;
        private System.Windows.Forms.Label pagoLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label detallesCalculoLabel;
        private System.Windows.Forms.Button facturarButton;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel facturarPanel;
        private System.Windows.Forms.Label totalProductosLabel;
        private System.Windows.Forms.TextBox totalProductosTextBox;
        private System.Windows.Forms.MaskedTextBox buscarClienteMaskedTextBox;
        private System.Windows.Forms.Panel detallesProductosPanel;
        private System.Windows.Forms.NumericUpDown cantidadProductosNumericUpDown;
        private System.Windows.Forms.NumericUpDown buscarProductoNumericUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown pagoNumericUpDown;
        private System.Windows.Forms.PictureBox limpiarDetallesClientePictureBox;
        private System.Windows.Forms.PictureBox limpiarDetallesProductoPictureBox;
        private System.Windows.Forms.PictureBox EliminarProductoAgregadoPictureBox;
    }
}