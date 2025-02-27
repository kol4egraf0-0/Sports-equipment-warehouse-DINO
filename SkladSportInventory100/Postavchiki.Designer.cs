namespace SkladSportInventory100
{
    partial class Postavchiki
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavchiki));
            this.postavshikiDataGridView = new System.Windows.Forms.DataGridView();
            this.nazvaniePostavshikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktnoeLitsoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektronnayaPochtaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new SkladSportInventory100.kursDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnCreateNewProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.txtELpochta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.postavshikiTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.PostavshikiTableAdapter();
            this.tableAdapterManager = new SkladSportInventory100.kursDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // postavshikiDataGridView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.postavshikiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.postavshikiDataGridView.AutoGenerateColumns = false;
            this.postavshikiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postavshikiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazvaniePostavshikaDataGridViewTextBoxColumn,
            this.kontaktnoeLitsoDataGridViewTextBoxColumn,
            this.elektronnayaPochtaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.postavshikiDataGridView.DataSource = this.postavshikiBindingSource;
            this.postavshikiDataGridView.Location = new System.Drawing.Point(52, 81);
            this.postavshikiDataGridView.Name = "postavshikiDataGridView";
            this.postavshikiDataGridView.Size = new System.Drawing.Size(441, 420);
            this.postavshikiDataGridView.TabIndex = 36;
            // 
            // nazvaniePostavshikaDataGridViewTextBoxColumn
            // 
            this.nazvaniePostavshikaDataGridViewTextBoxColumn.DataPropertyName = "NazvaniePostavshika";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nazvaniePostavshikaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.nazvaniePostavshikaDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.nazvaniePostavshikaDataGridViewTextBoxColumn.Name = "nazvaniePostavshikaDataGridViewTextBoxColumn";
            // 
            // kontaktnoeLitsoDataGridViewTextBoxColumn
            // 
            this.kontaktnoeLitsoDataGridViewTextBoxColumn.DataPropertyName = "KontaktnoeLitso";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kontaktnoeLitsoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.kontaktnoeLitsoDataGridViewTextBoxColumn.HeaderText = "Контактное лицо";
            this.kontaktnoeLitsoDataGridViewTextBoxColumn.Name = "kontaktnoeLitsoDataGridViewTextBoxColumn";
            // 
            // elektronnayaPochtaDataGridViewTextBoxColumn
            // 
            this.elektronnayaPochtaDataGridViewTextBoxColumn.DataPropertyName = "ElektronnayaPochta";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.elektronnayaPochtaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.elektronnayaPochtaDataGridViewTextBoxColumn.HeaderText = "Электронная почта";
            this.elektronnayaPochtaDataGridViewTextBoxColumn.Name = "elektronnayaPochtaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.telefonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // postavshikiBindingSource
            // 
            this.postavshikiBindingSource.DataMember = "Postavshiki";
            this.postavshikiBindingSource.DataSource = this.kursDataSet;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "kursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtTelephone);
            this.groupBox2.Controls.Add(this.btnClearFields);
            this.groupBox2.Controls.Add(this.btnCreateNewProduct);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDeleteProduct);
            this.groupBox2.Controls.Add(this.btnUpdateProduct);
            this.groupBox2.Controls.Add(this.txtELpochta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtKontakt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(531, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 561);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о поставщиках";
            // 
            // txtTelephone
            // 
            this.txtTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikiBindingSource, "Telefon", true));
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(60, 229);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(273, 22);
            this.txtTelephone.TabIndex = 27;
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.IndianRed;
            this.btnClearFields.Location = new System.Drawing.Point(139, 332);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(102, 32);
            this.btnClearFields.TabIndex = 6;
            this.btnClearFields.Text = "Отчистить";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnCreateNewProduct
            // 
            this.btnCreateNewProduct.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateNewProduct.Location = new System.Drawing.Point(60, 387);
            this.btnCreateNewProduct.Name = "btnCreateNewProduct";
            this.btnCreateNewProduct.Size = new System.Drawing.Size(272, 41);
            this.btnCreateNewProduct.TabIndex = 7;
            this.btnCreateNewProduct.Text = "Добавить";
            this.btnCreateNewProduct.UseVisualStyleBackColor = false;
            this.btnCreateNewProduct.Click += new System.EventHandler(this.btnCreateNewProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Телефон";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteProduct.Location = new System.Drawing.Point(60, 482);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(272, 41);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Удалить";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateProduct.Location = new System.Drawing.Point(60, 435);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(272, 41);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Обновить";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // txtELpochta
            // 
            this.txtELpochta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikiBindingSource, "ElektronnayaPochta", true));
            this.txtELpochta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtELpochta.Location = new System.Drawing.Point(60, 169);
            this.txtELpochta.Name = "txtELpochta";
            this.txtELpochta.Size = new System.Drawing.Size(273, 22);
            this.txtELpochta.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Электрнная почта";
            // 
            // txtKontakt
            // 
            this.txtKontakt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikiBindingSource, "KontaktnoeLitso", true));
            this.txtKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontakt.Location = new System.Drawing.Point(60, 113);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(273, 22);
            this.txtKontakt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Контактное лицо";
            // 
            // txtProductName
            // 
            this.txtProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikiBindingSource, "NazvaniePostavshika", true));
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(60, 56);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(273, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Поставщик";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(149, 25);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(344, 29);
            this.txtProductSearch.TabIndex = 34;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // postavshikiTableAdapter
            // 
            this.postavshikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DetaliPostypleniaTableAdapter = null;
            this.tableAdapterManager.KlientyTableAdapter = null;
            this.tableAdapterManager.PostavshikiTableAdapter = this.postavshikiTableAdapter;
            this.tableAdapterManager.PostyplenieTableAdapter = null;
            this.tableAdapterManager.ProductDetaliTableAdapter = null;
            this.tableAdapterManager.ProduktTableAdapter = null;
            this.tableAdapterManager.RasxodyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SkladSportInventory100.kursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkladSportInventory100.Properties.Resources._;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Postavchiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.postavshikiDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtProductSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Postavchiki";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Postavchiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView postavshikiDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnCreateNewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox txtELpochta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductSearch;
        private kursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource postavshikiBindingSource;
        private kursDataSetTableAdapters.PostavshikiTableAdapter postavshikiTableAdapter;
        private kursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvaniePostavshikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktnoeLitsoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektronnayaPochtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}