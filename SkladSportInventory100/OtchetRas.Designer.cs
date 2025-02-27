namespace SkladSportInventory100
{
    partial class OtchetRas
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtchetRas));
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kursDataSet1 = new SkladSportInventory100.kursDataSet1();
            this.rasxodyViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rasxodyViewTableAdapter = new SkladSportInventory100.kursDataSet1TableAdapters.RasxodyViewTableAdapter();
            this.tableAdapterManager = new SkladSportInventory100.kursDataSet1TableAdapters.TableAdapterManager();
            this.rasxodyViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RasxodyView10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rasxodyView10BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rasxodyView10TableAdapter = new SkladSportInventory100.kursDataSet1TableAdapters.RasxodyView10TableAdapter();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RasxodyView10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyView10BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(336, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(22, 13);
            label1.TabIndex = 27;
            label1.Text = "До";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(98, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(20, 13);
            label2.TabIndex = 26;
            label2.Text = "От";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateOrder.Location = new System.Drawing.Point(479, 21);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(148, 36);
            this.btnCreateOrder.TabIndex = 28;
            this.btnCreateOrder.Text = "Искать";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(255, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // kursDataSet1
            // 
            this.kursDataSet1.DataSetName = "kursDataSet1";
            this.kursDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rasxodyViewBindingSource
            // 
            this.rasxodyViewBindingSource.DataMember = "RasxodyView";
            this.rasxodyViewBindingSource.DataSource = this.kursDataSet1;
            // 
            // rasxodyViewTableAdapter
            // 
            this.rasxodyViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SkladSportInventory100.kursDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rasxodyViewDataGridView
            // 
            this.rasxodyViewDataGridView.AutoGenerateColumns = false;
            this.rasxodyViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rasxodyViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.rasxodyViewDataGridView.DataSource = this.rasxodyViewBindingSource;
            this.rasxodyViewDataGridView.Location = new System.Drawing.Point(21, 78);
            this.rasxodyViewDataGridView.Name = "rasxodyViewDataGridView";
            this.rasxodyViewDataGridView.Size = new System.Drawing.Size(543, 220);
            this.rasxodyViewDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Сумма";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn4.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата расхода";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn7.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Название продукта";
            this.dataGridViewTextBoxColumn8.HeaderText = "Название продукта";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rasxodyView10BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SkladSportInventory100.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(21, 344);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(606, 246);
            this.reportViewer1.TabIndex = 30;
            // 
            // RasxodyView10BindingSource
            // 
            this.RasxodyView10BindingSource.DataMember = "RasxodyView10";
            this.RasxodyView10BindingSource.DataSource = this.kursDataSet1;
            // 
            // rasxodyView10BindingSource1
            // 
            this.rasxodyView10BindingSource1.DataMember = "RasxodyView10";
            this.rasxodyView10BindingSource1.DataSource = this.kursDataSet1;
            // 
            // rasxodyView10TableAdapter
            // 
            this.rasxodyView10TableAdapter.ClearBeforeFill = true;
            // 
            // OtchetRas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 625);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.rasxodyViewDataGridView);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OtchetRas";
            this.Text = "Отчет для расходов";
            this.Load += new System.EventHandler(this.OtchetRas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RasxodyView10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasxodyView10BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private kursDataSet1 kursDataSet1;
        private System.Windows.Forms.BindingSource rasxodyViewBindingSource;
        private kursDataSet1TableAdapters.RasxodyViewTableAdapter rasxodyViewTableAdapter;
        private kursDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView rasxodyViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RasxodyView10BindingSource;
        private System.Windows.Forms.BindingSource rasxodyView10BindingSource1;
        private kursDataSet1TableAdapters.RasxodyView10TableAdapter rasxodyView10TableAdapter;
    }
}