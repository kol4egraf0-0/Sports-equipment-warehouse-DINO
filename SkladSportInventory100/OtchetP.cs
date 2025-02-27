using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkladSportInventory100
{
    public partial class OtchetP : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True";
        public OtchetP()
        {
            InitializeComponent();
        }

        private void postyplenieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postyplenieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void OtchetP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.PostupleniyaView10". При необходимости она может быть перемещена или удалена.
            this.postupleniyaView10TableAdapter.Fill(this.kursDataSet1.PostupleniyaView10);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.PostupleniyaView". При необходимости она может быть перемещена или удалена.
            this.postupleniyaViewTableAdapter.Fill(this.kursDataSet1.PostupleniyaView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Postyplenie". При необходимости она может быть перемещена или удалена.
            this.postyplenieTableAdapter.Fill(this.kursDataSet.Postyplenie);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void SearchPostupleniya(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PostupleniyaView WHERE [Дата поступления] BETWEEN @StartDate AND @EndDate";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@StartDate", startDate);
                        sqlCommand.Parameters.AddWithValue("@EndDate", endDate);
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        pViewDataGridView.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка поиска поступлений: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            SearchPostupleniya(startDate, endDate);
        }
    }
}
