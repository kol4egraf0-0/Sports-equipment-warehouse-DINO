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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkladSportInventory100
{
    public partial class MenuForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True";
        public MenuForm()
        {
            InitializeComponent();
            ShowSupplierCount1();
            ShowSupplierCount2();
            ShowSupplierCount3();
            ShowSupplierCount4();
            ShowSupplierCount5();
        }
        private void ShowSupplierCount1()
        {
            
            string query = "SELECT COUNT(*) FROM Produkt";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                connection.Open();
                int supplierCount = (int)sqlCommand.ExecuteScalar();
                textBox1.Text = supplierCount.ToString() + " Кол-во товаров";
            }
        }
        private void ShowSupplierCount2()
        {
            string query = "SELECT COUNT(*) FROM Postyplenie";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                connection.Open();

                int supplierCount = (int)sqlCommand.ExecuteScalar();
                textBox2.Text = supplierCount.ToString() + " Кол-во поступлений";
            }
        }
        private void ShowSupplierCount3()
        {

            string query = "SELECT COUNT(*) FROM Postavshiki";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                connection.Open();
                int supplierCount = (int)sqlCommand.ExecuteScalar();
                textBox3.Text = supplierCount.ToString() + " Кол-во Поставщиков";
            }
        }
        private void ShowSupplierCount4()
        {
            string query = "SELECT COUNT(*) FROM Klienty";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                connection.Open();
                int supplierCount = (int)sqlCommand.ExecuteScalar();
                textBox4.Text = supplierCount.ToString() + " Кол-во Клиентов";
            }
        }
        private void ShowSupplierCount5()
        {
            string query = "SELECT COUNT(*) FROM Rasxody";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                connection.Open();
                int supplierCount = (int)sqlCommand.ExecuteScalar();
                textBox5.Text = supplierCount.ToString() + " Кол-во Продаж";
            }
        }
        private void продуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventoryForm = new Inventory();
            inventoryForm.Show();
        }

        private void поступлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetaliPostyplenia detalipostypleniaForm = new DetaliPostyplenia();
            detalipostypleniaForm.Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Postavchiki postavchikiForm = new Postavchiki();
            postavchikiForm.Show();
        }

        private void расходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Rashodes rashodForm = new Rashodes();
            rashodForm.Show();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klients klientesFrom = new Klients();
            klientesFrom.Show();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отчетПоступленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtchetP OtchetP = new OtchetP();
            OtchetP.Show();
        }

        private void отчетРасходовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtchetRas OtchetRas = new OtchetRas();
            OtchetRas.Show();
        }
    }
}
