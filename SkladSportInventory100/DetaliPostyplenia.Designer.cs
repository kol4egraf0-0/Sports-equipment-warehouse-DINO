namespace SkladSportInventory100
{
    partial class DetaliPostyplenia
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
            System.Windows.Forms.Label polnayaStoimostLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaliPostyplenia));
            this.postyplenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new SkladSportInventory100.kursDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.polnayaStoimostTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.postavshikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.produktBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.postavshikIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvaniePostavshikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktnoeLitsoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektronnayaPochtaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.postavshikiTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.PostavshikiTableAdapter();
            this.tableAdapterManager = new SkladSportInventory100.kursDataSetTableAdapters.TableAdapterManager();
            this.detaliPostypleniaTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.DetaliPostypleniaTableAdapter();
            this.postyplenieTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.PostyplenieTableAdapter();
            this.productDetaliTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.ProductDetaliTableAdapter();
            this.produktTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.ProduktTableAdapter();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.productDetaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detaliPostypleniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.postyplenieDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ZakazID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            polnayaStoimostLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postyplenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetaliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaliPostypleniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postyplenieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // polnayaStoimostLabel
            // 
            polnayaStoimostLabel.AutoSize = true;
            polnayaStoimostLabel.Location = new System.Drawing.Point(124, 15);
            polnayaStoimostLabel.Name = "polnayaStoimostLabel";
            polnayaStoimostLabel.Size = new System.Drawing.Size(102, 13);
            polnayaStoimostLabel.TabIndex = 18;
            polnayaStoimostLabel.Text = "Полная стоимость";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 13);
            label2.TabIndex = 20;
            label2.Text = "Код поставщика";
            // 
            // postyplenieBindingSource
            // 
            this.postyplenieBindingSource.DataMember = "Postyplenie";
            this.postyplenieBindingSource.DataSource = this.kursDataSet;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "kursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.polnayaStoimostTextBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(polnayaStoimostLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateOrder);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Location = new System.Drawing.Point(361, 443);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(409, 134);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // polnayaStoimostTextBox
            // 
            this.polnayaStoimostTextBox.Location = new System.Drawing.Point(130, 30);
            this.polnayaStoimostTextBox.Name = "polnayaStoimostTextBox";
            this.polnayaStoimostTextBox.Size = new System.Drawing.Size(100, 20);
            this.polnayaStoimostTextBox.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavshikiBindingSource, "PostavshikID", true));
            this.textBox1.Location = new System.Drawing.Point(16, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // postavshikiBindingSource
            // 
            this.postavshikiBindingSource.DataMember = "Postavshiki";
            this.postavshikiBindingSource.DataSource = this.kursDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата поступления";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateOrder.Location = new System.Drawing.Point(249, 26);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(148, 88);
            this.btnCreateOrder.TabIndex = 18;
            this.btnCreateOrder.Text = "Создать";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postyplenieBindingSource, "DataZakaza", true));
            this.datePicker.Location = new System.Drawing.Point(17, 88);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(194, 20);
            this.datePicker.TabIndex = 17;
            // 
            // produktBindingSource1
            // 
            this.produktBindingSource1.DataMember = "Produkt";
            this.produktBindingSource1.DataSource = this.kursDataSet;
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AllowUserToResizeColumns = false;
            this.dataGridCustomers.AllowUserToResizeRows = false;
            this.dataGridCustomers.AutoGenerateColumns = false;
            this.dataGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postavshikIDDataGridViewTextBoxColumn1,
            this.nazvaniePostavshikaDataGridViewTextBoxColumn,
            this.kontaktnoeLitsoDataGridViewTextBoxColumn,
            this.elektronnayaPochtaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridCustomers.DataSource = this.postavshikiBindingSource;
            this.dataGridCustomers.Location = new System.Drawing.Point(13, 72);
            this.dataGridCustomers.MultiSelect = false;
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomers.Size = new System.Drawing.Size(1038, 142);
            this.dataGridCustomers.TabIndex = 30;
            // 
            // postavshikIDDataGridViewTextBoxColumn1
            // 
            this.postavshikIDDataGridViewTextBoxColumn1.DataPropertyName = "PostavshikID";
            this.postavshikIDDataGridViewTextBoxColumn1.HeaderText = "Код поставщика";
            this.postavshikIDDataGridViewTextBoxColumn1.Name = "postavshikIDDataGridViewTextBoxColumn1";
            this.postavshikIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazvaniePostavshikaDataGridViewTextBoxColumn
            // 
            this.nazvaniePostavshikaDataGridViewTextBoxColumn.DataPropertyName = "NazvaniePostavshika";
            this.nazvaniePostavshikaDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.nazvaniePostavshikaDataGridViewTextBoxColumn.Name = "nazvaniePostavshikaDataGridViewTextBoxColumn";
            this.nazvaniePostavshikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontaktnoeLitsoDataGridViewTextBoxColumn
            // 
            this.kontaktnoeLitsoDataGridViewTextBoxColumn.DataPropertyName = "KontaktnoeLitso";
            this.kontaktnoeLitsoDataGridViewTextBoxColumn.HeaderText = "Контактное лицо";
            this.kontaktnoeLitsoDataGridViewTextBoxColumn.Name = "kontaktnoeLitsoDataGridViewTextBoxColumn";
            this.kontaktnoeLitsoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elektronnayaPochtaDataGridViewTextBoxColumn
            // 
            this.elektronnayaPochtaDataGridViewTextBoxColumn.DataPropertyName = "ElektronnayaPochta";
            this.elektronnayaPochtaDataGridViewTextBoxColumn.HeaderText = "Электронная почта";
            this.elektronnayaPochtaDataGridViewTextBoxColumn.Name = "elektronnayaPochtaDataGridViewTextBoxColumn";
            this.elektronnayaPochtaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearch.Location = new System.Drawing.Point(77, 24);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(974, 29);
            this.txtCustomerSearch.TabIndex = 29;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // postavshikiTableAdapter
            // 
            this.postavshikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DetaliPostypleniaTableAdapter = this.detaliPostypleniaTableAdapter;
            this.tableAdapterManager.KlientyTableAdapter = null;
            this.tableAdapterManager.PostavshikiTableAdapter = this.postavshikiTableAdapter;
            this.tableAdapterManager.PostyplenieTableAdapter = this.postyplenieTableAdapter;
            this.tableAdapterManager.ProductDetaliTableAdapter = this.productDetaliTableAdapter;
            this.tableAdapterManager.ProduktTableAdapter = this.produktTableAdapter;
            this.tableAdapterManager.RasxodyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SkladSportInventory100.kursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detaliPostypleniaTableAdapter
            // 
            this.detaliPostypleniaTableAdapter.ClearBeforeFill = true;
            // 
            // postyplenieTableAdapter
            // 
            this.postyplenieTableAdapter.ClearBeforeFill = true;
            // 
            // productDetaliTableAdapter
            // 
            this.productDetaliTableAdapter.ClearBeforeFill = true;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "Produkt";
            this.produktBindingSource.DataSource = this.kursDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkladSportInventory100.Properties.Resources._;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(491, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Инвентарь";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productDetaliBindingSource
            // 
            this.productDetaliBindingSource.DataMember = "ProductDetali";
            this.productDetaliBindingSource.DataSource = this.kursDataSet;
            // 
            // detaliPostypleniaBindingSource
            // 
            this.detaliPostypleniaBindingSource.DataMember = "DetaliPostyplenia";
            this.detaliPostypleniaBindingSource.DataSource = this.kursDataSet;
            // 
            // produktDataGridView
            // 
            this.produktDataGridView.AutoGenerateColumns = false;
            this.produktDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produktDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.produktDataGridView.DataSource = this.produktBindingSource1;
            this.produktDataGridView.Location = new System.Drawing.Point(13, 244);
            this.produktDataGridView.Name = "produktDataGridView";
            this.produktDataGridView.Size = new System.Drawing.Size(444, 182);
            this.produktDataGridView.TabIndex = 40;
            this.produktDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produktDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NazvanieProdukta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Продукт";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kategoriya";
            this.dataGridViewTextBoxColumn3.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "KolichestvoNaSklade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пришло кол-во";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tsena";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(491, 345);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 41;
            this.button2.Text = "Поставщик";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // postyplenieDataGridView
            // 
            this.postyplenieDataGridView.AutoGenerateColumns = false;
            this.postyplenieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postyplenieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZakazID,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.postyplenieDataGridView.DataSource = this.postyplenieBindingSource;
            this.postyplenieDataGridView.Location = new System.Drawing.Point(679, 244);
            this.postyplenieDataGridView.Name = "postyplenieDataGridView";
            this.postyplenieDataGridView.Size = new System.Drawing.Size(345, 182);
            this.postyplenieDataGridView.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(805, 515);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 56);
            this.button4.TabIndex = 42;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(805, 438);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 56);
            this.button3.TabIndex = 23;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ZakazID
            // 
            this.ZakazID.DataPropertyName = "ZakazID";
            this.ZakazID.HeaderText = "ZakazID";
            this.ZakazID.Name = "ZakazID";
            this.ZakazID.ReadOnly = true;
            this.ZakazID.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DataZakaza";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата Поступления";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PostavshikID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Код поставщика";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PolnayaStoimost";
            this.dataGridViewTextBoxColumn8.HeaderText = "Полная стоимость";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // DetaliPostyplenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 597);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.postyplenieDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.produktDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridCustomers);
            this.Controls.Add(this.txtCustomerSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetaliPostyplenia";
            this.Text = "Поступление";
            this.Load += new System.EventHandler(this.DetaliPostyplenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postyplenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetaliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaliPostypleniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postyplenieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Label label1;
        private kursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource postavshikiBindingSource;
        private kursDataSetTableAdapters.PostavshikiTableAdapter postavshikiTableAdapter;
        private kursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private kursDataSetTableAdapters.ProduktTableAdapter produktTableAdapter;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource produktBindingSource1;
        private kursDataSetTableAdapters.PostyplenieTableAdapter postyplenieTableAdapter;
        private System.Windows.Forms.BindingSource postyplenieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavshikIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvaniePostavshikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktnoeLitsoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektronnayaPochtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private kursDataSetTableAdapters.ProductDetaliTableAdapter productDetaliTableAdapter;
        private System.Windows.Forms.BindingSource productDetaliBindingSource;
        private kursDataSetTableAdapters.DetaliPostypleniaTableAdapter detaliPostypleniaTableAdapter;
        private System.Windows.Forms.BindingSource detaliPostypleniaBindingSource;
        private System.Windows.Forms.DataGridView produktDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox polnayaStoimostTextBox;
        private System.Windows.Forms.DataGridView postyplenieDataGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZakazID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}