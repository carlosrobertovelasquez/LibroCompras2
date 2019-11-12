namespace CapaPresentacion
{
    partial class FrmLibroCompras
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtNumDoc = new System.Windows.Forms.TextBox();
            this.TxtNumRegistro = new System.Windows.Forms.TextBox();
            this.TxtIdExcl = new System.Windows.Forms.TextBox();
            this.TxtNomProv = new System.Windows.Forms.TextBox();
            this.TxtImpuEspe = new System.Windows.Forms.TextBox();
            this.TxtCompExtImport = new System.Windows.Forms.TextBox();
            this.TxtCompExtInter = new System.Windows.Forms.TextBox();
            this.TxtCompGraLocales = new System.Windows.Forms.TextBox();
            this.TxtCompGraImportaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCompGrInternacionales = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTotalCompras = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtIvaUnoPorcientoRetenido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtRet_Suj_Exc_Cal_Contri = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtComprasExcluidas = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtRetencionATerceros = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtFovial = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtConsTrans = new System.Windows.Forms.TextBox();
            this.CmbDentroCA = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtCompExtLocales = new System.Windows.Forms.TextBox();
            this.TxtFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CmbMes = new System.Windows.Forms.ComboBox();
            this.CmbAno = new System.Windows.Forms.ComboBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TxtCreditoFiscal = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CmbLibro = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbEliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CmdExcel = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.CmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(865, 540);
            this.dataGridView1.TabIndex = 45;
            // 
            // TxtNumDoc
            // 
            this.TxtNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumDoc.Location = new System.Drawing.Point(1210, 30);
            this.TxtNumDoc.Name = "TxtNumDoc";
            this.TxtNumDoc.Size = new System.Drawing.Size(115, 26);
            this.TxtNumDoc.TabIndex = 1;
            this.TxtNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNumDoc.Enter += new System.EventHandler(this.textBox1_Enter);
            this.TxtNumDoc.Leave += new System.EventHandler(this.textBox1_Leave);
            this.TxtNumDoc.Validated += new System.EventHandler(this.TxtNumDoc_Validated);
            // 
            // TxtNumRegistro
            // 
            this.TxtNumRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumRegistro.Location = new System.Drawing.Point(988, 62);
            this.TxtNumRegistro.Name = "TxtNumRegistro";
            this.TxtNumRegistro.Size = new System.Drawing.Size(99, 26);
            this.TxtNumRegistro.TabIndex = 2;
            this.TxtNumRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNumRegistro.Enter += new System.EventHandler(this.textBox2_Enter);
            this.TxtNumRegistro.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // TxtIdExcl
            // 
            this.TxtIdExcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdExcl.Location = new System.Drawing.Point(1210, 59);
            this.TxtIdExcl.Name = "TxtIdExcl";
            this.TxtIdExcl.Size = new System.Drawing.Size(114, 26);
            this.TxtIdExcl.TabIndex = 3;
            this.TxtIdExcl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtIdExcl.Enter += new System.EventHandler(this.textBox3_Enter);
            this.TxtIdExcl.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // TxtNomProv
            // 
            this.TxtNomProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomProv.Location = new System.Drawing.Point(991, 93);
            this.TxtNomProv.Name = "TxtNomProv";
            this.TxtNomProv.Size = new System.Drawing.Size(333, 26);
            this.TxtNomProv.TabIndex = 4;
            this.TxtNomProv.TextChanged += new System.EventHandler(this.TxtNomProv_TextChanged);
            this.TxtNomProv.Enter += new System.EventHandler(this.textBox4_Enter);
            this.TxtNomProv.Leave += new System.EventHandler(this.textBox4_Leave);
            this.TxtNomProv.Validated += new System.EventHandler(this.TxtNomProv_Validated);
            // 
            // TxtImpuEspe
            // 
            this.TxtImpuEspe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImpuEspe.Location = new System.Drawing.Point(994, 124);
            this.TxtImpuEspe.Name = "TxtImpuEspe";
            this.TxtImpuEspe.Size = new System.Drawing.Size(100, 26);
            this.TxtImpuEspe.TabIndex = 5;
            this.TxtImpuEspe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtImpuEspe.Enter += new System.EventHandler(this.textBox5_Enter);
            this.TxtImpuEspe.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // TxtCompExtImport
            // 
            this.TxtCompExtImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompExtImport.Location = new System.Drawing.Point(1114, 186);
            this.TxtCompExtImport.Name = "TxtCompExtImport";
            this.TxtCompExtImport.Size = new System.Drawing.Size(148, 26);
            this.TxtCompExtImport.TabIndex = 7;
            this.TxtCompExtImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCompExtImport.TextChanged += new System.EventHandler(this.TxtCompExtImport_TextChanged);
            this.TxtCompExtImport.Enter += new System.EventHandler(this.TxtCompExtImport_Enter);
            this.TxtCompExtImport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCompExtImport_KeyPress);
            this.TxtCompExtImport.Leave += new System.EventHandler(this.TxtCompExtImport_Leave);
            // 
            // TxtCompExtInter
            // 
            this.TxtCompExtInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompExtInter.Location = new System.Drawing.Point(1114, 218);
            this.TxtCompExtInter.Name = "TxtCompExtInter";
            this.TxtCompExtInter.Size = new System.Drawing.Size(148, 26);
            this.TxtCompExtInter.TabIndex = 8;
            this.TxtCompExtInter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCompExtInter.Enter += new System.EventHandler(this.TxtCompExtInter_Enter);
            this.TxtCompExtInter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCompExtInter_KeyPress);
            this.TxtCompExtInter.Leave += new System.EventHandler(this.TxtCompExtInter_Leave);
            // 
            // TxtCompGraLocales
            // 
            this.TxtCompGraLocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompGraLocales.Location = new System.Drawing.Point(1114, 250);
            this.TxtCompGraLocales.Name = "TxtCompGraLocales";
            this.TxtCompGraLocales.Size = new System.Drawing.Size(148, 26);
            this.TxtCompGraLocales.TabIndex = 9;
            this.TxtCompGraLocales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCompGraLocales.Enter += new System.EventHandler(this.TxtCompGraLocales_Enter);
            this.TxtCompGraLocales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCompGraLocales_KeyPress);
            this.TxtCompGraLocales.Leave += new System.EventHandler(this.TxtCompGraLocales_Leave);
            // 
            // TxtCompGraImportaciones
            // 
            this.TxtCompGraImportaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompGraImportaciones.Location = new System.Drawing.Point(1114, 282);
            this.TxtCompGraImportaciones.Name = "TxtCompGraImportaciones";
            this.TxtCompGraImportaciones.Size = new System.Drawing.Size(148, 26);
            this.TxtCompGraImportaciones.TabIndex = 10;
            this.TxtCompGraImportaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCompGraImportaciones.Enter += new System.EventHandler(this.TxtCompGraImportaciones_Enter);
            this.TxtCompGraImportaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCompGraImportaciones_KeyPress);
            this.TxtCompGraImportaciones.Leave += new System.EventHandler(this.TxtCompGraImportaciones_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(893, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha Emision :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1094, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero Doc:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(893, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "N. Registro:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1094, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Identifi Exclui.:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(882, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nom del Prov.";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(914, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Comp Grav Impotaciones:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(954, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Comp. Gra Locales :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(893, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Impu. Espe. :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(966, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Comp.Ext Locales:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(912, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Comp. Ext Importaciones :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(924, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Comp.Ext Internaciones:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(909, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Comp Grav Internaciones :";
            // 
            // TxtCompGrInternacionales
            // 
            this.TxtCompGrInternacionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompGrInternacionales.Location = new System.Drawing.Point(1114, 314);
            this.TxtCompGrInternacionales.Name = "TxtCompGrInternacionales";
            this.TxtCompGrInternacionales.Size = new System.Drawing.Size(148, 26);
            this.TxtCompGrInternacionales.TabIndex = 11;
            this.TxtCompGrInternacionales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCompGrInternacionales.TextChanged += new System.EventHandler(this.TxtCompGrInternacionales_TextChanged);
            this.TxtCompGrInternacionales.Enter += new System.EventHandler(this.TxtCompGrInternacionales_Enter);
            this.TxtCompGrInternacionales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCompGrInternacionales_KeyPress);
            this.TxtCompGrInternacionales.Leave += new System.EventHandler(this.TxtCompGrInternacionales_Leave);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(987, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Total Compras :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // TxtTotalCompras
            // 
            this.TxtTotalCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalCompras.Location = new System.Drawing.Point(1114, 378);
            this.TxtTotalCompras.Name = "TxtTotalCompras";
            this.TxtTotalCompras.Size = new System.Drawing.Size(148, 26);
            this.TxtTotalCompras.TabIndex = 13;
            this.TxtTotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTotalCompras.Enter += new System.EventHandler(this.TxtTotalCompras_Enter);
            this.TxtTotalCompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotalCompras_KeyPress);
            this.TxtTotalCompras.Leave += new System.EventHandler(this.TxtTotalCompras_Leave);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(969, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Iva 1%  Retenido :";
            // 
            // TxtIvaUnoPorcientoRetenido
            // 
            this.TxtIvaUnoPorcientoRetenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIvaUnoPorcientoRetenido.Location = new System.Drawing.Point(1114, 410);
            this.TxtIvaUnoPorcientoRetenido.Name = "TxtIvaUnoPorcientoRetenido";
            this.TxtIvaUnoPorcientoRetenido.Size = new System.Drawing.Size(148, 26);
            this.TxtIvaUnoPorcientoRetenido.TabIndex = 14;
            this.TxtIvaUnoPorcientoRetenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtIvaUnoPorcientoRetenido.Enter += new System.EventHandler(this.TxtIvaUnoPorcientoRetenido_Enter);
            this.TxtIvaUnoPorcientoRetenido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIvaUnoPorcientoRetenido_KeyPress);
            this.TxtIvaUnoPorcientoRetenido.Leave += new System.EventHandler(this.TxtIvaUnoPorcientoRetenido_Leave);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(881, 444);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(233, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Ret Suj Excl de la Cal de Contr :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // TxtRet_Suj_Exc_Cal_Contri
            // 
            this.TxtRet_Suj_Exc_Cal_Contri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRet_Suj_Exc_Cal_Contri.Location = new System.Drawing.Point(1115, 442);
            this.TxtRet_Suj_Exc_Cal_Contri.Name = "TxtRet_Suj_Exc_Cal_Contri";
            this.TxtRet_Suj_Exc_Cal_Contri.Size = new System.Drawing.Size(148, 26);
            this.TxtRet_Suj_Exc_Cal_Contri.TabIndex = 15;
            this.TxtRet_Suj_Exc_Cal_Contri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtRet_Suj_Exc_Cal_Contri.Enter += new System.EventHandler(this.TxtRet_Suj_Exc_Cal_Contri_Enter);
            this.TxtRet_Suj_Exc_Cal_Contri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRet_Suj_Exc_Cal_Contri_KeyPress);
            this.TxtRet_Suj_Exc_Cal_Contri.Leave += new System.EventHandler(this.TxtRet_Suj_Exc_Cal_Contri_Leave);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(959, 478);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Compras Excluidas:";
            // 
            // TxtComprasExcluidas
            // 
            this.TxtComprasExcluidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComprasExcluidas.Location = new System.Drawing.Point(1114, 474);
            this.TxtComprasExcluidas.Name = "TxtComprasExcluidas";
            this.TxtComprasExcluidas.Size = new System.Drawing.Size(148, 26);
            this.TxtComprasExcluidas.TabIndex = 16;
            this.TxtComprasExcluidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtComprasExcluidas.Enter += new System.EventHandler(this.TxtComprasExcluidas_Enter);
            this.TxtComprasExcluidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtComprasExcluidas_KeyPress);
            this.TxtComprasExcluidas.Leave += new System.EventHandler(this.TxtComprasExcluidas_Leave);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(983, 510);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Ret A Terceros :";
            // 
            // TxtRetencionATerceros
            // 
            this.TxtRetencionATerceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRetencionATerceros.Location = new System.Drawing.Point(1114, 506);
            this.TxtRetencionATerceros.Name = "TxtRetencionATerceros";
            this.TxtRetencionATerceros.Size = new System.Drawing.Size(148, 26);
            this.TxtRetencionATerceros.TabIndex = 17;
            this.TxtRetencionATerceros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtRetencionATerceros.Enter += new System.EventHandler(this.TxtRetencionATerceros_Enter);
            this.TxtRetencionATerceros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRetencionATerceros_KeyPress);
            this.TxtRetencionATerceros.Leave += new System.EventHandler(this.TxtRetencionATerceros_Leave);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1120, 554);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "Fovial:";
            // 
            // TxtFovial
            // 
            this.TxtFovial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFovial.Location = new System.Drawing.Point(1218, 547);
            this.TxtFovial.Name = "TxtFovial";
            this.TxtFovial.Size = new System.Drawing.Size(100, 26);
            this.TxtFovial.TabIndex = 19;
            this.TxtFovial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtFovial.Enter += new System.EventHandler(this.TxtFovial_Enter);
            this.TxtFovial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFovial_KeyPress);
            this.TxtFovial.Leave += new System.EventHandler(this.TxtFovial_Leave);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(893, 550);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 20);
            this.label19.TabIndex = 38;
            this.label19.Text = "ConTras :";
            // 
            // TxtConsTrans
            // 
            this.TxtConsTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConsTrans.Location = new System.Drawing.Point(988, 550);
            this.TxtConsTrans.Name = "TxtConsTrans";
            this.TxtConsTrans.Size = new System.Drawing.Size(99, 26);
            this.TxtConsTrans.TabIndex = 18;
            this.TxtConsTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtConsTrans.Enter += new System.EventHandler(this.TxtConsTrans_Enter);
            this.TxtConsTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConsTrans_KeyPress);
            this.TxtConsTrans.Leave += new System.EventHandler(this.TxtConsTrans_Leave);
            // 
            // CmbDentroCA
            // 
            this.CmbDentroCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDentroCA.FormattingEnabled = true;
            this.CmbDentroCA.ItemHeight = 20;
            this.CmbDentroCA.Location = new System.Drawing.Point(991, 585);
            this.CmbDentroCA.Name = "CmbDentroCA";
            this.CmbDentroCA.Size = new System.Drawing.Size(53, 28);
            this.CmbDentroCA.TabIndex = 20;
            this.CmbDentroCA.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.CmbDentroCA.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(883, 589);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 20);
            this.label20.TabIndex = 40;
            this.label20.Text = "Dento de CA :";
            // 
            // TxtCompExtLocales
            // 
            this.TxtCompExtLocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompExtLocales.Location = new System.Drawing.Point(1114, 154);
            this.TxtCompExtLocales.Name = "TxtCompExtLocales";
            this.TxtCompExtLocales.Size = new System.Drawing.Size(148, 26);
            this.TxtCompExtLocales.TabIndex = 6;
            this.TxtCompExtLocales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCompExtLocales.TextChanged += new System.EventHandler(this.label1_Click);
            this.TxtCompExtLocales.Enter += new System.EventHandler(this.TxtCompExtLocales_Enter);
            this.TxtCompExtLocales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCompExtLocales_KeyPress);
            this.TxtCompExtLocales.Leave += new System.EventHandler(this.TxtCompExtLocales_Leave);
            // 
            // TxtFechaEmision
            // 
            this.TxtFechaEmision.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaEmision.Location = new System.Drawing.Point(988, 31);
            this.TxtFechaEmision.Name = "TxtFechaEmision";
            this.TxtFechaEmision.Size = new System.Drawing.Size(99, 26);
            this.TxtFechaEmision.TabIndex = 0;
            this.TxtFechaEmision.Enter += new System.EventHandler(this.TxtFechaEmision_Enter);
            this.TxtFechaEmision.Leave += new System.EventHandler(this.TxtFechaEmision_Leave);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(1045, 641);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(200, 38);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "AGREGAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CmbMes
            // 
            this.CmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMes.FormattingEnabled = true;
            this.CmbMes.Location = new System.Drawing.Point(186, 19);
            this.CmbMes.Name = "CmbMes";
            this.CmbMes.Size = new System.Drawing.Size(121, 28);
            this.CmbMes.TabIndex = 51;
            // 
            // CmbAno
            // 
            this.CmbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAno.FormattingEnabled = true;
            this.CmbAno.Location = new System.Drawing.Point(361, 19);
            this.CmbAno.Name = "CmbAno";
            this.CmbAno.Size = new System.Drawing.Size(121, 28);
            this.CmbAno.TabIndex = 52;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(531, 17);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(120, 32);
            this.BtnConsultar.TabIndex = 53;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TxtCreditoFiscal
            // 
            this.TxtCreditoFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCreditoFiscal.Location = new System.Drawing.Point(1114, 346);
            this.TxtCreditoFiscal.Name = "TxtCreditoFiscal";
            this.TxtCreditoFiscal.Size = new System.Drawing.Size(148, 26);
            this.TxtCreditoFiscal.TabIndex = 12;
            this.TxtCreditoFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCreditoFiscal.Enter += new System.EventHandler(this.TxtCreditoFiscal_Enter);
            this.TxtCreditoFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCreditoFiscal_KeyPress);
            this.TxtCreditoFiscal.Leave += new System.EventHandler(this.TxtCreditoFiscal_Leave);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(998, 350);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 20);
            this.label21.TabIndex = 55;
            this.label21.Text = "Credito Fiscal:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // CmbLibro
            // 
            this.CmbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbLibro.FormattingEnabled = true;
            this.CmbLibro.ItemHeight = 20;
            this.CmbLibro.Location = new System.Drawing.Point(1106, 586);
            this.CmbLibro.Name = "CmbLibro";
            this.CmbLibro.Size = new System.Drawing.Size(54, 28);
            this.CmbLibro.TabIndex = 21;
            this.CmbLibro.Enter += new System.EventHandler(this.CmbLibro_Enter);
            this.CmbLibro.Leave += new System.EventHandler(this.CmbLibro_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1055, 592);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 20);
            this.label22.TabIndex = 57;
            this.label22.Text = "Libro:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(586, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbEliminar
            // 
            this.CmbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEliminar.Location = new System.Drawing.Point(386, 641);
            this.CmbEliminar.Name = "CmbEliminar";
            this.CmbEliminar.Size = new System.Drawing.Size(151, 38);
            this.CmbEliminar.TabIndex = 24;
            this.CmbEliminar.Text = "ELIMINAR";
            this.CmbEliminar.UseVisualStyleBackColor = true;
            this.CmbEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(197, 641);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 38);
            this.button3.TabIndex = 26;
            this.button3.Text = "IMPRIMIR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CmdExcel
            // 
            this.CmdExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdExcel.Location = new System.Drawing.Point(30, 640);
            this.CmdExcel.Name = "CmdExcel";
            this.CmdExcel.Size = new System.Drawing.Size(151, 38);
            this.CmdExcel.TabIndex = 27;
            this.CmdExcel.Text = "EXCEL";
            this.CmdExcel.UseVisualStyleBackColor = true;
            this.CmdExcel.Click += new System.EventHandler(this.CmdExcel_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1164, 590);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 20);
            this.label23.TabIndex = 63;
            this.label23.Text = "Tipo Doc:";
            // 
            // CmbTipoDoc
            // 
            this.CmbTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoDoc.FormattingEnabled = true;
            this.CmbTipoDoc.ItemHeight = 20;
            this.CmbTipoDoc.Location = new System.Drawing.Point(1242, 589);
            this.CmbTipoDoc.Name = "CmbTipoDoc";
            this.CmbTipoDoc.Size = new System.Drawing.Size(76, 28);
            this.CmbTipoDoc.TabIndex = 22;
            this.CmbTipoDoc.Enter += new System.EventHandler(this.CmbTipoDoc_Enter);
            this.CmbTipoDoc.Leave += new System.EventHandler(this.CmbTipoDoc_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLibroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 690);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.CmbTipoDoc);
            this.Controls.Add(this.CmdExcel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CmbEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.CmbLibro);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.TxtCreditoFiscal);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.CmbAno);
            this.Controls.Add(this.CmbMes);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtFechaEmision);
            this.Controls.Add(this.TxtCompExtLocales);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.CmbDentroCA);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TxtConsTrans);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtFovial);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtRetencionATerceros);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtComprasExcluidas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtRet_Suj_Exc_Cal_Contri);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtIvaUnoPorcientoRetenido);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtTotalCompras);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtCompGrInternacionales);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCompGraImportaciones);
            this.Controls.Add(this.TxtCompGraLocales);
            this.Controls.Add(this.TxtCompExtInter);
            this.Controls.Add(this.TxtCompExtImport);
            this.Controls.Add(this.TxtImpuEspe);
            this.Controls.Add(this.TxtNomProv);
            this.Controls.Add(this.TxtIdExcl);
            this.Controls.Add(this.TxtNumRegistro);
            this.Controls.Add(this.TxtNumDoc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmLibroCompras";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Libro de Compras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtNumDoc;
        private System.Windows.Forms.TextBox TxtNumRegistro;
        private System.Windows.Forms.TextBox TxtIdExcl;
        private System.Windows.Forms.TextBox TxtNomProv;
        private System.Windows.Forms.TextBox TxtImpuEspe;
        private System.Windows.Forms.TextBox TxtCompExtImport;
        private System.Windows.Forms.TextBox TxtCompExtInter;
        private System.Windows.Forms.TextBox TxtCompGraLocales;
        private System.Windows.Forms.TextBox TxtCompGraImportaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCompGrInternacionales;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtTotalCompras;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtIvaUnoPorcientoRetenido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtRet_Suj_Exc_Cal_Contri;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtComprasExcluidas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtRetencionATerceros;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtFovial;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtConsTrans;
        private System.Windows.Forms.ComboBox CmbDentroCA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtCompExtLocales;
        private System.Windows.Forms.DateTimePicker TxtFechaEmision;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CmbMes;
        private System.Windows.Forms.ComboBox CmbAno;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox TxtCreditoFiscal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox CmbLibro;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CmbEliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CmdExcel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox CmbTipoDoc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

