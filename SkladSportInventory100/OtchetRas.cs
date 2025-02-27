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
    public partial class OtchetRas : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True";
        public OtchetRas()
        {
            InitializeComponent();
        }

        private void OtchetRas_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.RasxodyView10". При необходимости она может быть перемещена или удалена.
            this.rasxodyView10TableAdapter.Fill(this.kursDataSet1.RasxodyView10);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.RasxodyView". При необходимости она может быть перемещена или удалена.
            this.rasxodyViewTableAdapter.Fill(this.kursDataSet1.RasxodyView);

            this.reportViewer1.RefreshReport();
        }
        private void SearchPostupleniya(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM RasxodyView WHERE [Дата расхода] BETWEEN @StartDate AND @EndDate";
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
                        rasxodyViewDataGridView.DataSource = dataTable;
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
