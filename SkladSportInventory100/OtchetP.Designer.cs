namespace SkladSportInventory100
{
    partial class OtchetP
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
            System.Windows.Forms.Label label1;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtchetP));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.kursDataSet = new SkladSportInventory100.kursDataSet();
            this.postyplenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postyplenieTableAdapter = new SkladSportInventory100.kursDataSetTableAdapters.PostyplenieTableAdapter();
            this.tableAdapterManager = new SkladSportInventory100.kursDataSetTableAdapters.TableAdapterManager();
            this.pViewDataGridView = new System.Windows.Forms.DataGridView();
            this.postupleniyaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet1 = new SkladSportInventory100.kursDataSet1();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postupleniyaViewTableAdapter = new SkladSportInventory100.kursDataSet1TableAdapters.PostupleniyaViewTableAdapter();
            this.tableAdapterManager1 = new SkladSportInventory100.kursDataSet1TableAdapters.TableAdapterManager();
            this.postupleniyaViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postupleniyaViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.PostupleniyaView10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.postupleniyaView10BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postupleniyaView10TableAdapter = new SkladSportInventory100.kursDataSet1TableAdapters.PostupleniyaView10TableAdapter();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postyplenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postupleniyaViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postupleniyaViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postupleniyaViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostupleniyaView10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postupleniyaView10BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(105, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(20, 13);
            label2.TabIndex = 21;
            label2.Text = "От";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(343, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(22, 13);
            label1.TabIndex = 22;
            label1.Text = "До";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(262, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateOrder.Location = new System.Drawing.Point(506, 16);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(148, 36);
            this.btnCreateOrder.TabIndex = 23;
            this.btnCreateOrder.Text = "Искать";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "kursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postyplenieBindingSource
            // 
            this.postyplenieBindingSource.DataMember = "Postyplenie";
            this.postyplenieBindingSource.DataSource = this.kursDataSet;
            // 
            // postyplenieTableAdapter
            // 
            this.postyplenieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DetaliPostypleniaTableAdapter = null;
            this.tableAdapterManager.KlientyTableAdapter = null;
            this.tableAdapterManager.PostavshikiTableAdapter = null;
            this.tableAdapterManager.PostyplenieTableAdapter = this.postyplenieTableAdapter;
            this.tableAdapterManager.ProductDetaliTableAdapter = null;
            this.tableAdapterManager.ProduktTableAdapter = null;
            this.tableAdapterManager.RasxodyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SkladSportInventory100.kursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pViewDataGridView
            // 
            this.pViewDataGridView.AutoGenerateColumns = false;
            this.pViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.pViewDataGridView.DataSource = this.postupleniyaViewBindingSource;
            this.pViewDataGridView.Location = new System.Drawing.Point(12, 87);
            this.pViewDataGridView.Name = "pViewDataGridView";
            this.pViewDataGridView.Size = new System.Drawing.Size(631, 220);
            this.pViewDataGridView.TabIndex = 23;
            // 
            // postupleniyaViewBindingSource
            // 
            this.postupleniyaViewBindingSource.DataMember = "PostupleniyaView";
            this.postupleniyaViewBindingSource.DataSource = this.kursDataSet1;
            // 
            // kursDataSet1
            // 
            this.kursDataSet1.DataSetName = "kursDataSet1";
            this.kursDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название продукта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Продукт";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата поступления";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата поступления";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn3.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Количество на складе";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество на складе";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Полная стоимость";
            this.dataGridViewTextBoxColumn6.HeaderText = "Полная стоимость";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Контактное лицо";
            this.dataGridViewTextBoxColumn8.HeaderText = "Контактное лицо";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Электронная почта";
            this.dataGridViewTextBoxColumn9.HeaderText = "Электронная почта";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn10.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // postupleniyaViewTableAdapter
            // 
            this.postupleniyaViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = SkladSportInventory100.kursDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // postupleniyaViewBindingSource1
            // 
            this.postupleniyaViewBindingSource1.DataMember = "PostupleniyaView";
            this.postupleniyaViewBindingSource1.DataSource = this.kursDataSet1;
            // 
            // postupleniyaViewBindingSource2
            // 
            this.postupleniyaViewBindingSource2.DataMember = "PostupleniyaView";
            this.postupleniyaViewBindingSource2.DataSource = this.kursDataSet1;
            // 
            // PostupleniyaView10BindingSource
            // 
            this.PostupleniyaView10BindingSource.DataMember = "PostupleniyaView10";
            this.PostupleniyaView10BindingSource.DataSource = this.kursDataSet1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.postupleniyaView10BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SkladSportInventory100.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 344);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(641, 246);
            this.reportViewer1.TabIndex = 24;
            // 
            // postupleniyaView10BindingSource1
            // 
            this.postupleniyaView10BindingSource1.DataMember = "PostupleniyaView10";
            this.postupleniyaView10BindingSource1.DataSource = this.kursDataSet1;
            // 
            // postupleniyaView10TableAdapter
            // 
            this.postupleniyaView10TableAdapter.ClearBeforeFill = true;
            // 
            // OtchetP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 651);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pViewDataGridView);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OtchetP";
            this.Text = "Отчет для поступлений";
            this.Load += new System.EventHandler(this.OtchetP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postyplenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postupleniyaViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postupleniyaViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postupleniyaViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostupleniyaView10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postupleniyaView10BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCreateOrder;
        private kursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource postyplenieBindingSource;
        private kursDataSetTableAdapters.PostyplenieTableAdapter postyplenieTableAdapter;
        private kursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private kursDataSet1 kursDataSet1;
        private System.Windows.Forms.BindingSource postupleniyaViewBindingSource;
        private kursDataSet1TableAdapters.PostupleniyaViewTableAdapter postupleniyaViewTableAdapter;
        private kursDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView pViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource postupleniyaViewBindingSource1;
        private System.Windows.Forms.BindingSource postupleniyaViewBindingSource2;
        private System.Windows.Forms.BindingSource PostupleniyaView10BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource postupleniyaView10BindingSource1;
        private kursDataSet1TableAdapters.PostupleniyaView10TableAdapter postupleniyaView10TableAdapter;
    }
}