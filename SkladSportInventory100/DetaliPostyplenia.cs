using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkladSportInventory100
{

    public partial class DetaliPostyplenia : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True";
        public DetaliPostyplenia()
        {
            InitializeComponent();
        }

        private void DetaliPostyplenia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.DetaliPostyplenia". При необходимости она может быть перемещена или удалена.
            this.detaliPostypleniaTableAdapter.Fill(this.kursDataSet.DetaliPostyplenia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.ProductDetali". При необходимости она может быть перемещена или удалена.
            this.productDetaliTableAdapter.Fill(this.kursDataSet.ProductDetali);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Postyplenie". При необходимости она может быть перемещена или удалена.
            this.postyplenieTableAdapter.Fill(this.kursDataSet.Postyplenie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Produkt". При необходимости она может быть перемещена или удалена.
            this.produktTableAdapter.Fill(this.kursDataSet.Produkt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Postavshiki". При необходимости она может быть перемещена или удалена.
            this.postavshikiTableAdapter.Fill(this.kursDataSet.Postavshiki);

        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            postavshikiBindingSource.Filter = string.Format("NazvaniePostavshika LIKE '%{0}%'", txtCustomerSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory inventoryForm = new Inventory();
            inventoryForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Postavchiki postavchikiForm = new Postavchiki();
            postavchikiForm.Show();
        }
        private bool validateProduct()
        {
            // Проверяем, что все текстовые поля не пустые
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(polnayaStoimostTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (validateProduct())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Postyplenie(DataZakaza, PostavshikID, PolnayaStoimost) VALUES(@Data, @Postavshik, @Stoimost)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@Data", datePicker.Value.ToString("yyyy-MM-dd"));
                            sqlCommand.Parameters.AddWithValue("@Postavshik", textBox1.Text);
                            sqlCommand.Parameters.AddWithValue("@Stoimost", polnayaStoimostTextBox.Text);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Поступление оформлено");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка поступления: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Незаполненные поля или неверный формат данных");
            }
        }

        private void produktDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < produktDataGridView.Rows.Count)
            {
                DataGridViewRow row = produktDataGridView.Rows[e.RowIndex];
                double tsena = double.Parse(row.Cells["dataGridViewTextBoxColumn5"].Value.ToString());
                int kolichestvo = int.Parse(row.Cells["dataGridViewTextBoxColumn4"].Value.ToString());
                double polnayaStoimost = tsena * kolichestvo;
                polnayaStoimostTextBox.Text = polnayaStoimost.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (validateProduct())
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Postyplenie SET DataZakaza = @Data, PostavshikID = @Postavshik WHERE PostavshikID = @Postavshik";
                        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Parameters.AddWithValue("@Stoimost", polnayaStoimostTextBox.Text);
                                sqlCommand.Parameters.AddWithValue("@Data", datePicker.Value.ToString("yyyy-MM-dd"));
                                sqlCommand.Parameters.AddWithValue("@Postavshik", textBox1.Text);
                                int rowsAffected = sqlCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Поступление успешно обновлено");
                                }
                                else
                                {
                                    MessageBox.Show("Не удалось найти поступление для обновления");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при обновлении поступления: " + ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Незаполненные поля или неверный формат данных");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                {
                    string selectedPostyplenie = "";
                    if (postyplenieDataGridView.SelectedRows.Count > 0)
                    {
                        selectedPostyplenie = postyplenieDataGridView.SelectedRows[0].Cells["ZakazID"].Value.ToString();
                    }
                    if (!string.IsNullOrEmpty(selectedPostyplenie))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "DELETE FROM Postyplenie WHERE ZakazID = @Postyplenie";
                            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                            {
                                try
                                {
                                    connection.Open();
                                    sqlCommand.CommandType = CommandType.Text;
                                    sqlCommand.Parameters.AddWithValue("@Postyplenie", selectedPostyplenie);
                                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Поступление успешно удалено");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Не удалось найти поступлние");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ошибка при удалении поступления: " + ex.Message);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, выберите поступление для удаления");
                    }
                }
            }
        }

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    Application.Restart();
        //}
        //private void button4_Click(object sender, EventArgs e)
        //{

        //}
    }
}
