namespace SkladSportInventory100
{
    partial class Rashodes
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label polnayaStoimostLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rashodes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opisanieComboBox = new System.Windows.Forms.ComboBox();
            this.rasxodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new SkladSportInventory100.kursDataSet();
            this.polnayaStoimostTextBox = new System.Windows.Forms.TextBox();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.klientyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.klientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektronnayaPochtaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.klientyTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.KlientyTableAdapter();
            this.tableAdapterManager = new SkladSportInventory100.kursDataSetTableAdapters.TableAdapterManager();
            this.produktTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.ProduktTableAdapter();
            this.rasxodyTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.RasxodyTableAdapter();
            this.produktDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rasxodyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.productDetaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDetaliTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.ProductDetaliTableAdapter();
            this.kolichestvoTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            polnayaStoimostLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetaliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 13);
            label2.TabIndex = 24;
            label2.Text = "Код клиента";
            // 
            // polnayaStoimostLabel
            // 
            polnayaStoimostLabel.AutoSize = true;
            polnayaStoimostLabel.Location = new System.Drawing.Point(258, 15);
            polnayaStoimostLabel.Name = "polnayaStoimostLabel";
            polnayaStoimostLabel.Size = new System.Drawing.Size(109, 13);
            polnayaStoimostLabel.TabIndex = 23;
            polnayaStoimostLabel.Text = "Заплаченная сумма";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(150, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 13);
            label3.TabIndex = 27;
            label3.Text = "Описание";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.kolichestvoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.opisanieComboBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.polnayaStoimostTextBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(polnayaStoimostLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateOrder);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Location = new System.Drawing.Point(306, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(550, 150);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // opisanieComboBox
            // 
            this.opisanieComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rasxodyBindingSource, "Opisanie", true));
            this.opisanieComboBox.DataSource = this.rasxodyBindingSource;
            this.opisanieComboBox.DisplayMember = "Opisanie";
            this.opisanieComboBox.FormattingEnabled = true;
            this.opisanieComboBox.Location = new System.Drawing.Point(133, 30);
            this.opisanieComboBox.Name = "opisanieComboBox";
            this.opisanieComboBox.Size = new System.Drawing.Size(121, 21);
            this.opisanieComboBox.TabIndex = 28;
            // 
            // rasxodyBindingSource
            // 
            this.rasxodyBindingSource.DataMember = "Rasxody";
            this.rasxodyBindingSource.DataSource = this.kursDataSet;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "kursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polnayaStoimostTextBox
            // 
            this.polnayaStoimostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktBindingSource, "Tsena", true));
            this.polnayaStoimostTextBox.Location = new System.Drawing.Point(260, 31);
            this.polnayaStoimostTextBox.Name = "polnayaStoimostTextBox";
            this.polnayaStoimostTextBox.Size = new System.Drawing.Size(100, 20);
            this.polnayaStoimostTextBox.TabIndex = 26;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "Produkt";
            this.produktBindingSource.DataSource = this.kursDataSet;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientyBindingSource, "KlientID", true));
            this.textBox1.Location = new System.Drawing.Point(21, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            // 
            // klientyBindingSource
            // 
            this.klientyBindingSource.DataMember = "Klienty";
            this.klientyBindingSource.DataSource = this.kursDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата оформления";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateOrder.Location = new System.Drawing.Point(380, 30);
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
            this.datePicker.Location = new System.Drawing.Point(22, 99);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(194, 20);
            this.datePicker.TabIndex = 17;
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
            this.klientIDDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.elektronnayaPochtaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridCustomers.DataSource = this.klientyBindingSource;
            this.dataGridCustomers.Location = new System.Drawing.Point(25, 71);
            this.dataGridCustomers.MultiSelect = false;
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomers.Size = new System.Drawing.Size(1062, 142);
            this.dataGridCustomers.TabIndex = 41;
            // 
            // klientIDDataGridViewTextBoxColumn
            // 
            this.klientIDDataGridViewTextBoxColumn.DataPropertyName = "KlientID";
            this.klientIDDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.klientIDDataGridViewTextBoxColumn.Name = "klientIDDataGridViewTextBoxColumn";
            this.klientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "Imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            this.imyaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "Familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            this.familiaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.txtCustomerSearch.Location = new System.Drawing.Point(87, 23);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(974, 29);
            this.txtCustomerSearch.TabIndex = 40;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkladSportInventory100.Properties.Resources._;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // klientyTableAdapter
            // 
            this.klientyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DetaliPostypleniaTableAdapter = null;
            this.tableAdapterManager.KlientyTableAdapter = this.klientyTableAdapter;
            this.tableAdapterManager.PostavshikiTableAdapter = null;
            this.tableAdapterManager.PostyplenieTableAdapter = null;
            this.tableAdapterManager.ProductDetaliTableAdapter = null;
            this.tableAdapterManager.ProduktTableAdapter = this.produktTableAdapter;
            this.tableAdapterManager.RasxodyTableAdapter = this.rasxodyTableAdapter;
            this.tableAdapterManager.UpdateOrder = SkladSportInventory100.kursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // rasxodyTableAdapter
            // 
            this.rasxodyTableAdapter.ClearBeforeFill = true;
            // 
            // produktDataGridView
            // 
            this.produktDataGridView.AutoGenerateColumns = false;
            this.produktDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produktDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.produktDataGridView.DataSource = this.produktBindingSource;
            this.produktDataGridView.Location = new System.Drawing.Point(25, 219);
            this.produktDataGridView.Name = "produktDataGridView";
            this.produktDataGridView.Size = new System.Drawing.Size(443, 220);
            this.produktDataGridView.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NazvanieProdukta";
            this.dataGridViewTextBoxColumn6.HeaderText = "Продукт";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Kategoriya";
            this.dataGridViewTextBoxColumn7.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "KolichestvoNaSklade";
            this.dataGridViewTextBoxColumn8.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tsena";
            this.dataGridViewTextBoxColumn9.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(473, 296);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "Клиенты";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(889, 543);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 56);
            this.button4.TabIndex = 49;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(889, 466);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 56);
            this.button3.TabIndex = 48;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rasxodyDataGridView
            // 
            this.rasxodyDataGridView.AutoGenerateColumns = false;
            this.rasxodyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rasxodyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rasxodyDataGridView.DataSource = this.rasxodyBindingSource;
            this.rasxodyDataGridView.Location = new System.Drawing.Point(647, 219);
            this.rasxodyDataGridView.Name = "rasxodyDataGridView";
            this.rasxodyDataGridView.Size = new System.Drawing.Size(440, 220);
            this.rasxodyDataGridView.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RasxodID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RasxodID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KlientID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Summa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Заплаченная сумма";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Opisanie";
            this.dataGridViewTextBoxColumn4.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataRasxoda";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Кол-во";
            // 
            // productDetaliBindingSource
            // 
            this.productDetaliBindingSource.DataMember = "ProductDetali";
            this.productDetaliBindingSource.DataSource = this.kursDataSet;
            // 
            // productDetaliTableAdapter
            // 
            this.productDetaliTableAdapter.ClearBeforeFill = true;
            // 
            // kolichestvoTextBox
            // 
            this.kolichestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetaliBindingSource, "Kolichestvo", true));
            this.kolichestvoTextBox.Location = new System.Drawing.Point(221, 99);
            this.kolichestvoTextBox.Name = "kolichestvoTextBox";
            this.kolichestvoTextBox.Size = new System.Drawing.Size(100, 20);
            this.kolichestvoTextBox.TabIndex = 30;
            // 
            // Rashodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 622);
            this.Controls.Add(this.rasxodyDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.produktDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridCustomers);
            this.Controls.Add(this.txtCustomerSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rashodes";
            this.Text = "Расходы";
            this.Load += new System.EventHandler(this.Rashodes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetaliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private kursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource klientyBindingSource;
        private kursDataSetTableAdapters.KlientyTableAdapter klientyTableAdapter;
        private kursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private kursDataSetTableAdapters.RasxodyTableAdapter rasxodyTableAdapter;
        private System.Windows.Forms.BindingSource rasxodyBindingSource;
        private kursDataSetTableAdapters.ProduktTableAdapter produktTableAdapter;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.DataGridView produktDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox opisanieComboBox;
        private System.Windows.Forms.TextBox polnayaStoimostTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektronnayaPochtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView rasxodyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource productDetaliBindingSource;
        private kursDataSetTableAdapters.ProductDetaliTableAdapter productDetaliTableAdapter;
        private System.Windows.Forms.TextBox kolichestvoTextBox;
    }
}