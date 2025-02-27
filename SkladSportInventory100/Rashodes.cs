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
    public partial class Rashodes : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kurs;Integrated Security=True";
        public Rashodes()
        {
            InitializeComponent();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            klientyBindingSource.Filter = string.Format("Familia LIKE '%{0}%'", txtCustomerSearch.Text);
        }

        private void Rashodes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.ProductDetali". При необходимости она может быть перемещена или удалена.
            this.productDetaliTableAdapter.Fill(this.kursDataSet.ProductDetali);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Produkt". При необходимости она может быть перемещена или удалена.
            this.produktTableAdapter.Fill(this.kursDataSet.Produkt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Rasxody". При необходимости она может быть перемещена или удалена.
            this.rasxodyTableAdapter.Fill(this.kursDataSet.Rasxody);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Klienty". При необходимости она может быть перемещена или удалена.
            this.klientyTableAdapter.Fill(this.kursDataSet.Klienty);

        }
        private bool validateProduct()
        {
            // Проверяем, что все текстовые поля не пустые
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(polnayaStoimostTextBox.Text)
               && !string.IsNullOrWhiteSpace(opisanieComboBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klients klientesFrom = new Klients();
            klientesFrom.Show();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (validateProduct())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Rasxody(KlientID, Summa, Opisanie, DataRasxoda) VALUES(@KlientID, @Summa, @Opisanie, @DataRasxoda)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@DataRasxoda", datePicker.Value.ToString("yyyy-MM-dd"));
                            sqlCommand.Parameters.AddWithValue("@KlientID", textBox1.Text);
                            sqlCommand.Parameters.AddWithValue("@Opisanie", opisanieComboBox.Text);

                            // Проверяем, является ли значение в polnayaStoimostTextBox числовым
                            if (double.TryParse(polnayaStoimostTextBox.Text, out double summa))
                            {
                                // Преобразование удалось
                                sqlCommand.Parameters.AddWithValue("@Summa", summa);
                            }
                            else
                            {
                                // Преобразование не удалось
                                MessageBox.Show("Ошибка: сумма должна быть числом.");
                                return; // Прерываем выполнение метода
                            }

                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Расход оформлен");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка создания: " + ex.Message);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (validateProduct())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Rasxody SET Summa = @Summa, Opisanie = @Opisanie, DataRasxoda = @DataRasxoda WHERE KlientID = @KlientID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@DataRasxoda", datePicker.Value.ToString("yyyy-MM-dd"));
                            sqlCommand.Parameters.AddWithValue("@KlientID", textBox1.Text);
                            sqlCommand.Parameters.AddWithValue("@Opisanie", opisanieComboBox.Text);

                            // Проверяем, является ли значение в polnayaStoimostTextBox числовым
                            if (double.TryParse(polnayaStoimostTextBox.Text, out double summa))
                            {
                                // Преобразование удалось
                                sqlCommand.Parameters.AddWithValue("@Summa", summa);
                            }
                            else
                            {
                                // Преобразование не удалось
                                MessageBox.Show("Ошибка: сумма должна быть числом.");
                                return; // Прерываем выполнение метода
                            }

                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Расход обновлен");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка обновления: " + ex.Message);
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

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedClientID = "";
            if (rasxodyDataGridView.SelectedRows.Count > 0)
            {
                selectedClientID = rasxodyDataGridView.SelectedRows[0].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            }
            if (!string.IsNullOrEmpty(selectedClientID))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Rasxody WHERE RasxodID = @RasxodID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@RasxodID", selectedClientID);
                            int rowsAffected = sqlCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Расход успешно удален");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось найти расход для удаления");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при удалении расхода: " + ex.Message);
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
                MessageBox.Show("Пожалуйста, выберите расход для удаления");
            }
        }

    }
}
