namespace CapaPresentacion
{
    partial class FormCompra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                nArticulo.Dispose();
                nCompra.Dispose();
                nCompraDetalle.Dispose();
                nProveedor.Dispose();
                nAsientoContable.Dispose();
                nCuentaContable.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.btnQuitarFila = new Biblioteca.Controles.MiButton24x24();
            this.btnAgregarFila = new Biblioteca.Controles.MiButton24x24();
            this.gridDetalle = new Biblioteca.Controles.MiGridEdit();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDenominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColDeposito = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlicuotaIVA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColBaseIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCentroCosto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColModificacionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCatalagoTitulo7 = new System.Windows.Forms.Label();
            this.miLabel1 = new Biblioteca.Controles.MiLabel();
            this.txtID = new Biblioteca.Controles.MiTextBoxRead();
            this.txtFecha = new Biblioteca.Controles.MiTextBoxRead();
            this.cmbPeriodo = new Biblioteca.Controles.MiComboBox();
            this.txtPeriodo = new Biblioteca.Controles.MiNumericUpDown();
            this.miLabel2 = new Biblioteca.Controles.MiLabel();
            this.txtAfipCbteTPV = new Biblioteca.Controles.MiTextBox();
            this.txtAfipCbteNro = new Biblioteca.Controles.MiTextBox();
            this.miLabel5 = new Biblioteca.Controles.MiLabel();
            this.txtDenominacion = new Biblioteca.Controles.MiTextBox();
            this.txtCuit = new Biblioteca.Controles.MiTextBoxRead();
            this.miLabel6 = new Biblioteca.Controles.MiLabel();
            this.txtCategoriaIva = new Biblioteca.Controles.MiTextBoxRead();
            this.cmbCuentaContable = new Biblioteca.Controles.MiComboBox();
            this.miLabel7 = new Biblioteca.Controles.MiLabel();
            this.txtAsociacionID = new Biblioteca.Controles.MiTextBoxRead();
            this.miLabel9 = new Biblioteca.Controles.MiLabel();
            this.btnQuitarAsociacion = new Biblioteca.Controles.MiButtonFind();
            this.btnBuscarAsociacion = new Biblioteca.Controles.MiButtonFind();
            this.miLabel10 = new Biblioteca.Controles.MiLabel();
            this.txtAsociacionAfipCbteTipo = new Biblioteca.Controles.MiTextBoxRead();
            this.txtAsociacionAfipCbteTPV = new Biblioteca.Controles.MiTextBoxRead();
            this.txtAsociacionAfipCbteNro = new Biblioteca.Controles.MiTextBoxRead();
            this.txtAsociacionAfipCbteFecha = new Biblioteca.Controles.MiTextBoxRead();
            this.miLabel4 = new Biblioteca.Controles.MiLabel();
            this.txtNumeroCodigoBarras = new Biblioteca.Controles.MiMaskedTextBox();
            this.pkrAfipCbteFecha = new Biblioteca.Controles.MiDateTimePicker();
            this.btnBuscarFila = new Biblioteca.Controles.MiButtonBase();
            this.miLabel8 = new Biblioteca.Controles.MiLabel();
            this.pkrPagoVto = new Biblioteca.Controles.MiDateTimePicker();
            this.groupAsociacion = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImpuestoInterno = new Biblioteca.Controles.MiTextBox();
            this.lblDescuentoPorcentual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPercepcionLH = new Biblioteca.Controles.MiTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPercepcionIIBB = new Biblioteca.Controles.MiTextBox();
            this.txtPercepcionIVA = new Biblioteca.Controles.MiTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.txtNoGravado = new Biblioteca.Controles.MiTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblIVA270 = new System.Windows.Forms.Label();
            this.lblIVA105 = new System.Windows.Forms.Label();
            this.lblIVA210 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtDescuento = new Biblioteca.Controles.MiTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnBuscarProveedor = new Biblioteca.Controles.MiButtonFind();
            this.cmbAfipCbteTipo = new Biblioteca.Controles.MiComboBox();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo)).BeginInit();
            this.groupAsociacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Enabled = false;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnular.Visible = false;
            // 
            // btnExcel_Registro
            // 
            this.btnExcel_Registro.Enabled = false;
            this.btnExcel_Registro.FlatAppearance.BorderSize = 0;
            this.btnExcel_Registro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExcel_Registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExcel_Registro.Visible = false;
            // 
            // btnPDF_Registro
            // 
            this.btnPDF_Registro.Enabled = false;
            this.btnPDF_Registro.FlatAppearance.BorderSize = 0;
            this.btnPDF_Registro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPDF_Registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPDF_Registro.Visible = false;
            // 
            // lblTituloLista
            // 
            this.lblTituloLista.Text = "Lista de Comprobantes de Compra";
            // 
            // cmbFiltroLista1
            // 
            this.cmbFiltroLista1.Enabled = false;
            // 
            // btnExcel_Lista
            // 
            this.btnExcel_Lista.FlatAppearance.BorderSize = 0;
            this.btnExcel_Lista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExcel_Lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // btnPDF_Lista
            // 
            this.btnPDF_Lista.FlatAppearance.BorderSize = 0;
            this.btnPDF_Lista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPDF_Lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // lblCatalagoTitulo1
            // 
            this.lblCatalagoTitulo1.Size = new System.Drawing.Size(27, 14);
            this.lblCatalagoTitulo1.Text = "Tipo";
            // 
            // lblCatalagoTitulo2
            // 
            this.lblCatalagoTitulo2.Location = new System.Drawing.Point(56, 36);
            this.lblCatalagoTitulo2.Size = new System.Drawing.Size(85, 14);
            this.lblCatalagoTitulo2.Text = "N° Comprobante";
            // 
            // lblCatalagoTitulo3
            // 
            this.lblCatalagoTitulo3.Location = new System.Drawing.Point(175, 36);
            this.lblCatalagoTitulo3.Size = new System.Drawing.Size(37, 14);
            this.lblCatalagoTitulo3.Text = "Fecha";
            // 
            // lblCatalagoTitulo4
            // 
            this.lblCatalagoTitulo4.Location = new System.Drawing.Point(266, 36);
            this.lblCatalagoTitulo4.Size = new System.Drawing.Size(43, 14);
            this.lblCatalagoTitulo4.Text = "Periodo";
            // 
            // lblCatalagoTitulo5
            // 
            this.lblCatalagoTitulo5.Location = new System.Drawing.Point(336, 36);
            this.lblCatalagoTitulo5.Size = new System.Drawing.Size(69, 14);
            this.lblCatalagoTitulo5.Text = "Vto. de Pago";
            // 
            // panelLista
            // 
            this.panelLista.Controls.Add(this.lblCatalagoTitulo7);
            this.panelLista.Controls.SetChildIndex(this.lblCatalagoTitulo7, 0);
            this.panelLista.Controls.SetChildIndex(this.lstCatalogo, 0);
            this.panelLista.Controls.SetChildIndex(this.pkrFiltroListaDesde, 0);
            this.panelLista.Controls.SetChildIndex(this.pkrFiltroListaHasta, 0);
            this.panelLista.Controls.SetChildIndex(this.lblTituloLista, 0);
            this.panelLista.Controls.SetChildIndex(this.cmbFiltroLista1, 0);
            this.panelLista.Controls.SetChildIndex(this.cmbFiltroLista2, 0);
            this.panelLista.Controls.SetChildIndex(this.txtFiltroLista, 0);
            this.panelLista.Controls.SetChildIndex(this.btnExcel_Lista, 0);
            this.panelLista.Controls.SetChildIndex(this.btnPDF_Lista, 0);
            this.panelLista.Controls.SetChildIndex(this.lblCatalagoTitulo1, 0);
            this.panelLista.Controls.SetChildIndex(this.lblCatalagoTitulo2, 0);
            this.panelLista.Controls.SetChildIndex(this.lblCatalagoTitulo3, 0);
            this.panelLista.Controls.SetChildIndex(this.lblCatalagoTitulo4, 0);
            this.panelLista.Controls.SetChildIndex(this.lblCatalagoTitulo5, 0);
            this.panelLista.Controls.SetChildIndex(this.lblCatalagoTitulo6, 0);
            // 
            // lblCatalagoTitulo6
            // 
            this.lblCatalagoTitulo6.Location = new System.Drawing.Point(427, 36);
            this.lblCatalagoTitulo6.Size = new System.Drawing.Size(29, 14);
            this.lblCatalagoTitulo6.Text = "Total";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Text = "Comprobantes de Compra";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // btnQuitarFila
            // 
            this.btnQuitarFila.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuitarFila.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitarFila.BackgroundImage = global::CapaPresentacion.Properties.Resources.icon_delete32;
            this.btnQuitarFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarFila.FlatAppearance.BorderSize = 0;
            this.btnQuitarFila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuitarFila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuitarFila.Font = new System.Drawing.Font("Arial", 8F);
            this.btnQuitarFila.ForeColor = System.Drawing.Color.Black;
            this.btnQuitarFila.Location = new System.Drawing.Point(184, 414);
            this.btnQuitarFila.Name = "btnQuitarFila";
            this.btnQuitarFila.Size = new System.Drawing.Size(24, 24);
            this.btnQuitarFila.TabIndex = 35;
            this.btnQuitarFila.UseVisualStyleBackColor = false;
            this.btnQuitarFila.Click += new System.EventHandler(this.btnQuitarFila_Click);
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarFila.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarFila.BackgroundImage = global::CapaPresentacion.Properties.Resources.icon_insert32;
            this.btnAgregarFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarFila.FlatAppearance.BorderSize = 0;
            this.btnAgregarFila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarFila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarFila.Font = new System.Drawing.Font("Arial", 8F);
            this.btnAgregarFila.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarFila.Location = new System.Drawing.Point(160, 414);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarFila.TabIndex = 34;
            this.btnAgregarFila.UseVisualStyleBackColor = false;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // gridDetalle
            // 
            this.gridDetalle.AllowUserToAddRows = false;
            this.gridDetalle.AllowUserToDeleteRows = false;
            this.gridDetalle.AllowUserToResizeColumns = false;
            this.gridDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.gridDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gridDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gridDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDetalle.BackgroundColor = System.Drawing.Color.Gray;
            this.gridDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDenominacion,
            this.ColCantidad,
            this.ColUnidad,
            this.ColDeposito,
            this.ColPrecio,
            this.ColAlicuotaIVA,
            this.ColBaseIva,
            this.ColNeto,
            this.ColCentroCosto,
            this.ColModificacionID});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetalle.DefaultCellStyle = dataGridViewCellStyle28;
            this.gridDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.gridDetalle.EnableHeadersVisualStyles = false;
            this.gridDetalle.GridColor = System.Drawing.Color.DarkGray;
            this.gridDetalle.Location = new System.Drawing.Point(160, 250);
            this.gridDetalle.MultiSelect = false;
            this.gridDetalle.Name = "gridDetalle";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.gridDetalle.RowHeadersVisible = false;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            this.gridDetalle.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.gridDetalle.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalle.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridDetalle.Size = new System.Drawing.Size(840, 163);
            this.gridDetalle.StandardTab = true;
            this.gridDetalle.TabIndex = 33;
            this.gridDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalle_CellEndEdit);
            this.gridDetalle.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalle_CellEnter);
            this.gridDetalle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridDetalle_DataError);
            this.gridDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridDetalle_EditingControlShowing);
            this.gridDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridDetalle_KeyDown);
            this.gridDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridDetalle_KeyPress);
            this.gridDetalle.Leave += new System.EventHandler(this.gridDetalle_Leave);
            // 
            // ColID
            // 
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = null;
            this.ColID.DefaultCellStyle = dataGridViewCellStyle18;
            this.ColID.Frozen = true;
            this.ColID.HeaderText = "ID";
            this.ColID.MaxInputLength = 25;
            this.ColID.Name = "ColID";
            this.ColID.Width = 50;
            // 
            // ColDenominacion
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDenominacion.DefaultCellStyle = dataGridViewCellStyle19;
            this.ColDenominacion.Frozen = true;
            this.ColDenominacion.HeaderText = "Denominación";
            this.ColDenominacion.MaxInputLength = 105;
            this.ColDenominacion.Name = "ColDenominacion";
            this.ColDenominacion.Width = 270;
            // 
            // ColCantidad
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = null;
            this.ColCantidad.DefaultCellStyle = dataGridViewCellStyle20;
            this.ColCantidad.Frozen = true;
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MaxInputLength = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCantidad.Width = 54;
            // 
            // ColUnidad
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.ColUnidad.DefaultCellStyle = dataGridViewCellStyle21;
            this.ColUnidad.DisplayStyleForCurrentCellOnly = true;
            this.ColUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColUnidad.HeaderText = "Unidad";
            this.ColUnidad.Items.AddRange(new object[] {
            "KGS",
            "LTS",
            "MTS",
            "PAQ",
            "UNI"});
            this.ColUnidad.Name = "ColUnidad";
            this.ColUnidad.ReadOnly = true;
            this.ColUnidad.Sorted = true;
            this.ColUnidad.Width = 52;
            // 
            // ColDeposito
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            this.ColDeposito.DefaultCellStyle = dataGridViewCellStyle22;
            this.ColDeposito.DisplayStyleForCurrentCellOnly = true;
            this.ColDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColDeposito.HeaderText = "Depósito ";
            this.ColDeposito.Items.AddRange(new object[] {
            "EMPREMINSA",
            "VELADERO"});
            this.ColDeposito.Name = "ColDeposito";
            this.ColDeposito.Sorted = true;
            this.ColDeposito.Width = 106;
            // 
            // ColPrecio
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = null;
            this.ColPrecio.DefaultCellStyle = dataGridViewCellStyle23;
            this.ColPrecio.HeaderText = "P. Unitario $";
            this.ColPrecio.MaxInputLength = 11;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Width = 80;
            // 
            // ColAlicuotaIVA
            // 
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.ColAlicuotaIVA.DefaultCellStyle = dataGridViewCellStyle24;
            this.ColAlicuotaIVA.DisplayStyleForCurrentCellOnly = true;
            this.ColAlicuotaIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColAlicuotaIVA.HeaderText = "Alícuota";
            this.ColAlicuotaIVA.Items.AddRange(new object[] {
            "00.0",
            "10.5",
            "21.0",
            "27.0"});
            this.ColAlicuotaIVA.Name = "ColAlicuotaIVA";
            this.ColAlicuotaIVA.Sorted = true;
            this.ColAlicuotaIVA.Width = 53;
            // 
            // ColBaseIva
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = null;
            this.ColBaseIva.DefaultCellStyle = dataGridViewCellStyle25;
            this.ColBaseIva.HeaderText = "Base IVA $";
            this.ColBaseIva.MaxInputLength = 12;
            this.ColBaseIva.Name = "ColBaseIva";
            this.ColBaseIva.ReadOnly = true;
            this.ColBaseIva.Width = 74;
            // 
            // ColNeto
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = null;
            this.ColNeto.DefaultCellStyle = dataGridViewCellStyle26;
            this.ColNeto.HeaderText = "Precio Neto $";
            this.ColNeto.MaxInputLength = 12;
            this.ColNeto.Name = "ColNeto";
            this.ColNeto.ReadOnly = true;
            this.ColNeto.Width = 84;
            // 
            // ColCentroCosto
            // 
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            this.ColCentroCosto.DefaultCellStyle = dataGridViewCellStyle27;
            this.ColCentroCosto.DisplayStyleForCurrentCellOnly = true;
            this.ColCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColCentroCosto.HeaderText = "Centro de Costo";
            this.ColCentroCosto.Name = "ColCentroCosto";
            this.ColCentroCosto.Sorted = true;
            this.ColCentroCosto.Width = 225;
            // 
            // ColModificacionID
            // 
            this.ColModificacionID.HeaderText = "ModificacionID";
            this.ColModificacionID.MaxInputLength = 10;
            this.ColModificacionID.Name = "ColModificacionID";
            this.ColModificacionID.ReadOnly = true;
            this.ColModificacionID.Visible = false;
            // 
            // lblCatalagoTitulo7
            // 
            this.lblCatalagoTitulo7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCatalagoTitulo7.AutoSize = true;
            this.lblCatalagoTitulo7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.lblCatalagoTitulo7.ForeColor = System.Drawing.Color.White;
            this.lblCatalagoTitulo7.Location = new System.Drawing.Point(532, 36);
            this.lblCatalagoTitulo7.Name = "lblCatalagoTitulo7";
            this.lblCatalagoTitulo7.Size = new System.Drawing.Size(106, 14);
            this.lblCatalagoTitulo7.TabIndex = 254;
            this.lblCatalagoTitulo7.Text = "Denominación - CUIT";
            this.lblCatalagoTitulo7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // miLabel1
            // 
            this.miLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.miLabel1.BackColor = System.Drawing.Color.Transparent;
            this.miLabel1.Font = new System.Drawing.Font("Arial", 9F);
            this.miLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.miLabel1.Location = new System.Drawing.Point(0, 63);
            this.miLabel1.Name = "miLabel1";
            this.miLabel1.Size = new System.Drawing.Size(160, 15);
            this.miLabel1.TabIndex = 11;
            this.miLabel1.Text = "Registro Interno";
            this.miLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(160, 61);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(74, 22);
            this.txtID.TabIndex = 12;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.Location = new System.Drawing.Point(233, 61);
            this.txtFecha.MaxLength = 10;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(68, 22);
            this.txtFecha.TabIndex = 13;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbPeriodo.BackColor = System.Drawing.Color.White;
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPeriodo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbPeriodo.Location = new System.Drawing.Point(419, 88);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(1);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(38, 22);
            this.cmbPeriodo.Sorted = true;
            this.cmbPeriodo.TabIndex = 19;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPeriodo.BackColor = System.Drawing.Color.White;
            this.txtPeriodo.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtPeriodo.ForeColor = System.Drawing.Color.Black;
            this.txtPeriodo.Location = new System.Drawing.Point(456, 88);
            this.txtPeriodo.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.txtPeriodo.Minimum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(50, 22);
            this.txtPeriodo.TabIndex = 20;
            this.txtPeriodo.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // miLabel2
            // 
            this.miLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.miLabel2.BackColor = System.Drawing.Color.Transparent;
            this.miLabel2.Font = new System.Drawing.Font("Arial", 9F);
            this.miLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.miLabel2.Location = new System.Drawing.Point(0, 90);
            this.miLabel2.Name = "miLabel2";
            this.miLabel2.Size = new System.Drawing.Size(160, 15);
            this.miLabel2.TabIndex = 14;
            this.miLabel2.Text = "Comprobante";
            this.miLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAfipCbteTPV
            // 
            this.txtAfipCbteTPV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAfipCbteTPV.BackColor = System.Drawing.Color.White;
            this.txtAfipCbteTPV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAfipCbteTPV.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtAfipCbteTPV.ForeColor = System.Drawing.Color.Black;
            this.txtAfipCbteTPV.Location = new System.Drawing.Point(221, 88);
            this.txtAfipCbteTPV.MaxLength = 5;
            this.txtAfipCbteTPV.Name = "txtAfipCbteTPV";
            this.txtAfipCbteTPV.Size = new System.Drawing.Size(39, 22);
            this.txtAfipCbteTPV.TabIndex = 16;
            this.txtAfipCbteTPV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAfipCbteTPV_KeyPress);
            this.txtAfipCbteTPV.Validated += new System.EventHandler(this.txtAfipCbteTPV_Validated);
            // 
            // txtAfipCbteNro
            // 
            this.txtAfipCbteNro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAfipCbteNro.BackColor = System.Drawing.Color.White;
            this.txtAfipCbteNro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAfipCbteNro.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtAfipCbteNro.ForeColor = System.Drawing.Color.Black;
            this.txtAfipCbteNro.Location = new System.Drawing.Point(259, 88);
            this.txtAfipCbteNro.MaxLength = 8;
            this.txtAfipCbteNro.Name = "txtAfipCbteNro";
            this.txtAfipCbteNro.Size = new System.Drawing.Size(60, 22);
            this.txtAfipCbteNro.TabIndex = 17;
            this.txtAfipCbteNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAfipCbteNro_KeyPress);
            this.txtAfipCbteNro.Validated += new System.EventHandler(this.txtAfipCbteNro_Validated);
            // 
            // miLabel5
            // 
            this.miLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.miLabel5.BackColor = System.Drawing.Color.Transparent;
            this.miLabel5.Font = new System.Drawing.Font("Arial", 9F);
            this.miLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.miLabel5.Location = new System.Drawing.Point(0, 144);
            this.miLabel5.Name = "miLabel5";
            this.miLabel5.Size = new System.Drawing.Size(160, 15);
            this.miLabel5.TabIndex = 23;
            this.miLabel5.Text = "Denominación";
            this.miLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDenominacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtDenominacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDenominacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDenominacion.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtDenominacion.ForeColor = System.Drawing.Color.Black;
            this.txtDenominacion.Location = new System.Drawing.Point(160, 142);
            this.txtDenominacion.MaxLength = 35;
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.ReadOnly = true;
            this.txtDenominacion.Size = new System.Drawing.Size(315, 22);
            this.txtDenominacion.TabIndex = 24;
            // 
            // txtCuit
            // 
            this.txtCuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuit.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtCuit.ForeColor = System.Drawing.Color.Black;
            this.txtCuit.Location = new System.Drawing.Point(160, 169);
            this.txtCuit.MaxLength = 15;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(100, 22);
            this.txtCuit.TabIndex = 27;
            // 
            // miLabel6
            // 
            this.miLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.miLabel6.BackColor = System.Drawing.Color.Transparent;
            this.miLabel6.Font = new System.Drawing.Font("Arial", 9F);
            this.miLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.miLabel6.Location = new System.Drawing.Point(0, 171);
            this.miLabel6.Name = "miLabel6";
            this.miLabel6.Size = new System.Drawing.Size(160, 15);
            this.miLabel6.TabIndex = 26;
            this.miLabel6.Text = "CUIT - Categoría IVA";
            this.miLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCategoriaIva
            // 
            this.txtCategoriaIva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCategoriaIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtCategoriaIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoriaIva.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtCategoriaIva.ForeColor = System.Drawing.Color.Black;
            this.txtCategoriaIva.Location = new System.Drawing.Point(262, 169);
            this.txtCategoriaIva.MaxLength = 23;
            this.txtCategoriaIva.Name = "txtCategoriaIva";
            this.txtCategoriaIva.ReadOnly = true;
            this.txtCategoriaIva.Size = new System.Drawing.Size(202, 22);
            this.txtCategoriaIva.TabIndex = 28;
            // 
            // cmbCuentaContable
            // 
            this.cmbCuentaContable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbCuentaContable.BackColor = System.Drawing.Color.White;
            this.cmbCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuentaContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCuentaContable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbCuentaContable.ForeColor = System.Drawing.Color.Black;
            this.cmbCuentaContable.FormattingEnabled = true;
            this.cmbCuentaContable.Location = new System.Drawing.Point(160, 196);
            this.cmbCuentaContable.Margin = new System.Windows.Forms.Padding(1);
            this.cmbCuentaContable.Name = "cmbCuentaContable";
            this.cmbCuentaContable.Size = new System.Drawing.Size(185, 22);
            this.cmbCuentaContable.Sorted = true;
            this.cmbCuentaContable.TabIndex = 30;
            // 
            // miLabel7
            // 
            this.miLabel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.miLabel7.BackColor = System.Drawing.Color.Transparent;
            this.miLabel7.Font = new System.Drawing.Font("Arial", 9F);
            this.miLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.miLabel7.Location = new System.Drawing.Point(0, 199);
            this.miLabel7.Name = "miLabel7";
            this.miLabel7.Size = new System.Drawing.Size(160, 15);
            this.miLabel7.TabIndex = 29;
            this.miLabel7.Text = "Cuenta contable";
            this.miLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAsociacionID
            // 
            this.txtAsociacionID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAsociacionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtAsociacionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsociacionID.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtAsociacionID.ForeColor = System.Drawing.Color.Black;
            this.txtAsociacionID.Location = new System.Drawing.Point(233, 12);
            this.txtAsociacionID.MaxLength = 10;
            this.txtAsociacionID.Name = "txtAsociacionID";
            this.txtAsociacionID.ReadOnly = true;
            this.txtAsociacionID.Size = new System.Drawing.Size(74, 22);
            this.txtAsociacionID.TabIndex = 1;
            // 
            // miLabel9
            // 
            this.miLabel9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.miLabel9.BackColor = System.Drawing.Color.Transparent;
            this.miLabel9.Font = new System.Drawing.Font("Arial", 9F);
            this.miLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.miLabel9.Location = new System.Drawing.Point(85, 15);
            this.miLabel9.Name = "miLabel9";
            this.miLabel9.Size = new System.Drawing.Size(148, 15);
            this.miLabel9.TabIndex = 0;
            this.miLabel9.Text = "Registro Asociado";
            this.miLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuitarAsociacion
            // 
            this.btnQuitarAsociacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuitarAsociacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitarAsociacion.BackgroundImage = global::CapaPresentacion.Properties.Resources.icon_delete32;
            this.btnQuitarAsociacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarAsociacion.FlatAppearance.BorderSize = 0;
            this.btnQuitarAsociacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuitarAsociacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuitarAsociacion.Font = new System.Drawing.Font("Arial", 9F);
            this.btnQuitarAsociacion.ForeColor = System.Drawing.Color.Black;
            this.btnQuitarAsociacion.Location = new System.Drawing.Point(332, 11);
            this.btnQuitarAsociacion.Name = "btnQuitarAsociacion";
            this.btnQuitarAsociacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnQuitarAsociacion.Size = new System.Drawing.Size(24, 24);
            this.btnQuitarAsociacion.TabIndex = 3;
            this.btnQuitarAsociacion.UseVisualStyleBackColor = false;
            this.btnQuitarAsociacion.Click += new System.EventHandler(this.btnQuitarAsociacion_Click);
            // 
            // btnBuscarAsociacion
            // 
            this.btnBuscarAsociacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscarAsociacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarAsociacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAsociacion.BackgroundImage")));
            this.btnBuscarAsociacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarAsociacion.FlatAppearance.BorderSize = 0;
            this.btnBuscarAsociacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarAsociacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscarAsociacion.Font = new System.Drawing.Font("Arial", 9F);
            this.btnBuscarAsociacion.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarAsociacion.Location = new System.Drawing.Point(308, 11);
            this.btnBuscarAsociacion.Name = "btnBuscarAsociacion";
            this.btnBuscarAsociacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscarAsociacion.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarAsociacion.TabIndex = 2;
            this.btnBuscarAsociacion.UseVisualStyleBackColor = false;
            this.btnBuscarAsociacion.Click += new System.EventHandler(this.btnBuscarAsociacion_Click);
            // 
            // miLabel10
            // 
            this.miLabel10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.miLabel10.BackColor = System.Drawing.Color.Transparent;
            this.miLabel10.Font = new System.Drawing.Font("Arial", 9F);
            this.miLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.miLabel10.Location = new System.Drawing.Point(7, 43);
            this.miLabel10.Name = "miLabel10";
            this.miLabel10.Size = new System.Drawing.Size(138, 15);
            this.miLabel10.TabIndex = 4;
            this.miLabel10.Text = "Comprobante Asociado";
            this.miLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAsociacionAfipCbteTipo
            // 
            this.txtAsociacionAfipCbteTipo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAsociacionAfipCbteTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtAsociacionAfipCbteTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsociacionAfipCbteTipo.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtAsociacionAfipCbteTipo.ForeColor = System.Drawing.Color.Black;
            this.txtAsociacionAfipCbteTipo.Location = new System.Drawing.Point(145, 40);
            this.txtAsociacionAfipCbteTipo.Name = "txtAsociacionAfipCbteTipo";
            this.txtAsociacionAfipCbteTipo.ReadOnly = true;
            this.txtAsociacionAfipCbteTipo.Size = new System.Drawing.Size(46, 22);
            this.txtAsociacionAfipCbteTipo.TabIndex = 5;
            // 
            // txtAsociacionAfipCbteTPV
            // 
            this.txtAsociacionAfipCbteTPV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAsociacionAfipCbteTPV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtAsociacionAfipCbteTPV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsociacionAfipCbteTPV.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtAsociacionAfipCbteTPV.ForeColor = System.Drawing.Color.Black;
            this.txtAsociacionAfipCbteTPV.Location = new System.Drawing.Point(190, 40);
            this.txtAsociacionAfipCbteTPV.MaxLength = 5;
            this.txtAsociacionAfipCbteTPV.Name = "txtAsociacionAfipCbteTPV";
            this.txtAsociacionAfipCbteTPV.ReadOnly = true;
            this.txtAsociacionAfipCbteTPV.Size = new System.Drawing.Size(39, 22);
            this.txtAsociacionAfipCbteTPV.TabIndex = 6;
            // 
            // txtAsociacionAfipCbteNro
            // 
            this.txtAsociacionAfipCbteNro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAsociacionAfipCbteNro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtAsociacionAfipCbteNro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsociacionAfipCbteNro.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtAsociacionAfipCbteNro.ForeColor = System.Drawing.Color.Black;
            this.txtAsociacionAfipCbteNro.Location = new System.Drawing.Point(228, 40);
            this.txtAsociacionAfipCbteNro.MaxLength = 8;
            this.txtAsociacionAfipCbteNro.Name = "txtAsociacionAfipCbteNro";
            this.txtAsociacionAfipCbteNro.ReadOnly = true;
            this.txtAsociacionAfipCbteNro.Size = new System.Drawing.Size(60, 22);
            this.txtAsociacionAfipCbteNro.TabIndex = 7;
            // 
            // txtAsociacionAfipCbteFecha
            // 
            this.txtAsociacionAfipCbteFecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAsociacionAfipCbteFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txtAsociacionAfipCbteFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsociacionAfipCbteFecha.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtAsociacionAfipCbteFecha.ForeColor = System.Drawing.Color.Black;
            this.txtAsociacionAfipCbteFecha.Location = new System.Drawing.Point(287, 40);
            this.txtAsociacionAfipCbteFecha.MaxLength = 10;
            this.txtAsociacionAfipCbteFecha.Name = "txtAsociacionAfipCbteFecha";
            this.txtAsociacionAfipCbteFecha.ReadOnly = true;
            this.txtAsociacionAfipCbteFecha.Size = new System.Drawing.Size(68, 22);
            this.txtAsociacionAfipCbteFecha.TabIndex = 8;
            // 
            // miLabel4
            // 
            this.miLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.miLabel4.BackColor = System.Drawing.Color.Transparent;
            this.miLabel4.Font = new System.Drawing.Font("Arial", 9F);
            this.miLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.miLabel4.Location = new System.Drawing.Point(24, 118);
            this.miLabel4.Name = "miLabel4";
            this.miLabel4.Size = new System.Drawing.Size(136, 15);
            this.miLabel4.TabIndex = 21;
            this.miLabel4.Text = "CAI (Código de Barras)";
            this.miLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumeroCodigoBarras
            // 
            this.txtNumeroCodigoBarras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNumeroCodigoBarras.BackColor = System.Drawing.Color.White;
            this.txtNumeroCodigoBarras.BeepOnError = true;
            this.txtNumeroCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroCodigoBarras.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtNumeroCodigoBarras.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroCodigoBarras.HidePromptOnLeave = true;
            this.txtNumeroCodigoBarras.Location = new System.Drawing.Point(160, 115);
            this.txtNumeroCodigoBarras.Mask = "999999999999999999999999999999999999999999";
            this.txtNumeroCodigoBarras.Name = "txtNumeroCodigoBarras";
            this.txtNumeroCodigoBarras.PromptChar = ' ';
            this.txtNumeroCodigoBarras.Size = new System.Drawing.Size(315, 22);
            this.txtNumeroCodigoBarras.TabIndex = 22;
            this.txtNumeroCodigoBarras.Click += new System.EventHandler(this.txtNumeroCodigoBarras_Click);
            this.txtNumeroCodigoBarras.Validated += new System.EventHandler(this.txtNumeroCodigoBarras_Validated);
            // 
            // pkrAfipCbteFecha
            // 
            this.pkrAfipCbteFecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pkrAfipCbteFecha.CalendarForeColor = System.Drawing.Color.Black;
            this.pkrAfipCbteFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.pkrAfipCbteFecha.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.pkrAfipCbteFecha.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.pkrAfipCbteFecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.pkrAfipCbteFecha.CustomFormat = "dd/MM/yyyy";
            this.pkrAfipCbteFecha.Font = new System.Drawing.Font("Arial", 9.5F);
            this.pkrAfipCbteFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrAfipCbteFecha.Location = new System.Drawing.Point(318, 88);
            this.pkrAfipCbteFecha.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.pkrAfipCbteFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.pkrAfipCbteFecha.Name = "pkrAfipCbteFecha";
            this.pkrAfipCbteFecha.Size = new System.Drawing.Size(102, 22);
            this.pkrAfipCbteFecha.TabIndex = 18;
            // 
            // btnBuscarFila
            // 
            this.btnBuscarFila.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscarFila.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarFila.BackgroundImage = global::CapaPresentacion.Properties.Resources.icon_find32;
            this.btnBuscarFila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarFila.FlatAppearance.BorderSize = 0;
            this.btnBuscarFila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarFila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscarFila.Font = new System.Drawing.Font("Arial", 9F);
            this.btnBuscarFila.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarFila.Location = new System.Drawing.Point(160, 438);
            this.btnBuscarFila.Name = "btnBuscarFila";
            this.btnBuscarFila.Size = new System.Drawing.Size(48, 23);
            this.btnBuscarFila.TabIndex = 36;
            this.btnBuscarFila.UseVisualStyleBackColor = false;
            this.btnBuscarFila.Click += new System.EventHandler(this.btnBuscarFila_Click);
            // 
            // miLabel8
            // 
            this.miLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.miLabel8.BackColor = System.Drawing.Color.Transparent;
            this.miLabel8.Font = new System.Drawing.Font("Arial", 9F);
            this.miLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.miLabel8.Location = new System.Drawing.Point(24, 226);
            this.miLabel8.Name = "miLabel8";
            this.miLabel8.Size = new System.Drawing.Size(136, 15);
            this.miLabel8.TabIndex = 31;
            this.miLabel8.Text = "Vencimiento de pago";
            this.miLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pkrPagoVto
            // 
            this.pkrPagoVto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pkrPagoVto.CalendarForeColor = System.Drawing.Color.Black;
            this.pkrPagoVto.CalendarMonthBackground = System.Drawing.Color.White;
            this.pkrPagoVto.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.pkrPagoVto.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.pkrPagoVto.Cursor = System.Windows.Forms.Cursors.Default;
            this.pkrPagoVto.CustomFormat = "dd/MM/yyyy";
            this.pkrPagoVto.Font = new System.Drawing.Font("Arial", 9.5F);
            this.pkrPagoVto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrPagoVto.Location = new System.Drawing.Point(160, 223);
            this.pkrPagoVto.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.pkrPagoVto.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.pkrPagoVto.Name = "pkrPagoVto";
            this.pkrPagoVto.Size = new System.Drawing.Size(102, 22);
            this.pkrPagoVto.TabIndex = 32;
            // 
            // groupAsociacion
            // 
            this.groupAsociacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupAsociacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupAsociacion.Controls.Add(this.txtAsociacionID);
            this.groupAsociacion.Controls.Add(this.miLabel9);
            this.groupAsociacion.Controls.Add(this.btnBuscarAsociacion);
            this.groupAsociacion.Controls.Add(this.btnQuitarAsociacion);
            this.groupAsociacion.Controls.Add(this.txtAsociacionAfipCbteTipo);
            this.groupAsociacion.Controls.Add(this.miLabel10);
            this.groupAsociacion.Controls.Add(this.txtAsociacionAfipCbteTPV);
            this.groupAsociacion.Controls.Add(this.txtAsociacionAfipCbteNro);
            this.groupAsociacion.Controls.Add(this.txtAsociacionAfipCbteFecha);
            this.groupAsociacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAsociacion.ForeColor = System.Drawing.Color.Gray;
            this.groupAsociacion.Location = new System.Drawing.Point(638, 55);
            this.groupAsociacion.Name = "groupAsociacion";
            this.groupAsociacion.Size = new System.Drawing.Size(362, 69);
            this.groupAsociacion.TabIndex = 60;
            this.groupAsociacion.TabStop = false;
            this.groupAsociacion.Text = "Asociación de comprobante";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 7F);
            this.label10.Location = new System.Drawing.Point(793, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Imp. Interno";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImpuestoInterno
            // 
            this.txtImpuestoInterno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtImpuestoInterno.BackColor = System.Drawing.Color.White;
            this.txtImpuestoInterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImpuestoInterno.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.txtImpuestoInterno.ForeColor = System.Drawing.Color.Black;
            this.txtImpuestoInterno.Location = new System.Drawing.Point(793, 436);
            this.txtImpuestoInterno.MaxLength = 9;
            this.txtImpuestoInterno.Name = "txtImpuestoInterno";
            this.txtImpuestoInterno.Size = new System.Drawing.Size(94, 18);
            this.txtImpuestoInterno.TabIndex = 57;
            this.txtImpuestoInterno.Text = "0.00";
            this.txtImpuestoInterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtImpuestoInterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImpuestoInterno_KeyPress);
            this.txtImpuestoInterno.Validated += new System.EventHandler(this.txtImpuestoInterno_Validated);
            // 
            // lblDescuentoPorcentual
            // 
            this.lblDescuentoPorcentual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDescuentoPorcentual.BackColor = System.Drawing.Color.White;
            this.lblDescuentoPorcentual.Font = new System.Drawing.Font("Arial", 7.25F, System.Drawing.FontStyle.Bold);
            this.lblDescuentoPorcentual.Location = new System.Drawing.Point(275, 416);
            this.lblDescuentoPorcentual.Name = "lblDescuentoPorcentual";
            this.lblDescuentoPorcentual.Size = new System.Drawing.Size(32, 13);
            this.lblDescuentoPorcentual.TabIndex = 38;
            this.lblDescuentoPorcentual.Text = "00.00";
            this.lblDescuentoPorcentual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 7F);
            this.label1.Location = new System.Drawing.Point(211, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Descuento %";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPercepcionLH
            // 
            this.txtPercepcionLH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPercepcionLH.BackColor = System.Drawing.Color.White;
            this.txtPercepcionLH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPercepcionLH.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.txtPercepcionLH.ForeColor = System.Drawing.Color.Black;
            this.txtPercepcionLH.Location = new System.Drawing.Point(588, 441);
            this.txtPercepcionLH.MaxLength = 9;
            this.txtPercepcionLH.Name = "txtPercepcionLH";
            this.txtPercepcionLH.Size = new System.Drawing.Size(65, 14);
            this.txtPercepcionLH.TabIndex = 51;
            this.txtPercepcionLH.Text = "0.00";
            this.txtPercepcionLH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercepcionLH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercepcionLH_KeyPress);
            this.txtPercepcionLH.Validated += new System.EventHandler(this.txtPercepcionLH_Validated);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 7F);
            this.label7.Location = new System.Drawing.Point(525, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Percep. LH";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPercepcionIIBB
            // 
            this.txtPercepcionIIBB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPercepcionIIBB.BackColor = System.Drawing.Color.White;
            this.txtPercepcionIIBB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPercepcionIIBB.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.txtPercepcionIIBB.ForeColor = System.Drawing.Color.Black;
            this.txtPercepcionIIBB.Location = new System.Drawing.Point(588, 419);
            this.txtPercepcionIIBB.MaxLength = 9;
            this.txtPercepcionIIBB.Name = "txtPercepcionIIBB";
            this.txtPercepcionIIBB.Size = new System.Drawing.Size(65, 14);
            this.txtPercepcionIIBB.TabIndex = 49;
            this.txtPercepcionIIBB.Text = "0.00";
            this.txtPercepcionIIBB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercepcionIIBB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercepcionIIBB_KeyPress);
            this.txtPercepcionIIBB.Validated += new System.EventHandler(this.txtPercepcionIIBB_Validated);
            // 
            // txtPercepcionIVA
            // 
            this.txtPercepcionIVA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPercepcionIVA.BackColor = System.Drawing.Color.White;
            this.txtPercepcionIVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPercepcionIVA.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.txtPercepcionIVA.ForeColor = System.Drawing.Color.Black;
            this.txtPercepcionIVA.Location = new System.Drawing.Point(722, 419);
            this.txtPercepcionIVA.MaxLength = 9;
            this.txtPercepcionIVA.Name = "txtPercepcionIVA";
            this.txtPercepcionIVA.Size = new System.Drawing.Size(65, 14);
            this.txtPercepcionIVA.TabIndex = 53;
            this.txtPercepcionIVA.Text = "0.00";
            this.txtPercepcionIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercepcionIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercepcionIVA_KeyPress);
            this.txtPercepcionIVA.Validated += new System.EventHandler(this.txtPercepcionIVA_Validated);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 7F);
            this.label8.Location = new System.Drawing.Point(659, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Percep. IVA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(895, 436);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 18);
            this.lblTotal.TabIndex = 59;
            this.lblTotal.Tag = "";
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(895, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "TOTAL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox14.BackColor = System.Drawing.Color.White;
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox14.Location = new System.Drawing.Point(892, 415);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(108, 16);
            this.pictureBox14.TabIndex = 279;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox15.BackColor = System.Drawing.Color.White;
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox15.Location = new System.Drawing.Point(892, 430);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(108, 30);
            this.pictureBox15.TabIndex = 280;
            this.pictureBox15.TabStop = false;
            // 
            // txtNoGravado
            // 
            this.txtNoGravado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNoGravado.BackColor = System.Drawing.Color.White;
            this.txtNoGravado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoGravado.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.txtNoGravado.ForeColor = System.Drawing.Color.Black;
            this.txtNoGravado.Location = new System.Drawing.Point(722, 441);
            this.txtNoGravado.MaxLength = 9;
            this.txtNoGravado.Name = "txtNoGravado";
            this.txtNoGravado.Size = new System.Drawing.Size(65, 14);
            this.txtNoGravado.TabIndex = 55;
            this.txtNoGravado.Text = "0.00";
            this.txtNoGravado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNoGravado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoGravado_KeyPress);
            this.txtNoGravado.Validated += new System.EventHandler(this.txtNoGravado_Validated);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 7F);
            this.label9.Location = new System.Drawing.Point(659, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "No Grav.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(522, 437);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(135, 23);
            this.pictureBox7.TabIndex = 278;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 7F);
            this.label6.Location = new System.Drawing.Point(525, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Percep. IIBB";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(522, 415);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(135, 23);
            this.pictureBox6.TabIndex = 277;
            this.pictureBox6.TabStop = false;
            // 
            // lblIVA270
            // 
            this.lblIVA270.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblIVA270.BackColor = System.Drawing.Color.White;
            this.lblIVA270.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA270.Location = new System.Drawing.Point(452, 444);
            this.lblIVA270.Name = "lblIVA270";
            this.lblIVA270.Size = new System.Drawing.Size(65, 15);
            this.lblIVA270.TabIndex = 47;
            this.lblIVA270.Text = "0.00";
            this.lblIVA270.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIVA105
            // 
            this.lblIVA105.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblIVA105.BackColor = System.Drawing.Color.White;
            this.lblIVA105.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA105.Location = new System.Drawing.Point(452, 416);
            this.lblIVA105.Name = "lblIVA105";
            this.lblIVA105.Size = new System.Drawing.Size(65, 15);
            this.lblIVA105.TabIndex = 43;
            this.lblIVA105.Text = "0.00";
            this.lblIVA105.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIVA210
            // 
            this.lblIVA210.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblIVA210.BackColor = System.Drawing.Color.White;
            this.lblIVA210.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA210.Location = new System.Drawing.Point(452, 430);
            this.lblIVA210.Name = "lblIVA210";
            this.lblIVA210.Size = new System.Drawing.Size(65, 15);
            this.lblIVA210.TabIndex = 45;
            this.lblIVA210.Text = "0.00";
            this.lblIVA210.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label5.Location = new System.Drawing.Point(418, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "%27.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label4.Location = new System.Drawing.Point(418, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "%21.0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label3.Location = new System.Drawing.Point(418, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "%10.5";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(415, 415);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(105, 45);
            this.pictureBox5.TabIndex = 276;
            this.pictureBox5.TabStop = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSubTotal.BackColor = System.Drawing.Color.White;
            this.lblSubTotal.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.Location = new System.Drawing.Point(314, 436);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(99, 18);
            this.lblSubTotal.TabIndex = 41;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(311, 430);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(105, 30);
            this.pictureBox4.TabIndex = 275;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 7F);
            this.label2.Location = new System.Drawing.Point(314, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "SubTotal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(311, 415);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 16);
            this.pictureBox3.TabIndex = 274;
            this.pictureBox3.TabStop = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDescuento.BackColor = System.Drawing.Color.White;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold);
            this.txtDescuento.ForeColor = System.Drawing.Color.Black;
            this.txtDescuento.Location = new System.Drawing.Point(212, 436);
            this.txtDescuento.MaxLength = 9;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(94, 18);
            this.txtDescuento.TabIndex = 39;
            this.txtDescuento.Text = "0.00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            this.txtDescuento.Validated += new System.EventHandler(this.txtDescuento_Validated);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(209, 430);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 30);
            this.pictureBox2.TabIndex = 273;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(209, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 16);
            this.pictureBox1.TabIndex = 272;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Location = new System.Drawing.Point(656, 437);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(135, 23);
            this.pictureBox9.TabIndex = 284;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(656, 415);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(135, 23);
            this.pictureBox8.TabIndex = 283;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox11.Location = new System.Drawing.Point(790, 430);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 30);
            this.pictureBox11.TabIndex = 282;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Location = new System.Drawing.Point(790, 415);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 16);
            this.pictureBox10.TabIndex = 281;
            this.pictureBox10.TabStop = false;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarProveedor.BackgroundImage")));
            this.btnBuscarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Arial", 9F);
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(476, 141);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscarProveedor.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarProveedor.TabIndex = 25;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // cmbAfipCbteTipo
            // 
            this.cmbAfipCbteTipo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbAfipCbteTipo.BackColor = System.Drawing.Color.White;
            this.cmbAfipCbteTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAfipCbteTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAfipCbteTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbAfipCbteTipo.ForeColor = System.Drawing.Color.Black;
            this.cmbAfipCbteTipo.FormattingEnabled = true;
            this.cmbAfipCbteTipo.Items.AddRange(new object[] {
            "FAC-A",
            "FAC-B",
            "FAC-C",
            "FAC-M",
            "NCR-A",
            "NCR-B",
            "NCR-C",
            "NCR-M",
            "NDE-A",
            "NDE-B",
            "NDE-C",
            "NDE-M",
            "REM-R"});
            this.cmbAfipCbteTipo.Location = new System.Drawing.Point(160, 88);
            this.cmbAfipCbteTipo.Margin = new System.Windows.Forms.Padding(1);
            this.cmbAfipCbteTipo.Name = "cmbAfipCbteTipo";
            this.cmbAfipCbteTipo.Size = new System.Drawing.Size(62, 22);
            this.cmbAfipCbteTipo.Sorted = true;
            this.cmbAfipCbteTipo.TabIndex = 15;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1006, 687);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtImpuestoInterno);
            this.Controls.Add(this.lblDescuentoPorcentual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPercepcionLH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPercepcionIIBB);
            this.Controls.Add(this.txtPercepcionIVA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.txtNoGravado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblIVA270);
            this.Controls.Add(this.lblIVA105);
            this.Controls.Add(this.lblIVA210);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pkrPagoVto);
            this.Controls.Add(this.miLabel8);
            this.Controls.Add(this.btnBuscarFila);
            this.Controls.Add(this.pkrAfipCbteFecha);
            this.Controls.Add(this.txtNumeroCodigoBarras);
            this.Controls.Add(this.cmbCuentaContable);
            this.Controls.Add(this.miLabel7);
            this.Controls.Add(this.txtCategoriaIva);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.miLabel6);
            this.Controls.Add(this.miLabel5);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtAfipCbteNro);
            this.Controls.Add(this.txtAfipCbteTPV);
            this.Controls.Add(this.miLabel2);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.miLabel1);
            this.Controls.Add(this.btnQuitarFila);
            this.Controls.Add(this.btnAgregarFila);
            this.Controls.Add(this.gridDetalle);
            this.Controls.Add(this.miLabel4);
            this.Controls.Add(this.groupAsociacion);
            this.Controls.Add(this.cmbAfipCbteTipo);
            this.Name = "FormCompra";
            this.Text = "Comprobantes de Compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.Controls.SetChildIndex(this.cmbAfipCbteTipo, 0);
            this.Controls.SetChildIndex(this.groupAsociacion, 0);
            this.Controls.SetChildIndex(this.miLabel4, 0);
            this.Controls.SetChildIndex(this.gridDetalle, 0);
            this.Controls.SetChildIndex(this.btnAgregarFila, 0);
            this.Controls.SetChildIndex(this.btnQuitarFila, 0);
            this.Controls.SetChildIndex(this.miLabel1, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.cmbPeriodo, 0);
            this.Controls.SetChildIndex(this.txtPeriodo, 0);
            this.Controls.SetChildIndex(this.miLabel2, 0);
            this.Controls.SetChildIndex(this.txtAfipCbteTPV, 0);
            this.Controls.SetChildIndex(this.txtAfipCbteNro, 0);
            this.Controls.SetChildIndex(this.txtDenominacion, 0);
            this.Controls.SetChildIndex(this.miLabel5, 0);
            this.Controls.SetChildIndex(this.miLabel6, 0);
            this.Controls.SetChildIndex(this.txtCuit, 0);
            this.Controls.SetChildIndex(this.txtCategoriaIva, 0);
            this.Controls.SetChildIndex(this.miLabel7, 0);
            this.Controls.SetChildIndex(this.cmbCuentaContable, 0);
            this.Controls.SetChildIndex(this.txtNumeroCodigoBarras, 0);
            this.Controls.SetChildIndex(this.pkrAfipCbteFecha, 0);
            this.Controls.SetChildIndex(this.btnBuscarFila, 0);
            this.Controls.SetChildIndex(this.miLabel8, 0);
            this.Controls.SetChildIndex(this.pkrPagoVto, 0);
            this.Controls.SetChildIndex(this.pictureBox10, 0);
            this.Controls.SetChildIndex(this.pictureBox11, 0);
            this.Controls.SetChildIndex(this.pictureBox8, 0);
            this.Controls.SetChildIndex(this.pictureBox9, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.txtDescuento, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.lblSubTotal, 0);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblIVA210, 0);
            this.Controls.SetChildIndex(this.lblIVA105, 0);
            this.Controls.SetChildIndex(this.lblIVA270, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.pictureBox7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtNoGravado, 0);
            this.Controls.SetChildIndex(this.pictureBox15, 0);
            this.Controls.SetChildIndex(this.pictureBox14, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtPercepcionIVA, 0);
            this.Controls.SetChildIndex(this.txtPercepcionIIBB, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtPercepcionLH, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblDescuentoPorcentual, 0);
            this.Controls.SetChildIndex(this.txtImpuestoInterno, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.btnBuscarProveedor, 0);
            this.Controls.SetChildIndex(this.btnExcel_Registro, 0);
            this.Controls.SetChildIndex(this.btnPDF_Registro, 0);
            this.Controls.SetChildIndex(this.labelPublicacion, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.panelLista, 0);
            this.Controls.SetChildIndex(this.labelTitulo, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.labelUsuario, 0);
            this.Controls.SetChildIndex(this.btnAnular, 0);
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo)).EndInit();
            this.groupAsociacion.ResumeLayout(false);
            this.groupAsociacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Biblioteca.Controles.MiButton24x24 btnQuitarFila;
        public Biblioteca.Controles.MiButton24x24 btnAgregarFila;
        public Biblioteca.Controles.MiGridEdit gridDetalle;
        public System.Windows.Forms.Label lblCatalagoTitulo7;
        private Biblioteca.Controles.MiLabel miLabel1;
        private Biblioteca.Controles.MiTextBoxRead txtID;
        private Biblioteca.Controles.MiTextBoxRead txtFecha;
        private Biblioteca.Controles.MiComboBox cmbPeriodo;
        private Biblioteca.Controles.MiNumericUpDown txtPeriodo;
        private Biblioteca.Controles.MiLabel miLabel2;
        private Biblioteca.Controles.MiTextBox txtAfipCbteTPV;
        private Biblioteca.Controles.MiTextBox txtAfipCbteNro;
        private Biblioteca.Controles.MiLabel miLabel5;
        private Biblioteca.Controles.MiTextBox txtDenominacion;
        private Biblioteca.Controles.MiTextBoxRead txtCuit;
        private Biblioteca.Controles.MiLabel miLabel6;
        private Biblioteca.Controles.MiTextBoxRead txtCategoriaIva;
        private Biblioteca.Controles.MiComboBox cmbCuentaContable;
        private Biblioteca.Controles.MiLabel miLabel7;
        private Biblioteca.Controles.MiTextBoxRead txtAsociacionID;
        private Biblioteca.Controles.MiLabel miLabel9;
        private Biblioteca.Controles.MiButtonFind btnQuitarAsociacion;
        private Biblioteca.Controles.MiButtonFind btnBuscarAsociacion;
        private Biblioteca.Controles.MiLabel miLabel10;
        private Biblioteca.Controles.MiTextBoxRead txtAsociacionAfipCbteTipo;
        private Biblioteca.Controles.MiTextBoxRead txtAsociacionAfipCbteTPV;
        private Biblioteca.Controles.MiTextBoxRead txtAsociacionAfipCbteNro;
        private Biblioteca.Controles.MiTextBoxRead txtAsociacionAfipCbteFecha;
        private Biblioteca.Controles.MiLabel miLabel4;
        private Biblioteca.Controles.MiMaskedTextBox txtNumeroCodigoBarras;
        private Biblioteca.Controles.MiDateTimePicker pkrAfipCbteFecha;
        public Biblioteca.Controles.MiButtonBase btnBuscarFila;
        private Biblioteca.Controles.MiLabel miLabel8;
        private Biblioteca.Controles.MiDateTimePicker pkrPagoVto;
        private System.Windows.Forms.GroupBox groupAsociacion;
        public System.Windows.Forms.Label label10;
        public Biblioteca.Controles.MiTextBox txtImpuestoInterno;
        public System.Windows.Forms.Label lblDescuentoPorcentual;
        public System.Windows.Forms.Label label1;
        public Biblioteca.Controles.MiTextBox txtPercepcionLH;
        public System.Windows.Forms.Label label7;
        public Biblioteca.Controles.MiTextBox txtPercepcionIIBB;
        public Biblioteca.Controles.MiTextBox txtPercepcionIVA;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.PictureBox pictureBox14;
        public System.Windows.Forms.PictureBox pictureBox15;
        public Biblioteca.Controles.MiTextBox txtNoGravado;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.Label lblIVA270;
        public System.Windows.Forms.Label lblIVA105;
        public System.Windows.Forms.Label lblIVA210;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lblSubTotal;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public Biblioteca.Controles.MiTextBox txtDescuento;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.PictureBox pictureBox10;
        private Biblioteca.Controles.MiButtonFind btnBuscarProveedor;
        private Biblioteca.Controles.MiComboBox cmbAfipCbteTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDenominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColUnidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColAlicuotaIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBaseIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNeto;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColCentroCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColModificacionID;
    }
}
